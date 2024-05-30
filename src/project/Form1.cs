using System.Xml.Serialization;
using WinFormsApp3.backend;
using System.Diagnostics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        const string BASEDIR = "../../";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                // Now you have the path to the selected image
                Console.WriteLine(imagePath);
                inputPicture.Image = Image.FromFile(imagePath);
                inputPicture.ImageLocation = imagePath;
            }
        }

        private void updateLabelBasedOnSearch(Biodata? bio, SidikJari? sidikJari, string algoritma, long timeTaken){
            if (bio  != null){
                
            }

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // logic searching
            Stopwatch stopwatch = new Stopwatch();
            
            string filename = inputPicture.ImageLocation;
            ResetTextLabel();
            if (algorithmDropdown != null)
            {
                if (algorithmDropdown.SelectedIndex == 0 || algorithmDropdown.SelectedIndex == 1){
                    AlgoMaster algo = new AlgoMaster();
                    labelHeaderBiodata.Text = filename;
                    Tuple<Biodata?,SidikJari?> hasil = algo.Search(filename, algorithmDropdown.SelectedIndex);
                    if (hasil.Item1 == null || hasil.Item2 == null)
                    {
                        labelHeaderBiodata.Text = "Tidak ketemu";
                    }
                    else
                    {
                        labelHeaderBiodata.Text = hasil.Item2.Nama;
                        labelPekerjaan.Text = "ANJING KETEMU";
                        outPicture.ImageLocation = BASEDIR + hasil.Item2.Berkas_citra;

                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
