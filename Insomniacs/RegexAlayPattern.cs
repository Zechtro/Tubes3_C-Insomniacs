using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class RegexAlayPattern
{
    private Dictionary<char, string> leetMap;
    private string regexPattern;

    public RegexAlayPattern()
    {
        leetMap = new Dictionary<char, string>
        {
            { 'a', "4@" }, { 'e', "3" }, { 'i', "1!|" }, { 'o', "0" }, { 'u', "" },
            { 's', "$5" }, { 't', "7+" }, { 'l', "1|" }, { 'z', "2" }, { 'g', "6" }
        };
        regexPattern = "";
    }

    public void GeneratePattern(string baseString)
    {
        StringBuilder patternBuilder = new StringBuilder();
        foreach (char c in baseString.ToLower())
        {
            // Periksa apakah bisa diubah menjadi angka
            if (leetMap.ContainsKey(c))
            {
                // Periksa apakah vowel
                if ("aeiou".IndexOf(c) >= 0)
                {
                    // Jika vowel maka dibuat opsional
                    patternBuilder.Append('[');
                    patternBuilder.Append(c);
                    foreach (char leetChar in leetMap[c])
                    {
                        patternBuilder.Append(leetChar);
                    }
                    patternBuilder.Append("]?");
                }
                else
                {
                    // Jika non-vowel wajib
                    patternBuilder.Append('[');
                    patternBuilder.Append(c);
                    foreach (char leetChar in leetMap[c])
                    {
                        patternBuilder.Append(leetChar);
                    }
                    patternBuilder.Append(']');
                }
            }
            else
            {
                // Selain itu tampilkan sebagai literal wajib
                patternBuilder.Append(Regex.Escape(c.ToString()));
            }
        }
        regexPattern = patternBuilder.ToString();
    }

    public bool IsMatch(string input)
    {
        // dibuat case insensitive disini
        return Regex.IsMatch(input.ToLower(), regexPattern);
    }

    public string GetPattern()
    {
        return regexPattern;
    }
}
