using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IEncoderDecoder
    {
        string XMLEncoder(string plainTextStr);
        string XMLDecoder(string encodedXMLStr);        
        string Base64Encoder(string plainTextStr);
        string Base64Decoder(string encodedBase64Str);
    }
}
