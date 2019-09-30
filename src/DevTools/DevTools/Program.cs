using BusinessLayer.ServiceLayer;
using System;
using BusinessLayer.Enums;

namespace DevTools
{
    class Program
    {
        static void Main(string[] args)
        {            
            
        }
        void Base64EncodingDecodingTask()
        {
            Console.WriteLine("Input your String");
            string plainTextInputStr = Console.ReadLine();
            var obj = new EncoderDecoder();
            Console.WriteLine("Select Character Set to Encode your string.\n Press 1 for ASCII, 2 for UTF-8\n");
            CharacterSetEnum charSetEnum = (CharacterSetEnum)(int.Parse(Console.ReadLine()));

            string base64EncodedStr = obj.Base64Encoder(plainTextInputStr, charSetEnum);
            Console.WriteLine("Encoded string using Base 64 format: \n{0}", base64EncodedStr);
            string base64DecodedStr = obj.Base64Decoder(base64EncodedStr, charSetEnum);
            Console.WriteLine("Decoded string using Base 64 Format: \n{0}", base64DecodedStr, charSetEnum);
        }
    }
}
