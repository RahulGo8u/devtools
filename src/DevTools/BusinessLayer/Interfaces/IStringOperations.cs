using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IStringOperations
    {
        string ReverseString(string str);
        int GetStringLength(string input);
        Dictionary<char, int> GetCharacterCount(string input);
        Dictionary<string, int> GetWordCount(string input);
        string StringConcat(params string[] values);
        int GetIndexOfSubString(string input);
        List<int> GetMultipleIndexsOfSubString(string input);
        string ReverseEachWordOfString(string input);
        int GetCountOfSubstring(string input);
        string StringCaseFormatting(string input, CaseTypeEnum caseType);
        string RemoveUnwantedWhiteSpace(string input);
        string ReplaceSubstring(string findSubstring, string subStrToReplace);
        //CompareStrings(string firstStr, string secondStr);
        char GetCharacterByIndex(string input, int index);
        string[] SplitStringBySubstring(string filter);
    }
}
