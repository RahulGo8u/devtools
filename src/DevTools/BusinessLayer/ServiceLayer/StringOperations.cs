using BusinessLayer.Enums;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BusinessLayer.ServiceLayer
{
    public class StringOperations : IStringOperations
    {
        public char GetCharacterByIndex(string input, int index)
        {
            throw new NotImplementedException();
        }

        public Dictionary<char, int> GetCharacterCount(string input)
        {
            throw new NotImplementedException();
        }

        public int GetCountOfSubstring(string input)
        {
            throw new NotImplementedException();
        }

        public int GetIndexOfSubString(string input)
        {
            throw new NotImplementedException();
        }

        public List<int> GetMultipleIndexsOfSubString(string input)
        {
            throw new NotImplementedException();
        }

        public int GetStringLength(string input)
        {
            return input.Length;
        }

        public Dictionary<string, int> GetWordCount(string input)
        {
            throw new NotImplementedException();
        }

        public string RemoveUnwantedWhiteSpace(string input)
        {
            throw new NotImplementedException();
        }

        public string ReplaceSubstring(string findSubstring, string subStrToReplace)
        {
            throw new NotImplementedException();
        }

        public string ReverseEachWordOfString(string input)
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

        public string StringCaseFormatting(string input, CaseTypeEnum caseType)
        {
            switch (caseType)
            {
                case CaseTypeEnum.Lower:
                    return input.ToLower();
                case CaseTypeEnum.Upper:
                    return input.ToUpper();
                default:
                    return input;
            }            
        }

        public string StringConcat(params string[] values)
        {
            throw new NotImplementedException();
        }
    }
}
