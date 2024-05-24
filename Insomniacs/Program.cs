using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        string filePath = "damn.bmp";

        // Validate file path
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return;
        }

        Image<Rgba32> blackAndWhiteBMP;
        try
        {
            blackAndWhiteBMP = BMPToBytes.ConvertToBlackAndWhite(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Black and whtie conversion went wrong: {ex.Message}");
            return;
        }

        List<string> asciiRows;
        try
        {
            asciiRows = BMPToBytes.ConvertBMPToASCII(blackAndWhiteBMP);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something weng wrong: {ex.Message}");
            return;
        }

        // Print the ASCII characters for each row
        for (int i = 0; i < asciiRows.Count; i++)
        {
            Console.WriteLine($"Row {i}: {asciiRows[i]}");
        }
    }
}
