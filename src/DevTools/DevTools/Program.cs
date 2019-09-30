using BusinessLayer.ServiceLayer;
using System;

namespace DevTools
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "My Name is Rahul";
            var obj = new EncoderDecoder();
            string encodedBase64Str = obj.Base64Encoder(inputStr);
            Console.WriteLine("Encoded Base 64 string: "+ encodedBase64Str);
            string decodedBase64Str = obj.Base64Decoder(encodedBase64Str);
            Console.WriteLine("Decoded Base 64 string: " + decodedBase64Str);
        }
    }
}
