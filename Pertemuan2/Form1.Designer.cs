namespace Pertemuan2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPr = new System.Windows.Forms.RadioButton();
            this.cbPS = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.btTampil = new System.Windows.Forms.Button();
            this.btKeluar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmptLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programStudi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM BIODATA MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "NPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Program Studi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Minat dan Bakat";
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(186, 74);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(116, 20);
            this.txtNPM.TabIndex = 2;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(186, 48);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(230, 20);
            this.txtNama.TabIndex = 2;
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Checked = true;
            this.rbLaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLaki.Location = new System.Drawing.Point(186, 100);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(80, 22);
            this.rbLaki.TabIndex = 3;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPr
            // 
            this.rbPr.AutoSize = true;
            this.rbPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPr.Location = new System.Drawing.Point(306, 100);
            this.rbPr.Name = "rbPr";
            this.rbPr.Size = new System.Drawing.Size(102, 22);
            this.rbPr.TabIndex = 3;
            this.rbPr.TabStop = true;
            this.rbPr.Text = "Perempuan";
            this.rbPr.UseVisualStyleBackColor = true;
            // 
            // cbPS
            // 
            this.cbPS.AutoCompleteCustomSource.AddRange(new string[] {
            "S1 Informatika",
            "S1 Sistem Informasi",
            "S1 Teknologi Informasi",
            "S1 Teknik Komputer"});
            this.cbPS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPS.FormattingEnabled = true;
            this.cbPS.Items.AddRange(new object[] {
            "S1 Informatika",
            "S1 Sistem Informasi",
            "S1 Teknologi Informasi",
            "S1 Teknik Komputer"});
            this.cbPS.Location = new System.Drawing.Point(186, 128);
            this.cbPS.Name = "cbPS";
            this.cbPS.Size = new System.Drawing.Size(175, 21);
            this.cbPS.TabIndex = 4;
            this.cbPS.Text = "-- Pilih Program Studi --";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(26, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 22);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Pemrograman";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(26, 218);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(99, 22);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Basis Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(26, 246);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 22);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "HardSoft";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(239, 190);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(152, 22);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Jaringan Komputer";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(239, 218);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(117, 22);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Desain Grafis";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(239, 246);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 22);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Lain-lain";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // btTampil
            // 
            this.btTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTampil.Location = new System.Drawing.Point(180, 346);
            this.btTampil.Name = "btTampil";
            this.btTampil.Size = new System.Drawing.Size(85, 33);
            this.btTampil.TabIndex = 6;
            this.btTampil.Text = "Tampil";
            this.btTampil.UseVisualStyleBackColor = true;
            this.btTampil.Click += new System.EventHandler(this.btTampil_Click);
            // 
            // btKeluar
            // 
            this.btKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKeluar.Location = new System.Drawing.Point(362, 346);
            this.btKeluar.Name = "btKeluar";
            this.btKeluar.Size = new System.Drawing.Size(85, 33);
            this.btKeluar.TabIndex = 6;
            this.btKeluar.Text = "Keluar";
            this.btKeluar.UseVisualStyleBackColor = true;
            this.btKeluar.Click += new System.EventHandler(this.btKeluar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tempat Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tanggal Lahir";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(186, 278);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(116, 20);
            this.txtTempatLahir.TabIndex = 2;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(186, 304);
            this.dtpTanggalLahir.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpTanggalLahir.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(116, 20);
            this.dtpTanggalLahir.TabIndex = 7;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.npm,
            this.nama,
            this.jenisKelamin,
            this.tmptLahir,
            this.tglLahir,
            this.programStudi});
            this.dgvMahasiswa.Location = new System.Drawing.Point(470, 44);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.Size = new System.Drawing.Size(427, 280);
            this.dgvMahasiswa.TabIndex = 8;
            // 
            // no
            // 
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // npm
            // 
            this.npm.HeaderText = "NPM";
            this.npm.Name = "npm";
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            // 
            // jenisKelamin
            // 
            this.jenisKelamin.HeaderText = "Jenis Kelamin";
            this.jenisKelamin.Name = "jenisKelamin";
            // 
            // tmptLahir
            // 
            this.tmptLahir.HeaderText = "Tempat lahir";
            this.tmptLahir.Name = "tmptLahir";
            // 
            // tglLahir
            // 
            this.tglLahir.HeaderText = "Tanggal Lahir";
            this.tglLahir.Name = "tglLahir";
            // 
            // programStudi
            // 
            this.programStudi.HeaderText = "Program Studi";
            this.programStudi.Name = "programStudi";
            // 
            // btSimpan
            // 
            this.btSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSimpan.Location = new System.Drawing.Point(271, 346);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(85, 33);
            this.btSimpan.TabIndex = 9;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(925, 391);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.btKeluar);
            this.Controls.Add(this.btTampil);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbPS);
            this.Controls.Add(this.rbPr);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "FORM MHS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.RadioButton rbPr;
        private System.Windows.Forms.ComboBox cbPS;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button btTampil;
        private System.Windows.Forms.Button btKeluar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn npm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmptLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn programStudi;
    }
}

