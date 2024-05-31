

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.Text;
public class BMPToBytes
{
    public static SixLabors.ImageSharp.Image<Rgba32> ConvertToBlackAndWhite(string filePath)
    {
        SixLabors.ImageSharp.Image<Rgba32> image;
        image = SixLabors.ImageSharp.Image.Load<Rgba32>(filePath);
        try
        {
            // load filePath
            image = SixLabors.ImageSharp.Image.Load<Rgba32>(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image: {ex.Message}");
            throw ex;
        }

        // pixels with grayscale value  > 0.5 will be white
        // pixels with grayscale value  <= 0.5 will be white
        image.Mutate(ctx => ctx.BinaryThreshold(0.5f));
        return image;
    }

    public static List<string> ConvertBMPToASCII(string filePath)
    {
        var image = ConvertToBlackAndWhite(filePath);
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
                // Pad with zeros if binary length is less than 8
                while (binaryString.Length < 8)
                {
                    binaryString.Append('0');
                }
                byte b = Convert.ToByte(binaryString.ToString(), 2);
                rowAscii.Append((char)b);
            }

            asciiRows.Add(rowAscii.ToString());
        }

        for (int i = asciiRows.Count - 1; i >= 0; i--)
        {
            if (asciiRows[i].All(c => c == '\0'))
            {
                asciiRows.RemoveAt(i);
            }
            else
            {
                break;
            }
        }

        return asciiRows;
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

    public static string GetImagePattern(string filename)
    {
        try
        {
            // TODO : generate a more surefire way of picking the pattern
            var blackAndWhiteBMP = ConvertToBlackAndWhite(filename);
            List<string> binaryRows = ConvertImageToBinary(blackAndWhiteBMP);

            // TODO : try center of the image instead
            // Picking pattern from the 3/4th row of the image
            int pickedRow = (int)Math.Floor(binaryRows.Count * (3.0 / 4.0));
            string pattern = binaryRows[pickedRow];
            Console.WriteLine($"Pattern in row {pickedRow}, binary form: " + pattern);

            // TODO: find a better way to handle non length of multiple 8
            // Pad the pattern to make its length a multiple of 8
            int paddingLength = 8 - (pattern.Length % 8);
            if (paddingLength != 8)
            {
                pattern = pattern.PadRight(pattern.Length + paddingLength, '0');
            }
            List<string> segments = new List<string>();

            // Separete binary pattern into segments of 8 bits
            for (int j = 0; j < pattern.Length; j += 8)
            {
                string segment = pattern.Substring(j, 8);
                segments.Add(segment);
            }

            // TODO: determine if 64 bit pattern is better than 32 bit
            // Determine the 32 bits in the center of the row
            int minHomogeneity = int.MaxValue;
            int startIndex = 0;

            for (int z = 0; z <= segments.Count - 4; z++)
            {
                int homogeneity = 0;

                // Count the homogeneity in the current sequence of 4 segments
                for (int j = z; j < z + 4; j++)
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

            List<string> result = segments.GetRange(startIndex, 4);
            Console.Write("Filtered pattern in binary: ");
            foreach (string res in result)
            {
                Console.Write(res);
            }
            Console.WriteLine();
            StringBuilder finalPattern = new StringBuilder();
            foreach (string entry in result)
            {
                int asciiValue = Convert.ToInt32(entry, 2);
                char asciiCharacter = (char)asciiValue;
                finalPattern.Append(asciiCharacter);
            }

            return finalPattern.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
            throw e;
        }
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
