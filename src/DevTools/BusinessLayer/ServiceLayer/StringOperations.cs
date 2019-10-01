using BusinessLayer.Enums;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLayer.ServiceLayer
{
    public class StringOperations : IStringOperations
    {
        /// <summary>
        /// Get position of character at position
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetCharacterAtPosition(string str, int index)
        {
            return str[index].ToString();
        }
        
        /// <summary>
        /// Get all count of characters of a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Dictionary<char, int> GetCharacterCount(string str)
        {
            var charCountLst = str.ToCharArray().GroupBy(x => x).Select(grp => new { key = grp.Key, count = grp.Count() }).OrderBy(y=>y.count).ToDictionary(t => t.key, t => t.count);
            return charCountLst;
        }
        
        /// <summary>
        /// Remove all white spaces from a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string RemoveAllWhiteSpaces(string str)
        {
            string output = Regex.Replace(str, @"\s+", "");
            return output;
        }
        
        /// <summary>
        /// Get count of text
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetCountOfSubstring(string str, string text)
        {
            return Regex.Matches(str, text).Count;
        }
        
        /// <summary>
        /// Get First index of Substring
        /// </summary>
        /// <param name="input"></param>
        /// <param name="subStr"></param>
        /// <returns></returns>
        public int GetFirstIndexOfSubString(string str, string subStr)
        {
            return str.IndexOf(subStr);
        }

        /// <summary>
        /// Get all position of substring
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<int> GetAllIndexesOfSubString(string str)
        {
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += str.Length)
            {
                index = str.IndexOf(str, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
        
        /// <summary>
        /// Get Length of string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int GetStringLength(string str)
        {
            return str.Length;
        }
        
        /// <summary>
        /// Get count of all words in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int CountOfWords(string str)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            int count = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return count;
        }
        
        /// <summary>
        /// Get All word counts in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Dictionary<string, int> GetAllWordsCount(string str)
        {
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var wrdCounts = str.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x).Select(grp => new { str = grp.Key, count = grp.Count() }).OrderBy(y => y.count).ToDictionary(t => t.str, t => t.count);
            return wrdCounts;
        }

        /// <summary>
        /// Remove unwanted spaces
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveUnwantedWhiteSpace(string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }

        /// <summary>
        /// Replace substring in a string
        /// </summary>
        /// <param name="orgStr"></param>
        /// <param name="findSubstring"></param>
        /// <param name="subStrToReplace"></param>
        /// <returns></returns>
        public string ReplaceSubstring(string orgStr, string findSubstring, string subStrToReplace)
        {
            return orgStr.Replace(findSubstring, subStrToReplace);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseEachWordOfString(string str)
        {            
            string strrev = "";
            char[] punctuation = new char[] { ' ', ',', '.', ':', '\t', '?', '!', '@', '#' };   // note the space!

            // convert the input to char[]
            char[] inputAsChars = str.ToCharArray();

            // step through the char[] looking for punctuation and spaces
            string temp = "";
            foreach (char c in inputAsChars)
            {
                if (punctuation.Contains(c))
                {
                    //found a word separator so reverse what we have so far
                    char[] tx = temp.ToCharArray();
                    Array.Reverse(tx);
                    temp = new string(tx);
                    strrev += temp + c;    // make sure we add on the separator
                    temp = "";
                }
                else
                    temp += c; //otherwise add the char to the end of our temporary word
            }
            return strrev;
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseString(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = str.Length - 1, j = 0; i >= 0; --i, ++j)
            {
                chars[j] = str[i];
            }
            return new string(chars);
        }

        /// <summary>
        /// Splitting string using substring
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public string[] SplitStringBySubstring(string filter)
        {
            string data = "THExxQUICKxxBROWNxxFOX";

            return data.Split(new string[] { "xx" }, StringSplitOptions.None);
        }

        /// <summary>
        /// String Case formatting
        /// </summary>
        /// <param name="str"></param>
        /// <param name="caseType"></param>
        /// <returns></returns>
        public string StringCaseFormatting(string str, CaseTypeEnum caseType)
        {
            switch (caseType)
            {
                case CaseTypeEnum.Lower:
                    return str.ToLower();
                case CaseTypeEnum.Upper:
                    return str.ToUpper();
                default:
                    return str;
            }            
        }

        /// <summary>
        /// Concat multiple strings
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public string StringConcat(string[] values)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in values)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
