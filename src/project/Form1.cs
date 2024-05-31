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

        private void updateLabelBasedOnSearch(Biodata? bio, SidikJari? sidikJari)
        {




            if (bio != null)
            {
                labelWaktuPencarian.Text = $"Waktu Pencarian : {bio.TimeTaken} ms";
                labelNIK.Text = $"NIK : {Decrypt.decrypt(bio.NIK)}";
                labelPersentaseKecocokan.Text = $"Persentase Kecocokan : {bio.Presentase}%";
                labelTempatLahir.Text = $"Tempat Lahir: {Decrypt.decrypt(bio.Tempat_lahir)}";
                labelJenisKelamin.Text = $"Jenis Kelamin : {Decrypt.decrypt(bio.Jenis_kelamin)}";
                labelGolonganDarah.Text = $"Golongan Darah : {Decrypt.decrypt(bio.Golongan_darah)}";
                labelAlamat.Text = $"Alamat : {Decrypt.decrypt(bio.Alamat)}";
                labelAgama.Text = $"Agama : {Decrypt.decrypt(bio.Agama)}";
                labelStatusPerkawinan.Text = $"Status Perkawinan : {Decrypt.decrypt(bio.Status_perkawinan)}";
                labelPekerjaan.Text = $"Pekerjaan : {Decrypt.decrypt(bio.Pekerjaan)}";
                labelKewarganegaraan.Text = $"Kewarganegaraan : {Decrypt.decrypt(bio.Kewarganegaraan)}";
                labelAlgoritma.Text = $"Algoritma: {bio.Algoritma}";


            }

            if (sidikJari != null)
            {
                label5.Text = $"Nama : {sidikJari.Nama}";
                outPicture.ImageLocation = BASEDIR + sidikJari.Berkas_citra;
            }



        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // logic searching
            try
            {
                Stopwatch stopwatch = new Stopwatch();

                string filename = inputPicture.ImageLocation;
                ResetTextLabel();
                if (algorithmDropdown != null)
                {
                    if (algorithmDropdown.SelectedIndex == 0 || algorithmDropdown.SelectedIndex == 1)
                    {
                        AlgoMaster algo = new AlgoMaster();
                        stopwatch.Start();
                        Tuple<Biodata?, SidikJari?> hasil = algo.Search(filename, algorithmDropdown.SelectedIndex);
                        stopwatch.Stop();
                        long timeTaken = stopwatch.ElapsedMilliseconds;

                        if (hasil.Item1 == null || hasil.Item2 == null)
                        {
                            labelHeaderBiodata.Text = "Tidak ketemu";
                        }
                        else
                        {
                            // labelHeaderBiodata.Text = hasil.Item2.Nama;
                            // labelPekerjaan.Text = "ANJING KETEMU";
                            // outPicture.ImageLocation = BASEDIR + hasil.Item2.Berkas_citra;
                            updateLabelBasedOnSearch(hasil.Item1, hasil.Item2);

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
