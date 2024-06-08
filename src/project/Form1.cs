using System.Xml.Serialization;
using WinFormsApp3.backend;
using System.Diagnostics;
using CustomControls.ToggleButton;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        const string BASEDIR = "../../";
        Boolean toggle = false;
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

        private void updateLabelBasedOnSearch(Biodata? bio, SidikJari? sidikJari)
        {

            if (bio != null)
            {
                if (bio.Presentase != null){
                    if (double.Parse(bio.Presentase.ToString()) < 55 ){
                        throw new Exception("Fingerprint not found !");
                    }
                }


                labelWaktuPencarian.Text = $"Waktu Pencarian : {bio.TimeTaken} ms";
                labelNIK.Text = $"NIK : {Decrypt.decrypt(bio.NIK)}";
                labelPersentaseKecocokan.Text = $"Persentase Kecocokan : {Math.Round(double.Parse(bio.Presentase.ToString()),2)}%";
                labelTempatLahir.Text = $"Tempat Lahir: {Decrypt.decrypt(bio.Tempat_lahir)}";
                labelJenisKelamin.Text = $"Jenis Kelamin : {Decrypt.decrypt(bio.Jenis_kelamin)}";
                labelGolonganDarah.Text = $"Golongan Darah : {Decrypt.decrypt(bio.Golongan_darah)}";
                string strAlamat = Decrypt.decrypt(bio.Alamat);
                string firstPart = "";
                string secondPart = "";
                string thirdPart = "";

                if (strAlamat.Length > 19)
                {
                    int lastSpaceIndex = strAlamat.Substring(0, 19).LastIndexOf(' ');

                    if (lastSpaceIndex == -1)
                    {
                        lastSpaceIndex = 19;
                    }

                    firstPart = strAlamat.Substring(0, lastSpaceIndex);
                    secondPart = strAlamat.Substring(lastSpaceIndex + 1);

                    if (secondPart.Length > 19)
                    {
                        int secondSpaceIndex = secondPart.Substring(0, 19).LastIndexOf(' ');
                        if (secondSpaceIndex == -1)
                        {
                            secondSpaceIndex = 19;
                        }
                        thirdPart = secondPart.Substring(secondSpaceIndex + 1);
                        secondPart = secondPart.Substring(0, secondSpaceIndex);
                    }

                    labelAlamat.Text = $"Alamat : {firstPart}";
                    alamatTambahan.Text = secondPart;
                    alamatTambahan2.Text = thirdPart;
                }
                else
                {
                    labelAlamat.Text = $"Alamat : {strAlamat}";
                    alamatTambahan.Text = "";
                    alamatTambahan2.Text = "";
                }
                labelAgama.Text = $"Agama : {Decrypt.decrypt(bio.Agama)}";
                labelStatusPerkawinan.Text = $"Status Perkawinan : {Decrypt.decrypt(bio.Status_perkawinan)}";
                labelPekerjaan.Text = $"Pekerjaan : {Decrypt.decrypt(bio.Pekerjaan)}";
                labelKewarganegaraan.Text = $"Kewarganegaraan : {Decrypt.decrypt(bio.Kewarganegaraan)}";
                labelAlgoritma.Text = $"Algoritma: {bio.Algoritma}";


            }

            if (sidikJari != null)
            {
                label5.Text = $"Nama : {sidikJari.Nama}";
                outPicture.Image = Image.FromFile(BASEDIR + sidikJari.Berkas_citra);
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

        private void inputPicture_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void toggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputPicture_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void labelNIK_Click(object sender, EventArgs e)
        {

        }

        private void labelPekerjaan_Click(object sender, EventArgs e)
        {

        }

        private void methodToggle_CheckedChanged_1(object sender, EventArgs e)
        {
            if (methodToggle.Checked)
            {
                toggle = true;
            }
            else
            {
                toggle = false;
            }
        }

        private void outPicture_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            // logic searching

            string filename = inputPicture.ImageLocation;
            ResetTextLabel();
            if (toggle)
            {
                AlgoMaster algo = new AlgoMaster();
                Tuple<Biodata?, SidikJari?> hasil = algo.Search(filename, 0);
                if (hasil.Item1 == null || hasil.Item2 == null)
                {
                    labelHeaderBiodata.Text = "Tidak ketemu";
                }
                else
                {
                    updateLabelBasedOnSearch(hasil.Item1, hasil.Item2);
                }
            }
            else
            {
                AlgoMaster algo = new AlgoMaster();
                Tuple<Biodata?, SidikJari?> hasil = algo.Search(filename, 1);

                if (hasil.Item1 == null || hasil.Item2 == null)
                {
                    labelHeaderBiodata.Text = "Tidak ketemu";
                }
                else
                {
                    updateLabelBasedOnSearch(hasil.Item1, hasil.Item2);

                }
            }

        }

        private void roundedButton2_Click_1(object sender, EventArgs e)
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

        private void roundBorderPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
