using System.Xml.Serialization;
using WinFormsApp3.backend;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // logic searching
            string filename = inputPicture.ImageLocation;

            if (algorithmDropdown != null)
            {
                if (algorithmDropdown.SelectedIndex == 0)
                {
                    // KMP algorithm here
                }
                else if (algorithmDropdown.SelectedIndex == 1)
                {

                    AlgoMaster algo = new AlgoMaster();
                    labelHeaderBiodata.Text = filename;
                    SidikJari temp = algo.search(filename, 0);
                    if (temp.berkas_citra == ""){
                        labelHeaderBiodata.Text = temp.nama;
                    } else {
                        labelHeaderBiodata.Text = "KETEMU";
                    }
                    // outPicture.Image = Image.FromFile("../../test/100__M_Left_index_finger.bmp");

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
