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

        public string ReplaceSubstring(string findSubstring, string subStrToReplace)
        {
            throw new NotImplementedException();
        }

        public string ReverseEachWordOfString(string str)
        {
            throw new NotImplementedException();
        }

        public string ReverseString(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = str.Length - 1, j = 0; i >= 0; --i, ++j)
            {
                chars[j] = str[i];
            }
            return new string(chars);
        }

        public string[] SplitStringBySubstring(string filter)
        {
            throw new NotImplementedException();
        }

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

        public string StringConcat(params string[] values)
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
