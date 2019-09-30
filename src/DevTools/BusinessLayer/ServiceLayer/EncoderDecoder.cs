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
            byte[] decodedData = Convert.FromBase64String(base64EncodedStr);
            switch (charSet)
            {
                case CharacterSetEnum.ASCII:
                    base64DecodedStr = Encoding.ASCII.GetString(decodedData);
                    break;
                case CharacterSetEnum.UTF8:
                    base64DecodedStr = Encoding.UTF8.GetString(decodedData);
                    break;
                default:
                    break;
            }
            return base64DecodedStr;
        }

        public string Base64Encoder(string plainTextStr, CharacterSetEnum charSet)
        {            
            string base64EncodedStr = "";
            byte[] encodedData = null;
            switch (charSet)
            {
                case CharacterSetEnum.ASCII:
                    encodedData = Encoding.ASCII.GetBytes(plainTextStr);                    
                    break;
                case CharacterSetEnum.UTF8:
                    encodedData = Encoding.UTF8.GetBytes(plainTextStr);                    
                    break;
                default:
                    break;
            }
            base64EncodedStr = Convert.ToBase64String(encodedData);
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
