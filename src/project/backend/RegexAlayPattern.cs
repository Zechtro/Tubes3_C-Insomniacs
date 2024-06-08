using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class RegexAlayPattern
{
    private Dictionary<char, string> leetMap;
    private Dictionary<char, char> reverseLeetMap;
    private string regexPattern;

    public RegexAlayPattern()
    {
        leetMap = new Dictionary<char, string>
        {
            { 'a', "4@" }, { 'e', "3" }, { 'i', "1!|" }, { 'o', "0" }, { 'u', "" },
            { 's', "$5" }, { 't', "7+" }, { 'l', "1|" }, { 'z', "2" }, { 'g', "6" }
        };
        reverseLeetMap = new Dictionary<char, char>
        {
            { '4', 'a' }, { '@', 'a' }, { '3', 'e' }, { '1', 'i' }, { '!', 'i' },
            { '|', 'i' }, { '0', 'o' }, { '$', 's' }, { '5', 's' }, { '7', 't' },
            { '+', 't' }, { '2', 'z' }, { '6', 'g' }
        };
        regexPattern = "";
    }

    public void GeneratePattern(string baseString)
    {
        StringBuilder patternBuilder = new StringBuilder();
        bool isFirstChar = true;

        foreach (char c in baseString.ToLower())
        {
            if (leetMap.ContainsKey(c))
            {
                patternBuilder.Append('[');
                patternBuilder.Append(c);
                foreach (char leetChar in leetMap[c])
                {
                    patternBuilder.Append(leetChar);
                }
                if ("aeiou".IndexOf(c) >= 0 && !isFirstChar)
                {
                    patternBuilder.Append("]?");
                }
                else
                {
                    patternBuilder.Append(']');
                }
            }
            else
            {
                patternBuilder.Append(Regex.Escape(c.ToString()));
            }
            isFirstChar = false;
        }

        regexPattern = patternBuilder.ToString();
    }

    public bool IsMatch(string input)
    {
        return Regex.IsMatch(input.ToLower(), regexPattern);
    }

    public string GetPattern()
    {
        return regexPattern;
    }

    public string Normalize(string input)
    {
        StringBuilder normalizedText = new StringBuilder();
        foreach (char c in input)
        {
            if (reverseLeetMap.ContainsKey(c))
            {
                normalizedText.Append(reverseLeetMap[c]);
            }
            else
            {
                normalizedText.Append(c);
            }
        }
        return normalizedText.ToString().ToLower();
    }
}