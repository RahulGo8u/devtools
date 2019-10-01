using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IEncoderDecoder
    {
        string XMLDecoder(string encodedXMLStr, UtilityEnum utility);
        string XMLEncoder(string plainText, UtilityEnum utility);
        string Base64Encoder(string plainText, CharacterSetEnum charSet);
        string Base64Decoder(string base64Encoded, CharacterSetEnum charSet);
    }
}
