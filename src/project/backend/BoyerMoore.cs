public class BoyerMoore : IBaseAlgorithm
{
    private readonly int alphabetSize; // default 256
    private readonly int[] badCharacterShift;
    private readonly int[] goodSuffixShift;
    private readonly int[] borderPositions;
    private readonly char[] pattern;

    public BoyerMoore(string pattern)
    {
        if (string.IsNullOrEmpty(pattern))
        {
            throw new ArgumentException("Pattern cannot be null or empty.");
        }

        this.pattern = pattern.ToCharArray();
        alphabetSize = 256;
        badCharacterShift = new int[alphabetSize];
        borderPositions = new int[this.pattern.Length + 1];
        goodSuffixShift = new int[this.pattern.Length + 1];

        PreprocessBadCharacterHeuristic();
        PreprocessGoodSuffixHeuristic();
        PreprocessBorderPositions();
    }

    public int Search(string text)
    {
        if (string.IsNullOrEmpty(text) || text.Length < this.pattern.Length)
        {
            return -1;
        }

        char[] textArray = text.ToCharArray();
        int textIndex = 0;

        while (textIndex <= textArray.Length - this.pattern.Length)
        {

            // Scan from right to left
            int patternIndex = this.pattern.Length - 1;

            // keep mmoving left if still matches
            while (patternIndex >= 0 && this.pattern[patternIndex] == textArray[textIndex + patternIndex])
            {
                patternIndex--;
            }

            // found a match
            if (patternIndex < 0)
            {
                return textIndex;
            }
            // make a jump/shift
            else
            {
                // determining which shift to use
                int badCharacterShiftAmount = patternIndex - this.badCharacterShift[textArray[textIndex + patternIndex]];
                int goodSuffixShiftAmount = this.goodSuffixShift[patternIndex + 1];
                textIndex += Math.Max(goodSuffixShiftAmount, badCharacterShiftAmount);
            }
        }

        return -1;
    }

    private void PreprocessBadCharacterHeuristic()
    {
        // fill array with -1
        Array.Fill(this.badCharacterShift, -1);

        // fill array badCharacterShift 
        // fill it based on the last occurrence of a character in the pattern 
        for (int i = 0; i < pattern.Length; i++)
        {
            this.badCharacterShift[pattern[i]] = i;
        }
    }

    private void PreprocessGoodSuffixHeuristic()
    {
        int m = pattern.Length;
        int i = m;
        int j = m + 1;

        // for borderPosition[k], it stores the location of the suffix in the substring pattern[k, pattern.length - 1 ] where that suffix is also the prefix
        borderPositions[i] = j; // consider that pattern[pattern]

        //note : pattern[m] acts as the "∅", which means borderPosition[k] = m  means that there are no suffix in pattern[k,pattern.Length - 1] which is also a prefix for substring pattern[k, pattern.Length -1]

        while (i > 0)
        {
            while (j <= m && pattern[i - 1] != pattern[j - 1])
            {

                if (goodSuffixShift[j] == 0)
                {
                    // stores shift
                    goodSuffixShift[j] = j - i;
                }

                // find the next longest prefix which is also a suffix of pattern[i,pattern.Length - 1]
                j = borderPositions[j];
            }
            i--;
            j--;
            borderPositions[i] = j;
        }
    }
    private void PreprocessBorderPositions()
    {
        int m = pattern.Length;
        int i, j = borderPositions[0];

        // fill uninitialized slots in goodSuffixShift
        for (i = 0; i <= m; i++)
        {
            if (goodSuffixShift[i] == 0)
            {
                goodSuffixShift[i] = j;
            }

            if (i == j)
            {
                j = borderPositions[j];
            }
        }
    }
    public int SearchAllRows(List<string> text)
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



