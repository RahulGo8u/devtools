using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Enums;
using BusinessLayer.Interfaces;

namespace BusinessLayer.ServiceLayer
{
    public class EncoderDecoder : IEncoderDecoder
    {
        public string Base64Decoder(string base64EncodedStr, CharacterSetEnum charSet)
        {
            string base64DecodedStr = "";
            byte[] data = Convert.FromBase64String(base64EncodedStr);
            switch (charSet)
            {
                case CharacterSetEnum.US_ASCII:
                    base64DecodedStr = Encoding.ASCII.GetString(data);
                    break;
                case CharacterSetEnum.UTF_8:
                    base64DecodedStr = Encoding.UTF8.GetString(data);
                    break;
                default:
                    break;
            }
            return base64DecodedStr;
        }

        public string Base64Encoder(string plainTextStr, CharacterSetEnum charSet)
        {            
            string base64EncodedStr = "";
            byte[] data = null;
            switch (charSet)
            {
                case CharacterSetEnum.US_ASCII:
                    data = Encoding.ASCII.GetBytes(plainTextStr);                    
                    break;
                case CharacterSetEnum.UTF_8:
                    data = Encoding.UTF8.GetBytes(plainTextStr);                    
                    break;
                default:
                    break;
            }
            base64EncodedStr = Convert.ToBase64String(data);
            return base64EncodedStr;
        }
        public string XMLDecoder(string encodedXMLStr, CharacterSetEnum charSet)
        {
            throw new NotImplementedException();
        }
        
        public string XMLEncoder(string plainTextStr, CharacterSetEnum charSet)
        {
            throw new NotImplementedException();
        }

        public string FormatXMLString(string inputXML)
        {
            return "";
        }
    }
}
