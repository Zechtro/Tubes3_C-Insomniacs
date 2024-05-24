using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {

        String filePath = "../test/8__M_Left_ring_finger.BMP";
        String filePath2 = "damn.bmp";
        // Image<Rgba32> img = BMPToBytes.ConvertToBlackAndWhite(filePath2);

        // process an image to ascii for each row

        // example of comparing same text
        // process bmp 
        List<string> text = BMPToBytes.ConvertBMPToASCII(filePath);

        // getting pattern
        string pattern = BMPToBytes.getImagePattern(filePath2);


        // trying to find pattern in each row of said text
        int row = 0;
        int i = -1;
        foreach (string entries in text)
        {
            i = KMPAlgorithm.KMPSearch(pattern, entries);
            if (i != -1)
            {
                break;
            }
            row++;

        }
        if (i != -1)
        {
            Console.WriteLine("Find at row : " + row + " at index " + i);
            Console.WriteLine("ROW : " + text[row]);
        }
        else
        {
            Console.WriteLine("Not exact match !");
        }



        // foreach (string entry in text){
        //     Console.WriteLine(entry);
        // }
        // string t1 = "ABCLOVELIFEAD";
        // string t2 = "LOVE";
        // int  i = KMPAlgorithm.KMPSearch(t2, t1);
        // Console.WriteLine(i);
        // BMPToBytes.getImagePattern(filePath2);

    }
}
