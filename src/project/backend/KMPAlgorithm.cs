
namespace WinFormsApp3.backend
{
    public class KMPAlgorithm : IBaseAlgorithm
    {
        private string pattern;
        private int[] lps;

        public KMPAlgorithm(string pattern)
        {
            if (string.IsNullOrEmpty(pattern))
            {
                throw new ArgumentException("Pattern cannot be null or empty.");
            }

            this.pattern = pattern;
            this.lps = new int[pattern.Length];
            ComputeLPSArray();
        }

        private void ComputeLPSArray()
        {
            int M = pattern.Length;
            int length = 0;
            lps[0] = 0; // lps[0] is always 0
            int i = 1;

            while (i < M)
            {
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
        public int Search(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Text cannot be null or empty.");
            }

            int M = pattern.Length;
            int N = text.Length;

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
                    // Console.WriteLine("Found pattern at index " + (i - j));
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


        public int searchAllRows(List<string> text)
        {

            // for one image
            int i = -1;
            foreach (string entries in text)
            {
                i = this.Search(entries);
                if (i != -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }


}
