using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;

namespace BusinessLayer.ServiceLayer
{
    public class EncodingDecoding : IEncodingDecoding
    {
        public string Base64Decoding(string str)
        {
            throw new NotImplementedException();
        }

        public string Base64Encoding(string str)
        {
            var strBytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(strBytes);
        }

        public string DecodeString(string str)
        {
            throw new NotImplementedException();
        }

        public string DecodeXML(string xml)
        {
            throw new NotImplementedException();
        }

        public string EncodeString(string str)
        {
            throw new NotImplementedException();
        }

        public string EncodeXML(string xml)
        {
            throw new NotImplementedException();
        }
    }
}
