using BusinessLayer.ServiceLayer;
using System;
using BusinessLayer.Enums;
using System.Text;

namespace DevTools
{
    class Program
    {
        static readonly StringOperations objStrOperations;
        static readonly EncoderDecoder objEncoderDecoder;
        static readonly Program objProgram;
        static Program()
        {
            objProgram = new Program();
            objStrOperations = new StringOperations();
            objEncoderDecoder = new EncoderDecoder();
        }        
        static void Main(string[] args)
        {
            
        }
        void RemoveAllWhiteSpaces()
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            var result = objStrOperations.RemoveAllWhiteSpaces(str);
            Console.WriteLine("Formatted strin is:\n");
            Console.WriteLine(result);
        }
        void GetCharacterCount()
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            Console.WriteLine("Formatting string, Removing all spaces");
            str = objStrOperations.RemoveAllWhiteSpaces(str);
            Console.WriteLine("Formatted string after removing white spaces");
            Console.WriteLine(str);
            var charCountLst = objStrOperations.GetCharacterCount(str);
            Console.WriteLine("Character Counts are:\n");
            foreach (var charCount in charCountLst)
            {
                Console.WriteLine(charCount.Key + " : " + charCount.Value);
            }
            Console.ReadKey();
        }

        void GetCharacterAtPosition()
        {
            string str = "The main target is down in hill";
            int index = 17;
            string c = objStrOperations.GetCharacterAtPosition(str, index);
            Console.WriteLine(c);
        }
        void StringConcat()
        {
            Console.WriteLine("How many text you want to join");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            Console.WriteLine("Input your strings in seperate lines");
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Your Final string is:\n");            
            Console.WriteLine(objStrOperations.StringConcat(array));
            Console.ReadLine();
        }
        void StringCaseFormatting()
        {
            Console.WriteLine("Input your string");
            string str = Console.ReadLine(); ;
            Console.WriteLine("Select \n1 for Lower Case\n2 for Upper Case");
            CaseTypeEnum caseType = (CaseTypeEnum)(int.Parse(Console.ReadLine()));
            var result = objStrOperations.StringCaseFormatting(str, caseType);
            Console.WriteLine("Reversed string is :\n" + result);
            Console.ReadKey();
        }
        void ReverseString()
        {
            Console.WriteLine("Input your string");
            string str = Console.ReadLine(); ;
            var obj = new StringOperations();
            var result = objStrOperations.ReverseString(str);
            Console.WriteLine("Reversed string is :" + result);
        }
        void PasswordEncryptorDecryptor()
        {
            Console.WriteLine("Please enter a passphrase to use:");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter your string to encrypt:");
            string plaintext = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = EncryptorDecryptor.Encrypt(plaintext, password);
            Console.WriteLine(encryptedstring);
            Console.WriteLine("");

            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = EncryptorDecryptor.Decrypt(encryptedstring, password);
            Console.WriteLine(decryptedstring);
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
        void Base64EncodingDecodingTask()
        {
            Console.WriteLine("Input your String");
            string plainText = Console.ReadLine();            
            Console.WriteLine("Select Character Set to Encode your string.\n Press 1 for ASCII, 2 for UTF-8\n");
            CharacterSetEnum charSetEnum = (CharacterSetEnum)(int.Parse(Console.ReadLine()));

            string base64Encoded = objEncoderDecoder.Base64Encoder(plainText, charSetEnum);
            Console.WriteLine("Encoded string using Base 64 format: \n{0}", base64Encoded);
            string base64Decoded = objEncoderDecoder.Base64Decoder(base64Encoded, charSetEnum);
            Console.WriteLine("Decoded string using Base 64 Format: \n{0}", base64Decoded, charSetEnum);
        }
        void FormatXMLString()
        {
            string xml = "<?xml version='1.0'?>                  <response><error code='1'>Success</error>         </response>                ";            
            Console.WriteLine(objEncoderDecoder.FormatXMLString(xml));
            Console.WriteLine(objEncoderDecoder.FormatXMLStringLINQ(xml));
        }
        void XMLEncoderDecoderTask()
        {
            string xml = "<?xml version='1.0'?>                  <response><error code='1'>Success</error>         </response>                ";
            string formattedXML = objEncoderDecoder.FormatXMLString(xml);
            Console.WriteLine("Formatted XML: \n" + formattedXML);
            string encodeXMLHTTPUtility = objEncoderDecoder.XMLEncoder(formattedXML, UtilityEnum.HTTPUtility);
            Console.WriteLine("Encoded XML using HTTPUtility: \n" + encodeXMLHTTPUtility);

            string encodeXMLWebUtility = objEncoderDecoder.XMLEncoder(formattedXML, UtilityEnum.WebUtility);
            Console.WriteLine("Encoded XML using WebUtility: \n" + encodeXMLWebUtility);

            string decodedXMLHTTPUtility = objEncoderDecoder.XMLDecoder(encodeXMLHTTPUtility, UtilityEnum.HTTPUtility);
            Console.WriteLine("Decoded XML using HTTPUtility: \n" + decodedXMLHTTPUtility);

            string decodedXMLWebUtility = objEncoderDecoder.XMLDecoder(encodeXMLWebUtility, UtilityEnum.WebUtility);
            Console.WriteLine("Decoded XML using WebUtility: \n" + decodedXMLWebUtility);

            string decodedXMLDirectly = objEncoderDecoder.XMLDecoder(encodeXMLWebUtility);
            Console.WriteLine("Decoded XML Directly: \n" + decodedXMLDirectly);

        }
    }
}
