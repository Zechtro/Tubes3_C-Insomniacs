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
        Boolean searching = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private async void buttonSearch_Click_1(object sender, EventArgs e)
        {
            if (!searching && inputPicture.ImageLocation != null)
            {
                searching = true;
                searchPanel.Visible = true;
                string filename = inputPicture.ImageLocation;
                ResetTextLabel();

                var searchTask = Task.Run(() =>
                {
                    AlgoMaster algo = new AlgoMaster();
                    if (toggle)
                    {
                        return algo.Search(filename, 0);
                    }
                    else
                    {
                        return algo.Search(filename, 1);
                    }
                });

                try
                {
                    var hasil = await searchTask;

                    if (hasil.Item1 == null || hasil.Item2 == null)
                    {
                        labelHeaderBiodata.Text = "Tidak ketemu";
                    }
                    else
                    {
                        updateLabelBasedOnSearch(hasil.Item1, hasil.Item2);
                    }
                }
                catch (Exception ex)
                {
                    labelHeaderBiodata.Text = "Error: " + ex.Message;
                }

                searchPanel.Visible = false;
                searching = false;
            }
        }

        private void roundedButton2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Console.WriteLine(imagePath);
                inputPicture.Image = Image.FromFile(imagePath);
                inputPicture.ImageLocation = imagePath;
            }
        }
    }
}
