using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IEncodingDecoding
    {
        string EncodeXML(string xml);
        string DecodeXML(string xml);
        string EncodeString(string str);
        string DecodeString(string str);
        string Base64Encoding(string str);
        string Base64Decoding(string str);
    }
}
