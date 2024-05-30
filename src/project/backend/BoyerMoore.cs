public class BoyerMoore : IBaseAlgorithm
{
    private readonly int alphabetSize;
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
            int patternIndex = this.pattern.Length - 1;

            while (patternIndex >= 0 && this.pattern[patternIndex] == textArray[textIndex + patternIndex])
            {
                patternIndex--;
            }

            if (patternIndex < 0)
            {
                return textIndex;
            }
            else
            {
                int badCharacterShiftAmount = patternIndex - this.badCharacterShift[textArray[textIndex + patternIndex]];
                int goodSuffixShiftAmount = this.goodSuffixShift[patternIndex + 1];
                textIndex += Math.Max(goodSuffixShiftAmount, badCharacterShiftAmount);
            }
        }

        return -1;
    }

    private void PreprocessBadCharacterHeuristic()
    {
        Array.Fill(this.badCharacterShift, -1);
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

        borderPositions[i] = j;
        while (i > 0)
        {
            while (j <= m && pattern[i - 1] != pattern[j - 1])
            {
                if (goodSuffixShift[j] == 0)
                {
                    goodSuffixShift[j] = j - i;
                }
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



