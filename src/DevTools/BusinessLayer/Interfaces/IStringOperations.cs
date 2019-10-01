using BusinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    interface IStringOperations
    {
        string ReverseString(string str);
        int GetStringLength(string str);
        Dictionary<char, int> GetCharacterCount(string str);
        Dictionary<string, int> GetAllWordsCount(string str);
        string StringConcat(string[] values);
        int GetFirstIndexOfSubString(string str, string subStr);
        List<int> GetAllIndexesOfSubString(string str);
        string ReverseEachWordOfString(string str);
        int GetCountOfSubstring(string str, string text);
        string StringCaseFormatting(string str, CaseTypeEnum caseType);
        string RemoveUnwantedWhiteSpace(string str);
        string ReplaceSubstring(string orgStr, string findSubstring, string subStrToReplace);
        //CompareStrings(string firstStr, string secondStr);
        string GetCharacterAtPosition(string str, int index);
        string[] SplitStringBySubstring(string filter);
    }
}
