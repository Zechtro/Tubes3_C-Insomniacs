using System;
using System.Drawing;
using System.IO;

class ImageConverter
{
    static byte[] ConvertBmpToBinary(string inputFilePath, string outputFilePath)
    {
        using (Bitmap bmp = new Bitmap(inputFilePath))
        {
            int pixelCount = bmp.Width * bmp.Height * 3;
            byte[] pixelData = new byte[pixelCount];

            int index = 0;

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    pixelData[index++] = pixelColor.R;
                    pixelData[index++] = pixelColor.G;
                    pixelData[index++] = pixelColor.B;
                }
            }

            return pixelData;
        }
    }

    static string ConvertBinaryToAscii(byte[] binaryData)
    {
        StringBuilder asciiBuilder = new StringBuilder(binaryData.Length / 8);

        for (int i = 0; i < binaryData.Length; i += 8)
        {
            byte[] byteSegment = new byte[8];

            for (int j = 0; j < 8 && (i + j) < binaryData.Length; j++)
            {
                byteSegment[j] = binaryData[i + j];
            }

            char asciiChar = (char)BitConverter.ToInt64(byteSegment, 0);
            asciiBuilder.Append(asciiChar);
        }

        return asciiBuilder.ToString();
    }

}