using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        // const string BASEDIR = "../";
        // // string testSource = "test/83__M_Right_middle_finger.BMP";
        // // string testSource = "test/8__M_Right_middle_finger.BMP";
        // string testSource = "test/f/1__M_Left_middle_finger_CR.BMP";
        // Image<Rgba32> image  = BMPToBytes.ConvertToBlackAndWhite(BASEDIR + testSource);
        // List<string> imageInBinary = BMPToBytes.ConvertImageToBinary(image);
        // List<string> asciiForm = BMPToBytes.ConvertBMPToASCII( BASEDIR + testSource);
        // Console.WriteLine(testSource + ": ");
        // foreach (string s in imageInBinary ){
        //     Console.WriteLine(s);
        // }

        // string imagePattern = BMPToBytes.GetImagePattern(BASEDIR + testSource);
        // Console.WriteLine("Image pattern picked");
        // Console.WriteLine(imagePattern);

        // Console.WriteLine(imagePattern.Length);


        // Console.WriteLine("ASCII FORM :");
        // foreach(string s in asciiForm){
        //     Console.WriteLine(s);
        // }

        // // RegexAlayPattern regexAlay = new RegexAlayPattern();
        // // string baseString = "Marvel Pangondian";
        // // regexAlay.GeneratePattern(baseString);
        // // string input = "M4Rvl p4N6Ondn";

        // // Console.WriteLine("Pattern: " + regexAlay.GetPattern());
        // // Console.WriteLine("Is Match: " + regexAlay.IsMatch(input));
        // // Console.WriteLine("Normalized: " + regexAlay.Normalize(input));


        // ============================================================
        // experiment with a block of code

        const string BASEDIR = "../";
        // string testSource = "test/83__M_Right_middle_finger.BMP";
        // string testSource = "test/8__M_Right_middle_finger.BMP";
        // string testSource = "test/alter/33__M_Right_middle_finger_CR.BMP";


        string testSource = "test/f/1__M_Left_middle_finger.BMP";
        string testSourceAltered = "test/f/1__M_Left_middle_finger_CR.BMP";

        Image<Rgba32> image  = BMPToBytes.ConvertToBlackAndWhite(BASEDIR + testSource);
        List<string> imageInBinary = BMPToBytes.ConvertImageToBinary(image);

        Image<Rgba32> imageAltered  = BMPToBytes.ConvertToBlackAndWhite(BASEDIR + testSourceAltered);
        List<string> imageInBinaryAltered = BMPToBytes.ConvertImageToBinary(imageAltered);


        List<string> asciiForm = BMPToBytes.ConvertBMPtoASCIIVersion2( BASEDIR + testSource);
        List<string> asciiFormAltered = BMPToBytes.ConvertBMPtoASCIIVersion2( BASEDIR + testSourceAltered);

        string pattern = BMPToBytes.GetImagePatternVersion2(BASEDIR + testSource);
        string patternAltered = BMPToBytes.GetImagePatternVersion2(BASEDIR + testSourceAltered);

        int row = 0;
        // Console.WriteLine("test/8__M_Right_middle_finger.BMP in binary: ");
        // // foreach (string s in imageInBinary ){
        // //     Console.WriteLine(s);
        // //     row++;
        // // }
        // // Console.WriteLine("Row in binary : " +row);
        // // row = 0;
        Console.WriteLine("" + testSource + " in ascii : ");
        foreach(string s in asciiForm){
            Console.WriteLine(s);
            row++;
        }

        // Console.WriteLine("Amount of rows : " + row);

        // Console.WriteLine("THIS IS THE PATTERN : " + pattern);


        Console.WriteLine("This is the pattern ! : " + pattern);

        // using boyer moore:
        BoyerMoore bm = new BoyerMoore(pattern);

        int location = bm.SearchAllRows(asciiFormAltered);
        if (location != -1){
            Console.WriteLine();
            Console.WriteLine("FOUND IT !!!");
            Console.WriteLine(asciiFormAltered[location]);
        }

    }
}


