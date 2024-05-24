using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main()
    {



        string test = "kajsnd.aladlka.lsfdm.ladsdfasdfnmdfssakjdLKASJDLKAsd";
        string test2 = "asdkjhdsfglsdfsdfasdfnmdfsasdasdasdadsf";
        string pattern = "sdfasdfnmdfs";
        BoyerMoore bm = new BoyerMoore(pattern);
        KMPAlgorithm kmp = new KMPAlgorithm(pattern);

        int result = bm.Search(test);
        int result2 = bm.Search(test2);
        int result3 = kmp.Search(test);
        int result4 = kmp.Search(test2);
        if (result != -1)
        {
            Console.WriteLine($"Pattern found at index {result}");
            Console.WriteLine($"Pattern found at index {result2}");
            Console.WriteLine($"Pattern found at index {result3}");
            Console.WriteLine($"Pattern found at index {result4}");
        }
        else
        {
            Console.WriteLine("Pattern not found");
        }
    }
}
