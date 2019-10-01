﻿using BusinessLayer.ServiceLayer;
using System;
using BusinessLayer.Enums;
using System.Text;

namespace DevTools
{
    class Program
    {
        static void Main(string[] args)
        {
            StringConcat();
        }

        static void StringConcat()
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
            var obj = new StringOperations();
            Console.WriteLine(obj.StringConcat(array));
            Console.ReadLine();

        }

        static void StringCaseFormatting()
        {
            Console.WriteLine("Input your string");
            string str = Console.ReadLine(); ;
            Console.WriteLine("Select \n1 for Lower Case\n2 for Upper Case");
            CaseTypeEnum caseType = (CaseTypeEnum)(int.Parse(Console.ReadLine()));
            var obj = new StringOperations();
            var result = obj.StringCaseFormatting(str, caseType);
            Console.WriteLine("Reversed string is :\n" + result);
            Console.ReadKey();
        }

        static void ReverseString()
        {
            Console.WriteLine("Input your string");
            string str = Console.ReadLine(); ;
            var obj = new StringOperations();
            var result = obj.ReverseString(str);
            Console.WriteLine("Reversed string is :" + result);
        }
        static void PasswordEncryptorDecryptor()
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
            var obj = new EncoderDecoder();
            Console.WriteLine("Select Character Set to Encode your string.\n Press 1 for ASCII, 2 for UTF-8\n");
            CharacterSetEnum charSetEnum = (CharacterSetEnum)(int.Parse(Console.ReadLine()));

            string base64Encoded = obj.Base64Encoder(plainText, charSetEnum);
            Console.WriteLine("Encoded string using Base 64 format: \n{0}", base64Encoded);
            string base64Decoded = obj.Base64Decoder(base64Encoded, charSetEnum);
            Console.WriteLine("Decoded string using Base 64 Format: \n{0}", base64Decoded, charSetEnum);
        }
        void FormatXMLString()
        {
            string xml = "<?xml version='1.0'?>                  <response><error code='1'>Success</error>         </response>                ";
            var obj = new EncoderDecoder();
            Console.WriteLine(obj.FormatXMLString(xml));
            Console.WriteLine(obj.FormatXMLStringLINQ(xml));
        }
        void XMLEncoderDecoderTask()
        {
            string xml = "<?xml version='1.0'?>                  <response><error code='1'>Success</error>         </response>                ";
            var obj = new EncoderDecoder();
            string formattedXML = obj.FormatXMLString(xml);
            Console.WriteLine("Formatted XML: \n" + formattedXML);
            string encodeXMLHTTPUtility = obj.XMLEncoder(formattedXML, UtilityEnum.HTTPUtility);
            Console.WriteLine("Encoded XML using HTTPUtility: \n" + encodeXMLHTTPUtility);

            string encodeXMLWebUtility = obj.XMLEncoder(formattedXML, UtilityEnum.WebUtility);
            Console.WriteLine("Encoded XML using WebUtility: \n" + encodeXMLWebUtility);

            string decodedXMLHTTPUtility = obj.XMLDecoder(encodeXMLHTTPUtility, UtilityEnum.HTTPUtility);
            Console.WriteLine("Decoded XML using HTTPUtility: \n" + decodedXMLHTTPUtility);

            string decodedXMLWebUtility = obj.XMLDecoder(encodeXMLWebUtility, UtilityEnum.WebUtility);
            Console.WriteLine("Decoded XML using WebUtility: \n" + decodedXMLWebUtility);

            string decodedXMLDirectly = obj.XMLDecoder(encodeXMLWebUtility);
            Console.WriteLine("Decoded XML Directly: \n" + decodedXMLDirectly);

        }
    }
}
