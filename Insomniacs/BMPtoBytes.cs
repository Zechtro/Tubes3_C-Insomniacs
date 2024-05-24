using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Text;

public class BMPToBytes
{
    public static Image<Rgba32> ConvertToBlackAndWhite(string filePath)
    {
        Image<Rgba32> image;
        try
        {
            image = Image.Load<Rgba32>(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image: {ex.Message}");
            throw;
        }

        image.Mutate(ctx => ctx.BinaryThreshold(0.5f));
        return image;
    }

    
    public static List<string> ConvertBMPToASCII(Image<Rgba32> image)
    {
        List<string> asciiRows = new List<string>();
        int width = image.Width;
        int height = image.Height;

        for (int y = 0; y < height; y++)
        {
            StringBuilder rowAscii = new StringBuilder();
            StringBuilder binaryString = new StringBuilder();
            for (int x = 0; x < width; x++)
            {
                Rgba32 pixel = image[x, y];
                bool isWhite = pixel.R > 128 && pixel.G > 128 && pixel.B > 128;

                char binaryChar = isWhite ? '1' : '0'; // Using '1' for white and '0' for black
                binaryString.Append(binaryChar);

                // Group binary bits into bytes (8 bits)
                if (binaryString.Length == 8)
                {
                    byte b = Convert.ToByte(binaryString.ToString(), 2);
                    rowAscii.Append((char)b);
                    binaryString.Clear();
                }
            }

            // Handle any remaining bits (less than 8 bits)
            if (binaryString.Length > 0)
            {   
                // TODO: Find better way of handling binary length less than 8
                while (binaryString.Length < 8)
                {
                    binaryString.Append('0'); // Pad with zeros
                }
                byte b = Convert.ToByte(binaryString.ToString(), 2);
                rowAscii.Append((char)b);
            }

            asciiRows.Add(rowAscii.ToString());
        }

        return asciiRows;
    }
}
