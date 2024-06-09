

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp;
using System.Text;
public class BMPToBytes
{
    public static SixLabors.ImageSharp.Image<Rgba32> ConvertToBlackAndWhite(string filePath)
    {
        SixLabors.ImageSharp.Image<Rgba32> image;

        // load filePath
        image = SixLabors.ImageSharp.Image.Load<Rgba32>(filePath);


        // pixels with grayscale value  > 0.5 will be white
        // pixels with grayscale value  <= 0.5 will be white
        image.Mutate(ctx => ctx.BinaryThreshold(0.5f));
        return image;

    }

    public static List<string> ConvertImageToBinary(SixLabors.ImageSharp.Image<Rgba32> image)
    {
        List<string> binaryRows = new List<string>();
        int width = image.Width;
        int height = image.Height;

        for (int y = 0; y < height; y++)
        {
            StringBuilder binaryRow = new StringBuilder();
            for (int x = 0; x < width; x++)
            {
                Rgba32 pixel = image[x, y];
                bool isWhite = pixel.R > 128 && pixel.G > 128 && pixel.B > 128;

                char binaryChar = isWhite ? '1' : '0';
                binaryRow.Append(binaryChar);
            }

            binaryRows.Add(binaryRow.ToString());
        }
        binaryRows = RemoveTrailingZeroRows(binaryRows);
        return binaryRows;
    }

    public static List<string> ConvertBMPtoASCII(string filePath)
    {
        var image = ConvertToBlackAndWhite(filePath);
        List<string> asciiRows = new List<string>();
        int width = image.Width;
        int height = image.Height;

        // remove the last 7 rows
        // for each binary (1 white 0 black), in coordinate , the character representation of it will be the ascii form of binary x,y to x,y + 8
        // reference : https://informatika.stei.itb.ac.id/~rinaldi.munir/TA/Makalah-KNIF-2010.pdf

        for (int y = 0; y < height - 7; y++)
        {
            StringBuilder rowAscii = new StringBuilder();

            for (int x = 0; x < width; x++)
            {
                StringBuilder binaryString = new StringBuilder();

                // Collect 8 bits
                for (int i = 0; i < 8; i++)
                {
                    Rgba32 pixel = image[x, y + i];
                    bool isWhite = pixel.R > 128 && pixel.G > 128 && pixel.B > 128;
                    char binaryChar = isWhite ? '1' : '0';
                    binaryString.Append(binaryChar);
                }

                // Convert binary string to a byte and then to a character
                byte b = Convert.ToByte(binaryString.ToString(), 2);
                rowAscii.Append((char)b);
            }

            asciiRows.Add(rowAscii.ToString());
        }
        return asciiRows;
    }

    public static string GetImagePattern(string filename)  
    {
        var blackAndWhiteBMP = ConvertToBlackAndWhite(filename);
        List<string> binaryRows = ConvertImageToBinary(blackAndWhiteBMP);
        
        if (binaryRows.Count == 0){
            throw new Exception("Cannot process a black image");
        }
        if (binaryRows.Count <= 40 || binaryRows[0].Length <= 40){
            throw new Exception("Image is to small to process !");
        }

        // picking top, center, and bottom pattern
        // pick all possible rows
        string pickedPattern = "";
        int pickedHomogenity = int.MaxValue;
        string pickedPatternInBinary = "";

        int pickedPatternRow = -1;
        string pattern;
        List<string> segments;

        int[] allRow = new int[3];
        for (int i = 0; i < 3; i++)
        {
            allRow[i] = (int)Math.Floor(binaryRows.Count * ((i + 1) / 4.0));
            Console.WriteLine(allRow[i]);
        }


        for (int patternIndex = 0; patternIndex < 3; patternIndex++)
        {
            int rowIndexInBinaryRows = allRow[patternIndex];
            pattern = binaryRows[allRow[patternIndex]]; // starting row picked

            segments = new List<string>();
            for (int j = 0; j < pattern.Length; j += 1)
            {
                string segment = "";
                for (int i = 0; i < 8 && rowIndexInBinaryRows + i < binaryRows.Count; i++)
                {
                    segment += binaryRows[rowIndexInBinaryRows + i][j];
                }
                segments.Add(segment);
            }

            // get 30 characters
            int minHomogeneity = int.MaxValue;
            int startIndex = 0;

            for (int z = 0; z <= segments.Count - 30; z++)
            {
                int homogeneity = 0;
                // Count the homogeneity in the current sequence of 30 segments
                for (int j = z; j < z + 30; j++)
                {
                    int zeroCount = segments[j].Count(c => c == '0');
                    int oneCount = 8 - zeroCount;
                    homogeneity += Math.Abs(zeroCount - oneCount);
                }
                // Update the minimum homogeneity and the starting index if necessary
                if (homogeneity < minHomogeneity)
                {
                    minHomogeneity = homogeneity;
                    startIndex = z;
                }
            }

            if (minHomogeneity < pickedHomogenity)
            {
                pickedPatternInBinary = "";
                List<string> result = segments.GetRange(startIndex, 30);
                StringBuilder finalPattern = new StringBuilder();
                foreach (string entry in result)
                {
                    pickedPatternInBinary += entry;
                    int asciiValue = Convert.ToInt32(entry, 2);
                    char asciiCharacter = (char)asciiValue;
                    finalPattern.Append(asciiCharacter);
                }
                pickedPattern = finalPattern.ToString();
                pickedHomogenity = minHomogeneity;
                pickedPatternRow = allRow[patternIndex];
            }
        }

        if (pickedPattern.All(c => c == 'ÿ' )){
            throw new Exception("Unable to process image");
        }

        if (string.IsNullOrEmpty(pickedPattern))
        {
            throw new Exception("Error in coverting fingerprint to a pattern");
        }
        return pickedPattern;
    }


    private static List<string> RemoveTrailingZeroRows(List<string> binaryRows)
    {
        for (int i = binaryRows.Count - 1; i >= 0; i--)
        {
            if (binaryRows[i].All(c => c == '0'))
            {
                binaryRows.RemoveAt(i);
            }
            else
            {
                break;
            }
        }
        return binaryRows;
    }
}