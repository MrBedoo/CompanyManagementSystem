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
            dtpBitis = new DateTimePicker();
            btnGorevKaydet = new Button();
            cmbAtananKullanici = new ComboBox();
            txtGorevBaslik = new TextBox();
            txtGorevDurum = new TextBox();
            txtGorevAciklama = new TextBox();
            cmbProjeler = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            // dtpBitis
            // 
            dtpBitis.Location = new Point(43, 185);
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
            cmbAtananKullanici.Location = new Point(43, 273);
            cmbAtananKullanici.Name = "cmbAtananKullanici";
            cmbAtananKullanici.Size = new Size(121, 23);
            cmbAtananKullanici.TabIndex = 6;
            cmbAtananKullanici.Text = "Atanan Kullanıcı";
            // 
            // txtGorevBaslik
            // 
            txtGorevBaslik.Location = new Point(43, 45);
            txtGorevBaslik.Name = "txtGorevBaslik";
            txtGorevBaslik.PlaceholderText = "Başlık";
            txtGorevBaslik.Size = new Size(167, 23);
            txtGorevBaslik.TabIndex = 5;
            txtGorevBaslik.TextChanged += txtGorevBaslik_TextChanged;
            // 
            // txtGorevDurum
            // 
            txtGorevDurum.Location = new Point(43, 214);
            txtGorevDurum.Name = "txtGorevDurum";
            txtGorevDurum.PlaceholderText = "Durum";
            txtGorevDurum.Size = new Size(121, 23);
            txtGorevDurum.TabIndex = 4;
            // 
            // txtGorevAciklama
            // 
            txtGorevAciklama.Location = new Point(43, 74);
            txtGorevAciklama.Multiline = true;
            txtGorevAciklama.Name = "txtGorevAciklama";
            txtGorevAciklama.PlaceholderText = "Açıklama";
            txtGorevAciklama.Size = new Size(252, 105);
            txtGorevAciklama.TabIndex = 1;
            // 
            // cmbProjeler
            // 
            cmbProjeler.FormattingEnabled = true;
            cmbProjeler.Location = new Point(43, 243);
            cmbProjeler.Name = "cmbProjeler";
            cmbProjeler.Size = new Size(121, 23);
            cmbProjeler.TabIndex = 10;
            cmbProjeler.Text = "Projeler";
            // 
            // GorevOlusturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "GorevOlusturForm";
            Text = "GorevOlusturForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}