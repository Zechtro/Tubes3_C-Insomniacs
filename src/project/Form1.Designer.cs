namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        public void ResetTextLabel()
        {
            // uploadButton.Text = "Upload Image";
            labelHeaderBiodata.Text = "Biodata";
            labelWaktuPencarian.Text = "Waktu Pencarian : xx ms";
            labelPersentaseKecocokan.Text = "Persentase Kecocokan : xx%";
            labelNIK.Text = "NIK : ";
            label5.Text = "Nama : ";
            labelTempatLahir.Text = "Tempat Lahir : ";
            labelJenisKelamin.Text = "Jenis Kelamin : ";
            labelGolonganDarah.Text = "Golongan Darah : ";
            labelAlgoritma.Text = "Algoritma: ";
            labelAlamat.Text = "Alamat : ";
            labelAgama.Text = "Agama : ";
            labelStatusPerkawinan.Text = "Status Perkawinan :";
            labelPekerjaan.Text = "Pekerjaan : ";
            labelKewarganegaraan.Text = "Kewarganegaraan : ";
            outPicture.ImageLocation = null;
            alamatTambahan.Text = "";

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelAlgoritma = new Label();
            labelWaktuPencarian = new Label();
            labelPersentaseKecocokan = new Label();
            labelHeaderBiodata = new Label();
            labelNIK = new Label();
            label5 = new Label();
            labelTempatLahir = new Label();
            labelJenisKelamin = new Label();
            labelGolonganDarah = new Label();
            labelAlamat = new Label();
            labelAgama = new Label();
            labelStatusPerkawinan = new Label();
            labelPekerjaan = new Label();
            labelKewarganegaraan = new Label();
            roundBorderPanel1 = new SrcTree.RoundBorderPanel();
            roundedButton2 = new CustomControls.RoundedButton.RoundedButton();
            panel1 = new Panel();
            label14 = new Label();
            methodToggle = new CustomControls.ToggleButton.ToggleButton();
            label1 = new Label();
            buttonSearch = new CustomControls.RoundedButton.RoundedButton();
            inputPicture = new RoundPictureBox();
            roundBorderPanel2 = new SrcTree.RoundBorderPanel();
            alamatTambahan2 = new Label();
            alamatTambahan = new Label();
            outPicture = new RoundPictureBox();
            verticalLabel1 = new VerticalLabel();
            roundBorderPanel3 = new SrcTree.RoundBorderPanel();
            roundBorderPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputPicture).BeginInit();
            roundBorderPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)outPicture).BeginInit();
            roundBorderPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelAlgoritma
            // 
            labelAlgoritma.AutoSize = true;
            labelAlgoritma.Font = new Font("Segoe UI", 15F);
            labelAlgoritma.Location = new Point(29, 25);
            labelAlgoritma.Name = "labelAlgoritma";
            labelAlgoritma.Size = new Size(137, 35);
            labelAlgoritma.TabIndex = 5;
            labelAlgoritma.Text = "Algoritma: ";
            labelAlgoritma.Click += label1_Click;
            // 
            // labelWaktuPencarian
            // 
            labelWaktuPencarian.AutoSize = true;
            labelWaktuPencarian.Font = new Font("Segoe UI", 15F);
            labelWaktuPencarian.Location = new Point(32, 78);
            labelWaktuPencarian.Name = "labelWaktuPencarian";
            labelWaktuPencarian.Size = new Size(210, 35);
            labelWaktuPencarian.TabIndex = 5;
            labelWaktuPencarian.Text = "Waktu Pencarian :";
            labelWaktuPencarian.Click += label1_Click;
            // 
            // labelPersentaseKecocokan
            // 
            labelPersentaseKecocokan.AutoSize = true;
            labelPersentaseKecocokan.Font = new Font("Segoe UI", 15F);
            labelPersentaseKecocokan.Location = new Point(29, 128);
            labelPersentaseKecocokan.Name = "labelPersentaseKecocokan";
            labelPersentaseKecocokan.Size = new Size(273, 35);
            labelPersentaseKecocokan.TabIndex = 6;
            labelPersentaseKecocokan.Text = "Persentase Kecocokan :";
            labelPersentaseKecocokan.Click += label2_Click;
            // 
            // labelHeaderBiodata
            // 
            labelHeaderBiodata.AutoSize = true;
            labelHeaderBiodata.Location = new Point(317, 47);
            labelHeaderBiodata.Name = "labelHeaderBiodata";
            labelHeaderBiodata.Size = new Size(61, 20);
            labelHeaderBiodata.TabIndex = 7;
            labelHeaderBiodata.Text = "Biodata";
            // 
            // labelNIK
            // 
            labelNIK.AutoSize = true;
            labelNIK.BackColor = Color.Transparent;
            labelNIK.Location = new Point(269, 80);
            labelNIK.Name = "labelNIK";
            labelNIK.Size = new Size(44, 20);
            labelNIK.TabIndex = 8;
            labelNIK.Text = "NIK : ";
            labelNIK.Click += labelNIK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Location = new Point(269, 100);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Nama : ";
            // 
            // labelTempatLahir
            // 
            labelTempatLahir.AutoSize = true;
            labelTempatLahir.BackColor = Color.Transparent;
            labelTempatLahir.FlatStyle = FlatStyle.Flat;
            labelTempatLahir.Location = new Point(269, 120);
            labelTempatLahir.Name = "labelTempatLahir";
            labelTempatLahir.Size = new Size(106, 20);
            labelTempatLahir.TabIndex = 10;
            labelTempatLahir.Text = "Tempat Lahir : ";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.BackColor = Color.Transparent;
            labelJenisKelamin.FlatStyle = FlatStyle.Flat;
            labelJenisKelamin.Location = new Point(269, 140);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(109, 20);
            labelJenisKelamin.TabIndex = 11;
            labelJenisKelamin.Text = "Jenis Kelamin : ";
            // 
            // labelGolonganDarah
            // 
            labelGolonganDarah.AutoSize = true;
            labelGolonganDarah.BackColor = Color.Transparent;
            labelGolonganDarah.Location = new Point(269, 160);
            labelGolonganDarah.Name = "labelGolonganDarah";
            labelGolonganDarah.Size = new Size(129, 20);
            labelGolonganDarah.TabIndex = 12;
            labelGolonganDarah.Text = "Golongan Darah : ";
            labelGolonganDarah.Click += label8_Click;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.BackColor = Color.Transparent;
            labelAlamat.FlatStyle = FlatStyle.Flat;
            labelAlamat.Location = new Point(269, 180);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(68, 20);
            labelAlamat.TabIndex = 13;
            labelAlamat.Text = "Alamat : ";
            // 
            // labelAgama
            // 
            labelAgama.AutoSize = true;
            labelAgama.BackColor = Color.Transparent;
            labelAgama.FlatStyle = FlatStyle.Flat;
            labelAgama.Location = new Point(269, 249);
            labelAgama.Name = "labelAgama";
            labelAgama.Size = new Size(68, 20);
            labelAgama.TabIndex = 14;
            labelAgama.Text = "Agama : ";
            // 
            // labelStatusPerkawinan
            // 
            labelStatusPerkawinan.AutoSize = true;
            labelStatusPerkawinan.BackColor = Color.Transparent;
            labelStatusPerkawinan.FlatStyle = FlatStyle.Flat;
            labelStatusPerkawinan.Location = new Point(269, 269);
            labelStatusPerkawinan.Name = "labelStatusPerkawinan";
            labelStatusPerkawinan.Size = new Size(134, 20);
            labelStatusPerkawinan.TabIndex = 15;
            labelStatusPerkawinan.Text = "Status Perkawinan :";
            // 
            // labelPekerjaan
            // 
            labelPekerjaan.AutoSize = true;
            labelPekerjaan.BackColor = Color.Transparent;
            labelPekerjaan.FlatStyle = FlatStyle.Flat;
            labelPekerjaan.Location = new Point(269, 289);
            labelPekerjaan.Name = "labelPekerjaan";
            labelPekerjaan.Size = new Size(83, 20);
            labelPekerjaan.TabIndex = 16;
            labelPekerjaan.Text = "Pekerjaan : ";
            labelPekerjaan.Click += labelPekerjaan_Click;
            // 
            // labelKewarganegaraan
            // 
            labelKewarganegaraan.AutoSize = true;
            labelKewarganegaraan.BackColor = Color.Transparent;
            labelKewarganegaraan.FlatStyle = FlatStyle.Flat;
            labelKewarganegaraan.Location = new Point(269, 309);
            labelKewarganegaraan.Name = "labelKewarganegaraan";
            labelKewarganegaraan.Size = new Size(140, 20);
            labelKewarganegaraan.TabIndex = 17;
            labelKewarganegaraan.Text = "Kewarganegaraan : ";
            // 
            // roundBorderPanel1
            // 
            roundBorderPanel1.BackColor = Color.Transparent;
            roundBorderPanel1.Controls.Add(roundedButton2);
            roundBorderPanel1.Controls.Add(panel1);
            roundBorderPanel1.Controls.Add(buttonSearch);
            roundBorderPanel1.Controls.Add(inputPicture);
            roundBorderPanel1.Location = new Point(102, 49);
            roundBorderPanel1.Name = "roundBorderPanel1";
            roundBorderPanel1.Size = new Size(337, 612);
            roundBorderPanel1.TabIndex = 0;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = SystemColors.ButtonFace;
            roundedButton2.BackgroundColor = SystemColors.ButtonFace;
            roundedButton2.BorderColor = Color.Black;
            roundedButton2.BorderRadius = 30;
            roundedButton2.BorderSize = 4;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Segoe UI", 15F);
            roundedButton2.ForeColor = Color.Black;
            roundedButton2.Location = new Point(63, 326);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(211, 60);
            roundedButton2.TabIndex = 25;
            roundedButton2.Text = "Upload Image";
            roundedButton2.TextColor = Color.Black;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(methodToggle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(36, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 69);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint_2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(190, 16);
            label14.Name = "label14";
            label14.Size = new Size(53, 28);
            label14.TabIndex = 21;
            label14.Text = "KMP";
            label14.Click += label14_Click_1;
            // 
            // methodToggle
            // 
            methodToggle.BackColor = SystemColors.Control;
            methodToggle.Location = new Point(67, 13);
            methodToggle.MinimumSize = new Size(45, 22);
            methodToggle.Name = "methodToggle";
            methodToggle.OffBackColor = Color.Gray;
            methodToggle.OffToggleColor = Color.WhiteSmoke;
            methodToggle.OnBackColor = Color.Gray;
            methodToggle.OnToggleColor = Color.WhiteSmoke;
            methodToggle.Size = new Size(117, 43);
            methodToggle.TabIndex = 23;
            methodToggle.UseVisualStyleBackColor = false;
            methodToggle.CheckedChanged += methodToggle_CheckedChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 23;
            label1.Text = "BM";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.ButtonFace;
            buttonSearch.BackgroundColor = SystemColors.ButtonFace;
            buttonSearch.BorderColor = Color.Black;
            buttonSearch.BorderRadius = 30;
            buttonSearch.BorderSize = 4;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 15F);
            buttonSearch.ForeColor = Color.Black;
            buttonSearch.Location = new Point(63, 510);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(211, 60);
            buttonSearch.TabIndex = 24;
            buttonSearch.Text = "Search";
            buttonSearch.TextColor = Color.Black;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // inputPicture
            // 
            inputPicture.BackColor = Color.White;
            inputPicture.BackgroundImageLayout = ImageLayout.Center;
            inputPicture.BorderStyle = BorderStyle.FixedSingle;
            inputPicture.CornerRadius = 20;
            inputPicture.Image = (Image)resources.GetObject("inputPicture.Image");
            inputPicture.InitialImage = (Image)resources.GetObject("inputPicture.InitialImage");
            inputPicture.Location = new Point(88, 76);
            inputPicture.Name = "inputPicture";
            inputPicture.Size = new Size(166, 202);
            inputPicture.TabIndex = 19;
            inputPicture.TabStop = false;
            inputPicture.Click += inputPicture_Click_1;
            // 
            // roundBorderPanel2
            // 
            roundBorderPanel2.BackColor = Color.Transparent;
            roundBorderPanel2.Controls.Add(alamatTambahan2);
            roundBorderPanel2.Controls.Add(alamatTambahan);
            roundBorderPanel2.Controls.Add(outPicture);
            roundBorderPanel2.Controls.Add(labelNIK);
            roundBorderPanel2.Controls.Add(labelHeaderBiodata);
            roundBorderPanel2.Controls.Add(label5);
            roundBorderPanel2.Controls.Add(labelKewarganegaraan);
            roundBorderPanel2.Controls.Add(labelTempatLahir);
            roundBorderPanel2.Controls.Add(labelPekerjaan);
            roundBorderPanel2.Controls.Add(labelJenisKelamin);
            roundBorderPanel2.Controls.Add(labelStatusPerkawinan);
            roundBorderPanel2.Controls.Add(labelGolonganDarah);
            roundBorderPanel2.Controls.Add(labelAgama);
            roundBorderPanel2.Controls.Add(labelAlamat);
            roundBorderPanel2.Location = new Point(494, 49);
            roundBorderPanel2.Name = "roundBorderPanel2";
            roundBorderPanel2.Size = new Size(542, 369);
            roundBorderPanel2.TabIndex = 21;
            roundBorderPanel2.Paint += roundBorderPanel2_Paint;
            // 
            // alamatTambahan2
            // 
            alamatTambahan2.AutoSize = true;
            alamatTambahan2.Location = new Point(330, 223);
            alamatTambahan2.Name = "alamatTambahan2";
            alamatTambahan2.Size = new Size(0, 20);
            alamatTambahan2.TabIndex = 22;
            // 
            // alamatTambahan
            // 
            alamatTambahan.AutoSize = true;
            alamatTambahan.Location = new Point(330, 202);
            alamatTambahan.Name = "alamatTambahan";
            alamatTambahan.Size = new Size(0, 20);
            alamatTambahan.TabIndex = 21;
            // 
            // outPicture
            // 
            outPicture.BackColor = Color.White;
            outPicture.BackgroundImageLayout = ImageLayout.Center;
            outPicture.BorderStyle = BorderStyle.FixedSingle;
            outPicture.CornerRadius = 20;
            outPicture.Image = (Image)resources.GetObject("outPicture.Image");
            outPicture.Location = new Point(41, 47);
            outPicture.Name = "outPicture";
            outPicture.Size = new Size(199, 264);
            outPicture.TabIndex = 20;
            outPicture.TabStop = false;
            outPicture.Click += outPicture_Click;
            // 
            // verticalLabel1
            // 
            verticalLabel1.BackColor = Color.Transparent;
            verticalLabel1.Flip180 = true;
            verticalLabel1.Font = new Font("Segoe UI", 30F);
            verticalLabel1.ForeColor = Color.White;
            verticalLabel1.Location = new Point(12, 83);
            verticalLabel1.Name = "verticalLabel1";
            verticalLabel1.Size = new Size(84, 476);
            verticalLabel1.TabIndex = 22;
            verticalLabel1.Text = "C# INSOMNIACS";
            // 
            // roundBorderPanel3
            // 
            roundBorderPanel3.BackColor = Color.Transparent;
            roundBorderPanel3.Controls.Add(labelAlgoritma);
            roundBorderPanel3.Controls.Add(labelWaktuPencarian);
            roundBorderPanel3.Controls.Add(labelPersentaseKecocokan);
            roundBorderPanel3.Location = new Point(494, 460);
            roundBorderPanel3.Name = "roundBorderPanel3";
            roundBorderPanel3.Size = new Size(542, 200);
            roundBorderPanel3.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(roundBorderPanel3);
            Controls.Add(verticalLabel1);
            Controls.Add(roundBorderPanel2);
            Controls.Add(roundBorderPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            roundBorderPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputPicture).EndInit();
            roundBorderPanel2.ResumeLayout(false);
            roundBorderPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)outPicture).EndInit();
            roundBorderPanel3.ResumeLayout(false);
            roundBorderPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label labelHeaderBiodata;
        private Label labelNIK;
        private Label labelTempatLahir;
        private Label labelJenisKelamin;
        private Label labelGolonganDarah;
        private Label labelAlamat;
        private Label labelAgama;
        private Label labelStatusPerkawinan;
        private Label labelPekerjaan;
        private Label labelWaktuPencarian;
        private Label labelAlgoritma;
        private Label labelPersentaseKecocokan;
        private Label labelKewarganegaraan;
        private SrcTree.RoundBorderPanel roundBorderPanel1;
        private RoundPictureBox inputPicture;
        private SrcTree.RoundBorderPanel roundBorderPanel2;
        private CustomControls.ToggleButton.ToggleButton methodToggle;
        private RoundPictureBox outPicture;
        private VerticalLabel teamTitle;
        private VerticalLabel verticalLabel1;
        private CustomControls.RoundedButton.RoundedButton buttonSearch;
        private Label label14;
        private Panel panel1;
        private SrcTree.RoundBorderPanel roundBorderPanel3;
        private CustomControls.RoundedButton.RoundedButton roundedButton2;
        private Label alamatTambahan;
        private Label alamatTambahan2;
    }
}
