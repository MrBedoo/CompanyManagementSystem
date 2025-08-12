namespace CompanyManagementSystem.Forms
{
    partial class ToplantıPlanlama
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
            groupBox1 = new GroupBox();
            btnTemizle = new Button();
            btnKaydet = new Button();
            lstKatilimcilar = new ListBox();
            txtAdres = new TextBox();
            cmbToplantiTuru = new ComboBox();
            dtpBitis = new DateTimePicker();
            dtpBaslama = new DateTimePicker();
            txtAciklama = new TextBox();
            txtBaslik = new TextBox();
            dgvToplantilar = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToplantilar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(lstKatilimcilar);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(cmbToplantiTuru);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(dtpBaslama);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtBaslik);
            groupBox1.Location = new Point(35, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 395);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(126, 347);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(89, 36);
            btnTemizle.TabIndex = 8;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click_1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(16, 347);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(89, 36);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lstKatilimcilar
            // 
            lstKatilimcilar.FormattingEnabled = true;
            lstKatilimcilar.ItemHeight = 15;
            lstKatilimcilar.Location = new Point(16, 262);
            lstKatilimcilar.Name = "lstKatilimcilar";
            lstKatilimcilar.Size = new Size(199, 64);
            lstKatilimcilar.TabIndex = 6;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(16, 233);
            txtAdres.Name = "txtAdres";
            txtAdres.PlaceholderText = "Adres/Link";
            txtAdres.Size = new Size(199, 23);
            txtAdres.TabIndex = 5;
            // 
            // cmbToplantiTuru
            // 
            cmbToplantiTuru.FormattingEnabled = true;
            cmbToplantiTuru.Items.AddRange(new object[] { "Online", "Fiziksel" });
            cmbToplantiTuru.Location = new Point(16, 204);
            cmbToplantiTuru.Name = "cmbToplantiTuru";
            cmbToplantiTuru.Size = new Size(159, 23);
            cmbToplantiTuru.TabIndex = 4;
            cmbToplantiTuru.Text = "Toplantı Türü";
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(16, 166);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(199, 23);
            dtpBitis.TabIndex = 3;
            // 
            // dtpBaslama
            // 
            dtpBaslama.Location = new Point(16, 137);
            dtpBaslama.Name = "dtpBaslama";
            dtpBaslama.Size = new Size(199, 23);
            dtpBaslama.TabIndex = 2;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(16, 62);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.PlaceholderText = "Açıklama";
            txtAciklama.Size = new Size(199, 60);
            txtAciklama.TabIndex = 1;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(16, 33);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.PlaceholderText = "Başlık";
            txtBaslik.Size = new Size(159, 23);
            txtBaslik.TabIndex = 0;
            // 
            // dgvToplantilar
            // 
            dgvToplantilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToplantilar.Location = new Point(379, 24);
            dgvToplantilar.Name = "dgvToplantilar";
            dgvToplantilar.Size = new Size(409, 395);
            dgvToplantilar.TabIndex = 1;
            dgvToplantilar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ToplantıPlanlama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvToplantilar);
            Controls.Add(groupBox1);
            Name = "ToplantıPlanlama";
            Text = "ToplantıPlanlama";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToplantilar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAciklama;
        private TextBox txtBaslik;
        private DateTimePicker dtpBitis;
        private DateTimePicker dtpBaslama;
        private ComboBox cmbToplantiTuru;
        private TextBox txtAdres;
        private ListBox lstKatilimcilar;
        private Button btnTemizle;
        private Button btnKaydet;
        private DataGridView dgvToplantilar;
    }
}