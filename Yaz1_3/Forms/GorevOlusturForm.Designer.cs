namespace CompanyManagementSystem.Forms
{
    partial class GorevOlusturForm
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
            label1 = new Label();
            txtGorevOncelik = new TextBox();
            button1 = new Button();
            cmbProjeler = new ComboBox();
            dtpBitis = new DateTimePicker();
            btnGorevKaydet = new Button();
            cmbAtananKullanici = new ComboBox();
            txtGorevBaslik = new TextBox();
            txtGorevDurum = new TextBox();
            txtGorevAciklama = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGorevOncelik);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbProjeler);
            groupBox1.Controls.Add(dtpBitis);
            groupBox1.Controls.Add(btnGorevKaydet);
            groupBox1.Controls.Add(cmbAtananKullanici);
            groupBox1.Controls.Add(txtGorevBaslik);
            groupBox1.Controls.Add(txtGorevDurum);
            groupBox1.Controls.Add(txtGorevAciklama);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Görev Oluştur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 233);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 12;
            label1.Text = "(Öncelikli, vb.)";
            // 
            // txtGorevOncelik
            // 
            txtGorevOncelik.Location = new Point(43, 230);
            txtGorevOncelik.Name = "txtGorevOncelik";
            txtGorevOncelik.PlaceholderText = "Öncelik Durumu";
            txtGorevOncelik.Size = new Size(167, 23);
            txtGorevOncelik.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(31, 393);
            button1.Name = "button1";
            button1.Size = new Size(104, 27);
            button1.TabIndex = 1;
            button1.Text = "Anasayfaya Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbProjeler
            // 
            cmbProjeler.FormattingEnabled = true;
            cmbProjeler.Location = new Point(43, 288);
            cmbProjeler.Name = "cmbProjeler";
            cmbProjeler.Size = new Size(121, 23);
            cmbProjeler.TabIndex = 10;
            cmbProjeler.Text = "Projeler";
            cmbProjeler.SelectedIndexChanged += cmbProjeler_SelectedIndexChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(43, 201);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(200, 23);
            dtpBitis.TabIndex = 9;
            // 
            // btnGorevKaydet
            // 
            btnGorevKaydet.Location = new Point(176, 358);
            btnGorevKaydet.Name = "btnGorevKaydet";
            btnGorevKaydet.Size = new Size(119, 33);
            btnGorevKaydet.TabIndex = 7;
            btnGorevKaydet.Text = "Görev Kaydet";
            btnGorevKaydet.UseVisualStyleBackColor = true;
            btnGorevKaydet.Click += btnGorevKaydet_Click;
            // 
            // cmbAtananKullanici
            // 
            cmbAtananKullanici.FormattingEnabled = true;
            cmbAtananKullanici.Location = new Point(43, 317);
            cmbAtananKullanici.Name = "cmbAtananKullanici";
            cmbAtananKullanici.Size = new Size(121, 23);
            cmbAtananKullanici.TabIndex = 6;
            cmbAtananKullanici.Text = "Atanan Kullanıcı";
            // 
            // txtGorevBaslik
            // 
            txtGorevBaslik.Location = new Point(43, 35);
            txtGorevBaslik.Name = "txtGorevBaslik";
            txtGorevBaslik.PlaceholderText = "Başlık";
            txtGorevBaslik.Size = new Size(167, 23);
            txtGorevBaslik.TabIndex = 5;
            txtGorevBaslik.TextChanged += txtGorevBaslik_TextChanged;
            // 
            // txtGorevDurum
            // 
            txtGorevDurum.Location = new Point(43, 259);
            txtGorevDurum.Name = "txtGorevDurum";
            txtGorevDurum.PlaceholderText = "Durum";
            txtGorevDurum.Size = new Size(121, 23);
            txtGorevDurum.TabIndex = 4;
            // 
            // txtGorevAciklama
            // 
            txtGorevAciklama.Location = new Point(43, 64);
            txtGorevAciklama.Multiline = true;
            txtGorevAciklama.Name = "txtGorevAciklama";
            txtGorevAciklama.PlaceholderText = "Açıklama";
            txtGorevAciklama.Size = new Size(289, 131);
            txtGorevAciklama.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(389, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(399, 426);
            dataGridView1.TabIndex = 1;
            // 
            // GorevOlusturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "GorevOlusturForm";
            Text = "GorevOlusturForm";
            Load += GorevOlusturForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGorevDurum;
        private TextBox txtGorevAciklama;
        private TextBox txtGorevBaslik;
        private ComboBox cmbAtananKullanici;
        private Button btnGorevKaydet;
        private DateTimePicker dtpBitis;
        private ComboBox cmbProjeler;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtGorevOncelik;
        private Label label1;
    }
}