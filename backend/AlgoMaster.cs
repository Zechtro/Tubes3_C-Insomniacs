using System.Diagnostics;
namespace WinFormsApp3.backend
{
    public class AlgoMaster
    {

        private string sourcePath;
        private string targetPath;
        private string pattern;
        private IBaseAlgorithm? algorithm;



        public AlgoMaster()
        {
            this.sourcePath = "";
            this.targetPath = "";
            this.pattern = "";

        }

        public Tuple<Biodata?, SidikJari?> Search(string filename, int algorithmType)
        {
            Stopwatch stopwatch = new Stopwatch();

            this.sourcePath = filename;
            // getting pattern from file    
            // get necessary data

            // "..\\..\\test\\100__M_Left_index_finger.bmp"
            //../../test/100__M_Left_index_finger.bmp
            // string transformedPath = $"../../{originalPath}"
            this.pattern = BMPToBytes.GetImagePattern(filename);
            SQLiteDataAccess sqlData = new SQLiteDataAccess();
            List<SidikJari> allSidikJari = sqlData.GetSidikJari();

            // determine algorithm
            if (algorithmType == 0)
            {
                this.algorithm = new KMPAlgorithm(this.pattern);
            }
            else
            {
                this.algorithm = new BoyerMoore(this.pattern);
            }
            stopwatch.Start();
            int index;
            string baseDir = "../../";
            foreach (SidikJari sidik in allSidikJari)
            {

                // // string what  = "../../../test/100__M_Left_index_finger"
                // string baseDir = @"D:/SMS 4/Strategi ALgoritma/Tubes3Insomniacs/";
                string final = baseDir + sidik.Berkas_citra;
                List<string> text = BMPToBytes.ConvertBMPToASCII(final); // ascii, row of strings
                index = this.algorithm.SearchAllRows(text);
                if (index != -1)
                {
                    // return sidik;
                    // searching for biodata !!!
                    Biodata? bioMatch = sqlData.searchForBiodata(sidik);
                    if (bioMatch == null)
                    {
                        // find other possibilities
                        continue;
                    }
                    else
                    {
                        stopwatch.Stop();
                        long timeTaken = stopwatch.ElapsedMilliseconds;
                        bioMatch.Algoritma = algorithmType == 0 ? "KMP" : "BM";
                        bioMatch.Presentase = 100;
                        bioMatch.TimeTaken = timeTaken;
                        return Tuple.Create<Biodata?, SidikJari?>(bioMatch, sidik);
                    }
                }
            }
            stopwatch.Stop();
            LongestCommonSubsequence lcs = new LongestCommonSubsequence(this.pattern);

            // use LCS

            return lcs.SearchBestMatch(sqlData,allSidikJari);

        }
    }
}
