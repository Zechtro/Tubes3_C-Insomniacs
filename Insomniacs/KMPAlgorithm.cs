using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;


public class KMPAlgorithm
{

    private static void ComputeLPSArray(string pattern, int M, int[] lps)
    {
        int length = 0;
        lps[0] = 0; // lps[0] is always 0
        int i = 1;

        while (i < M)
        {
            // a b a b c a b c a b c
            // 0 0 1 2

            if (pattern[i] == pattern[length])
            {
                length++;
                lps[i] = length;
                i++;
            }
            else
            {
                if (length != 0)
                {
                    length = lps[length - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
    }

    // KMP search algorithm
    public static int KMPSearch(string pattern, string text)
    {
        int M = pattern.Length;
        int N = text.Length;

        // Create LPS array
        int[] lps = new int[M];
        ComputeLPSArray(pattern, M, lps);

        int i = 0; // index for text
        int j = 0; // index for pattern
        while (i < N)
        {
            if (pattern[j] == text[i])
            {
                j++;
                i++;
            }

            if (j == M)
            {
                Console.WriteLine("Found pattern at index " + (i - j));
                return (i - j);
            }
            else if (i < N && pattern[j] != text[i])
            {
                if (j != 0)
                {
                    j = lps[j - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return -1;
    }


    // public static int imageComparison(string pattern, string filePath)
    // {
    //     // process image filepath
        
    // }

    // Main function to test the KMP search algorithm

}