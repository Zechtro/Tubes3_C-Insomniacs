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

        }
        private void InitializeComponent()
        {
            inputPicture = new PictureBox();
            outPicture = new PictureBox();
            uploadButton = new Button();
            buttonSearch = new Button();
            algorithmDropdown = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)inputPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outPicture).BeginInit();
            SuspendLayout();
            // 
            // inputPicture
            // 
            inputPicture.Location = new Point(49, 34);
            inputPicture.Name = "inputPicture";
            inputPicture.Size = new Size(163, 233);
            inputPicture.TabIndex = 0;
            inputPicture.TabStop = false;
            // 
            // outPicture
            // 
            outPicture.Location = new Point(304, 34);
            outPicture.Name = "outPicture";
            outPicture.Size = new Size(163, 233);
            outPicture.TabIndex = 1;
            outPicture.TabStop = false;
            outPicture.Click += pictureBox2_Click;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(61, 311);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(139, 29);
            uploadButton.TabIndex = 2;
            uploadButton.Text = "Upload Image";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += button1_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(340, 354);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "SEARCH!";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // algorithmDropdown
            // 
            algorithmDropdown.FormattingEnabled = true;
            algorithmDropdown.Location = new Point(304, 311);
            algorithmDropdown.Name = "algorithmDropdown";
            algorithmDropdown.Size = new Size(163, 28);
            algorithmDropdown.TabIndex = 4;
            algorithmDropdown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            algorithmDropdown.Items.Add("KMP");
            algorithmDropdown.Items.Add("BM");

            // 
            // label
            // 
            labelAlgoritma.AutoSize = true;
            labelAlgoritma.Location = new Point(507, 289);
            labelAlgoritma.Name = "labelAlgoritma";
            labelAlgoritma.Size = new Size(165, 20);
            labelAlgoritma.TabIndex = 5;
            labelAlgoritma.Text = "Algoritma: ";
            labelAlgoritma.Click += label1_Click;
            // 
            // labelWaktuPencarian
            // 
            labelWaktuPencarian.AutoSize = true;
            labelWaktuPencarian.Location = new Point(507, 332);
            labelWaktuPencarian.Name = "labelWaktuPencarian";
            labelWaktuPencarian.Size = new Size(165, 20);
            labelWaktuPencarian.TabIndex = 5;
            labelWaktuPencarian.Text = "Waktu Pencarian : xx ms";
            labelWaktuPencarian.Click += label1_Click;
            // 
            // labelPersentaseKecocokan
            // 
            labelPersentaseKecocokan.AutoSize = true;
            labelPersentaseKecocokan.Location = new Point(507, 375);
            labelPersentaseKecocokan.Name = "labelPersentaseKecocokan";
            labelPersentaseKecocokan.Size = new Size(191, 20);
            labelPersentaseKecocokan.TabIndex = 6;
            labelPersentaseKecocokan.Text = "Persentase Kecocokan : xx%";
            labelPersentaseKecocokan.Click += label2_Click;
            // 
            // labelHeaderBiodata
            // 
            labelHeaderBiodata.AutoSize = true;
            labelHeaderBiodata.Location = new Point(610, 34);
            labelHeaderBiodata.Name = "labelHeaderBiodata";
            labelHeaderBiodata.Size = new Size(61, 20);
            labelHeaderBiodata.TabIndex = 7;
            labelHeaderBiodata.Text = "Biodata";
            // 
            // labelNIK
            // 
            labelNIK.AutoSize = true;
            labelNIK.Location = new Point(507, 58);
            labelNIK.Name = "labelNIK";
            labelNIK.Size = new Size(44, 20);
            labelNIK.TabIndex = 8;
            labelNIK.Text = "NIK : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 78);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Nama : ";
            // 
            // labelTempatLahir
            // 
            labelTempatLahir.AutoSize = true;
            labelTempatLahir.Location = new Point(507, 98);
            labelTempatLahir.Name = "labelTempatLahir";
            labelTempatLahir.Size = new Size(106, 20);
            labelTempatLahir.TabIndex = 10;
            labelTempatLahir.Text = "Tempat Lahir : ";
            // 
            // labelJenisKelamin
            // 
            labelJenisKelamin.AutoSize = true;
            labelJenisKelamin.Location = new Point(507, 118);
            labelJenisKelamin.Name = "labelJenisKelamin";
            labelJenisKelamin.Size = new Size(109, 20);
            labelJenisKelamin.TabIndex = 11;
            labelJenisKelamin.Text = "Jenis Kelamin : ";
            // 
            // labelGolonganDarah
            // 
            labelGolonganDarah.AutoSize = true;
            labelGolonganDarah.Location = new Point(507, 138);
            labelGolonganDarah.Name = "labelGolonganDarah";
            labelGolonganDarah.Size = new Size(129, 20);
            labelGolonganDarah.TabIndex = 12;
            labelGolonganDarah.Text = "Golongan Darah : ";
            labelGolonganDarah.Click += label8_Click;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(507, 158);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(68, 20);
            labelAlamat.TabIndex = 13;
            labelAlamat.Text = "Alamat : ";
            // 
            // labelAgama
            // 
            labelAgama.AutoSize = true;
            labelAgama.Location = new Point(507, 178);
            labelAgama.Name = "labelAgama";
            labelAgama.Size = new Size(68, 20);
            labelAgama.TabIndex = 14;
            labelAgama.Text = "Agama : ";
            // 
            // labelStatusPerkawinan
            // 
            labelStatusPerkawinan.AutoSize = true;
            labelStatusPerkawinan.Location = new Point(507, 198);
            labelStatusPerkawinan.Name = "labelStatusPerkawinan";
            labelStatusPerkawinan.Size = new Size(134, 20);
            labelStatusPerkawinan.TabIndex = 15;
            labelStatusPerkawinan.Text = "Status Perkawinan :";
            // 
            // labelPekerjaan
            // 
            labelPekerjaan.AutoSize = true;
            labelPekerjaan.Location = new Point(507, 218);
            labelPekerjaan.Name = "labelPekerjaan";
            labelPekerjaan.Size = new Size(83, 20);
            labelPekerjaan.TabIndex = 16;
            labelPekerjaan.Text = "Pekerjaan : ";
            // 
            // labelKewarganegaraan
            // 
            labelKewarganegaraan.AutoSize = true;
            labelKewarganegaraan.Location = new Point(507, 238);
            labelKewarganegaraan.Name = "labelKewarganegaraan";
            labelKewarganegaraan.Size = new Size(140, 20);
            labelKewarganegaraan.TabIndex = 17;
            labelKewarganegaraan.Text = "Kewarganegaraan : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelKewarganegaraan);
            Controls.Add(labelPekerjaan);
            Controls.Add(labelStatusPerkawinan);
            Controls.Add(labelAgama);
            Controls.Add(labelAlamat);
            Controls.Add(labelGolonganDarah);
            Controls.Add(labelJenisKelamin);
            Controls.Add(labelTempatLahir);
            Controls.Add(label5);
            Controls.Add(labelNIK);
            Controls.Add(labelHeaderBiodata);
            Controls.Add(labelAlgoritma);
            Controls.Add(labelPersentaseKecocokan);
            Controls.Add(labelWaktuPencarian);
            Controls.Add(algorithmDropdown);
            Controls.Add(buttonSearch);
            Controls.Add(uploadButton);
            Controls.Add(outPicture);
            Controls.Add(inputPicture);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)inputPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)outPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
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
        private PictureBox inputPicture;
        private PictureBox outPicture;
        private Button uploadButton;
        private ComboBox algorithmDropdown;
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
        private Button buttonSearch;
    }
}
