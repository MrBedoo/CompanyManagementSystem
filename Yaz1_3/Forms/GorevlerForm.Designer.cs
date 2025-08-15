namespace CompanyManagementSystem.Forms
{
    partial class GorevlerForm
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
            dgvDevamEden = new DataGridView();
            txtGorevMesaj = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtGorevBaslik = new TextBox();
            txtGorevAciklama = new TextBox();
            txtGorevOncelik = new TextBox();
            txtGorevBaslama = new TextBox();
            txtGorevBitis = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label8 = new Label();
            txtGorevRapor = new TextBox();
            cmbGorevDurum = new ComboBox();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDevamEden).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDevamEden
            // 
            dgvDevamEden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevamEden.Location = new Point(396, 27);
            dgvDevamEden.Name = "dgvDevamEden";
            dgvDevamEden.Size = new Size(390, 235);
            dgvDevamEden.TabIndex = 0;
            dgvDevamEden.CellClick += dgvDevamEden_CellClick;
            dgvDevamEden.CellContentClick += dgvDevamEden_CellContentClick;
            // 
            // txtGorevMesaj
            // 
            txtGorevMesaj.Location = new Point(350, 297);
            txtGorevMesaj.Multiline = true;
            txtGorevMesaj.Name = "txtGorevMesaj";
            txtGorevMesaj.ReadOnly = true;
            txtGorevMesaj.Size = new Size(438, 141);
            txtGorevMesaj.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Görev Listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 279);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 3;
            label2.Text = "Görevle ilgili Bilgilendirme ve Uyarılar:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 410);
            button2.Name = "button2";
            button2.Size = new Size(102, 28);
            button2.TabIndex = 5;
            button2.Text = "Anasayfaya Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 33);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Başlık";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 62);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Açıklama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 241);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Öncelik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 270);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 9;
            label6.Text = "Başlama Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 299);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 10;
            label7.Text = "Bitiş Tarihi";
            // 
            // txtGorevBaslik
            // 
            txtGorevBaslik.Location = new Point(95, 30);
            txtGorevBaslik.Name = "txtGorevBaslik";
            txtGorevBaslik.ReadOnly = true;
            txtGorevBaslik.Size = new Size(183, 23);
            txtGorevBaslik.TabIndex = 11;
            // 
            // txtGorevAciklama
            // 
            txtGorevAciklama.Location = new Point(95, 59);
            txtGorevAciklama.Multiline = true;
            txtGorevAciklama.Name = "txtGorevAciklama";
            txtGorevAciklama.ReadOnly = true;
            txtGorevAciklama.Size = new Size(207, 170);
            txtGorevAciklama.TabIndex = 12;
            // 
            // txtGorevOncelik
            // 
            txtGorevOncelik.Location = new Point(95, 238);
            txtGorevOncelik.Name = "txtGorevOncelik";
            txtGorevOncelik.ReadOnly = true;
            txtGorevOncelik.Size = new Size(134, 23);
            txtGorevOncelik.TabIndex = 13;
            // 
            // txtGorevBaslama
            // 
            txtGorevBaslama.Location = new Point(95, 267);
            txtGorevBaslama.Name = "txtGorevBaslama";
            txtGorevBaslama.ReadOnly = true;
            txtGorevBaslama.Size = new Size(207, 23);
            txtGorevBaslama.TabIndex = 14;
            txtGorevBaslama.TextChanged += textBox5_TextChanged;
            // 
            // txtGorevBitis
            // 
            txtGorevBitis.Location = new Point(95, 296);
            txtGorevBitis.Name = "txtGorevBitis";
            txtGorevBitis.ReadOnly = true;
            txtGorevBitis.Size = new Size(207, 23);
            txtGorevBitis.TabIndex = 15;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(332, 395);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtGorevBitis);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtGorevBaslik);
            tabPage1.Controls.Add(txtGorevBaslama);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtGorevOncelik);
            tabPage1.Controls.Add(txtGorevAciklama);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(324, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Görev Detay";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtGorevRapor);
            tabPage2.Controls.Add(cmbGorevDurum);
            tabPage2.Controls.Add(btnKaydet);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(324, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Görev Rapor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 292);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 4;
            label8.Text = "Durum:";
            // 
            // txtGorevRapor
            // 
            txtGorevRapor.Location = new Point(24, 20);
            txtGorevRapor.Multiline = true;
            txtGorevRapor.Name = "txtGorevRapor";
            txtGorevRapor.PlaceholderText = "Görev Raporu";
            txtGorevRapor.Size = new Size(274, 240);
            txtGorevRapor.TabIndex = 3;
            // 
            // cmbGorevDurum
            // 
            cmbGorevDurum.FormattingEnabled = true;
            cmbGorevDurum.Location = new Point(65, 289);
            cmbGorevDurum.Name = "cmbGorevDurum";
            cmbGorevDurum.Size = new Size(121, 23);
            cmbGorevDurum.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(223, 288);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // GorevlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtGorevMesaj);
            Controls.Add(dgvDevamEden);
            Name = "GorevlerForm";
            Text = "Gorevler";
            Load += GorevlerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevamEden).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDevamEden;
        private TextBox txtGorevMesaj;
        private Label label1;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtGorevBaslik;
        private TextBox txtGorevAciklama;
        private TextBox txtGorevOncelik;
        private TextBox txtGorevBaslama;
        private TextBox txtGorevBitis;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbGorevDurum;
        private Button btnKaydet;
        private TextBox txtGorevRapor;
        private Label label8;
    }
}