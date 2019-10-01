using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using BusinessLayer.Enums;
using BusinessLayer.Interfaces;

namespace BusinessLayer.ServiceLayer
{
    public class EncoderDecoder : IEncoderDecoder
    {
        #region Base64Encoder/Decoder
        public string Base64Decoder(string base64Encoded, CharacterSetEnum charSet)
        {
            string base64Decoded = "";
            byte[] decodedData = Convert.FromBase64String(base64Encoded);
            switch (charSet)
            {
                case CharacterSetEnum.ASCII:
                    base64Decoded = Encoding.ASCII.GetString(decodedData);
                    break;
                case CharacterSetEnum.UTF8:
                    base64Decoded = Encoding.UTF8.GetString(decodedData);
                    break;
                default:
                    break;
            }
            return base64Decoded;
        }
        public string Base64Encoder(string plainText, CharacterSetEnum charSet)
        {
            string base64Encoded = "";
            byte[] encodedData = null;
            switch (charSet)
            {
                case CharacterSetEnum.ASCII:
                    encodedData = Encoding.ASCII.GetBytes(plainText);
                    break;
                case CharacterSetEnum.UTF8:
                    encodedData = Encoding.UTF8.GetBytes(plainText);
                    break;
                default:
                    break;
            }
            base64Encoded = Convert.ToBase64String(encodedData);
            return base64Encoded;
        }
        #endregion Base64Encoder/Decoder

        #region XMLEncoderDecoder
        public string XMLDecoder(string encodedXML, UtilityEnum utility)
        {
            string decodedXML = "";
            switch (utility)
            {
                case UtilityEnum.HTTPUtility:
                    decodedXML = HttpUtility.HtmlDecode(encodedXML);
                    break;
                case UtilityEnum.WebUtility:
                    decodedXML = WebUtility.HtmlDecode(encodedXML);
                    break;
                default:
                    break;
            }            
            return decodedXML;
        }
        public string XMLEncoder(string plainText, UtilityEnum utility)
        {
            string encodedXML = "";
            switch (utility)
            {
                case UtilityEnum.HTTPUtility:
                    encodedXML = HttpUtility.HtmlEncode(plainText);
                    break;
                case UtilityEnum.WebUtility:
                    encodedXML = WebUtility.HtmlEncode(plainText);
                    break;
                default:
                    break;
            }
            return encodedXML;
        }
        public string XMLDecoder(string encodedXML)
        {
            string decodedXML = "";
            decodedXML = encodedXML.Replace("&lt;", "<")
                                    .Replace("&amp;", "&")
                                    .Replace("&gt;", ">")
                                    .Replace("&quot;", "\"")
                                    .Replace("&apos;", "'");
            return decodedXML;
        }
        #endregion XMLEncoderDecoder

        #region XMLFormatter
        public string FormatXMLStringLINQ(string xml)
        {
            try
            {
                XDocument doc = XDocument.Parse(xml);
                return doc.ToString();
            }
            catch (Exception)
            {
                // Handle and throw if fatal exception here; don't just ignore them
                return xml;
            }
        }
        public string FormatXMLString(string xml)
        {
            string result = "";

            MemoryStream mStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
            XmlDocument document = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                writer.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                document.WriteContentTo(writer);
                writer.Flush();
                mStream.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                mStream.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader sReader = new StreamReader(mStream);

                // Extract the text from the StreamReader.
                string formattedXml = sReader.ReadToEnd();

                result = formattedXml;
            }
            catch (XmlException)
            {
                // Handle the exception
            }

            mStream.Close();
            writer.Close();

            return result;
        }
        #endregion XMLFormatter
    }
}
