using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IEncoderDecoder
    {
        string XMLDecoder(string encodedXMLStr, CharacterSetEnum charSet);
        string XMLEncoder(string plainTextStr, CharacterSetEnum charSet);
        string Base64Encoder(string plainTextStr, CharacterSetEnum charSet);
        string Base64Decoder(string base64EncodedStr, CharacterSetEnum charSet);
    }
}
