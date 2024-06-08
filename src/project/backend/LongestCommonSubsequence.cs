using System.Diagnostics;

public class LongestCommonSubsequence : IBaseAlgorithm
{
    private string pattern;

    public LongestCommonSubsequence(string pattern)
    {
        if (string.IsNullOrEmpty(pattern))
        {
            throw new ArgumentException("Pattern cannot be null or empty.");
        }
        this.pattern = pattern;
    }

    public int Search(string text)
    {
        return FindLCSLength(text);
    }

    public int SearchAllRows(List<string> text)
    {
        int maxLCSLength = 0;
        foreach (string row in text)
        {
            int lcsLength = Search(row);
            if (lcsLength > maxLCSLength)
            {
                maxLCSLength = lcsLength;
            }
        }
        return maxLCSLength;
    }

    public Tuple<Biodata?, SidikJari?> SearchBestMatch(SQLiteDataAccess sqlData, List<SidikJari> allSidik)
    {
        Stopwatch stopwatch = new Stopwatch();
        int currMaxLength = 0;
        int currLength;
        Biodata? maxBiodata = null;
        SidikJari? maxSidikJari = null;
        string baseDir = "../../";
        stopwatch.Start();

        foreach (SidikJari sidik in allSidik)
        {
            string final = baseDir + sidik.Berkas_citra;
            List<string> text = BMPToBytes.ConvertBMPtoASCII(final);
            currLength = this.SearchAllRows(text);
            if (currLength > currMaxLength)
            {
                // check if Biodata is available
                Biodata? bioMatch = sqlData.searchForBiodata(sidik);
                if (bioMatch == null)
                {
                    // find other possibilities
                    continue;
                }
                else
                {
                    currMaxLength = currLength;
                    maxBiodata = bioMatch;
                    maxSidikJari = sidik;
                }
            }
        }
        stopwatch.Stop();
        if (maxBiodata != null)
        {
            long timeTaken = stopwatch.ElapsedMilliseconds;
            maxBiodata.Algoritma = "LCS";
            maxBiodata.Presentase = ((double)currMaxLength / this.pattern.Length) * 100;
            maxBiodata.TimeTaken = timeTaken;
        }

        return Tuple.Create<Biodata?, SidikJari?>(maxBiodata, maxSidikJari);
    }

    // Reference : https://www.youtube.com/watch?v=NnD96abizww
    // LCS with dynamic programming
    private int FindLCSLength(string text)
    {
        int m = this.pattern.Length;
        int k = text.Length;
        int[,] L = new int[m + 1, k + 1];

        // LCS table
        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= k; j++)
            {
                if (i == 0 || j == 0)
                {
                    L[i, j] = 0;
                }
                else if (this.pattern[i - 1] == text[j - 1])
                {
                    L[i, j] = L[i - 1, j - 1] + 1;
                }
                else
                {
                    L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
        }

        return L[m, k];
    }
}

