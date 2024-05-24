using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main()
    {
        RegexAlayPattern regexAlay = new RegexAlayPattern();
        regexAlay.GeneratePattern("Demetrius Demarcus Bartholomew James The Third");

        Console.WriteLine("Regex Pattern: " + regexAlay.GetPattern());
        Console.WriteLine(regexAlay.IsMatch("demetrI5 d3M4rC5 brThlm3w Jms tH thiRd")); // True
        Console.WriteLine(regexAlay.IsMatch("DM3tr1s Dmrcs b4rthLmw Jm5 th thrd")); // True
        Console.WriteLine(regexAlay.IsMatch("dmtr5 Dm4rCUs b4rThLm3w jm5 tH THrd")); // True
        Console.WriteLine(regexAlay.IsMatch("dmtr1U5 dmrcuS brthlm3w j4m5 Th thrd")); // True
    }
}
