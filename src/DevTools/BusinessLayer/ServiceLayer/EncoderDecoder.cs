using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;

namespace BusinessLayer.ServiceLayer
{
    public class EncoderDecoder : IEncoderDecoder
    {
        public string Base64Decoder(string encodedBase64Str)
        {
            var decodedByteArr = Convert.FromBase64String(encodedBase64Str);
            return Encoding.UTF8.GetString(decodedByteArr);
        }

        public string Base64Encoder(string plainTextStr)
        {
            var encodedByteArr = Encoding.UTF8.GetBytes(plainTextStr);
            return Convert.ToBase64String(encodedByteArr);
        }        

        public string XMLDecoder(string encodedXMLStr)
        {
            throw new NotImplementedException();
        }
        
        public string XMLEncoder(string plainTextStr)
        {
            throw new NotImplementedException();
        }
    }
}
