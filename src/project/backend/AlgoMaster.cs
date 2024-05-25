
namespace WinFormsApp3.backend
{
    public class AlgoMaster
    {

        private string sourcePath;
        private string targetPath;
        private string pattern;
        private IBaseAlgorithm algorithm;



        public AlgoMaster()
        {
            this.sourcePath = "";
            this.targetPath = "";
            this.pattern = "";

        }

        public SidikJari search(string filename, int algorithmType)
        {
            this.sourcePath = filename;
            SidikJari notFound =  new SidikJari();
            notFound.berkas_citra = "";
            notFound.nama = "";

            try
            {
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
                int index = -1;
                SidikJari temp = new SidikJari();

                foreach (SidikJari sidik in allSidikJari)
                {
                    // string what  = "../../../test/100__M_Left_index_finger"
                    string baseDir = @"D:/SMS 4/Strategi ALgoritma/Tubes3Insomniacs/";
                    string final = baseDir + sidik.berkas_citra;
                    List<string> text = BMPToBytes.ConvertBMPToASCII(final); // ascii, row of strings
                    index = this.algorithm.searchAllRows(text);
                    if (index != -1)
                    {
                        return sidik;
                        break;
                    }
                }

                return notFound;

                // instantiate algorithm type
                // if (string.compare)


            }
            catch (Exception ex)
            {
                notFound.nama = ex.Message;
                return notFound;
            }


            return notFound;

        }


        // public Pair<Biodata, SidikJari> searchAllImages(string filename, string algorithmType){
        //     // KMP
        //     // BM

        //     if (algorithmType.Equals())
        // }
    }
}
