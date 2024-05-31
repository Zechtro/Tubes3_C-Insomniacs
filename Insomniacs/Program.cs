using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        const string BASEDIR = "../";
        // string testSource = "test/83__M_Right_middle_finger.BMP";
        string testSource = "test/8__M_Right_middle_finger.BMP";
        Image<Rgba32> image  = BMPToBytes.ConvertToBlackAndWhite(BASEDIR + testSource);
        List<string> imageInBinary = BMPToBytes.ConvertImageToBinary(image);
        List<String> asciiForm = BMPToBytes.ConvertBMPToASCII( BASEDIR + testSource);
        Console.WriteLine("83__M_Right_middle_finger: ");
        foreach (string s in imageInBinary ){
            Console.WriteLine(s);
        }
        
        string imagePattern = BMPToBytes.GetImagePattern(BASEDIR + testSource);
        Console.WriteLine("Image pattern picked");
        Console.WriteLine(imagePattern);

        Console.WriteLine(imagePattern.Length);


        Console.WriteLine("ASCII FORM :");
        foreach(string s in asciiForm){
            Console.WriteLine(s);
        }
    }
}


