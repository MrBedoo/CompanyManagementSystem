namespace CompanyManagementSystem.Forms
{
    partial class UserMainForm
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
            btnCikis = new Button();
            btnToplantıListesi = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtGorevOlusturmaTarihi = new TextBox();
            txtGorevBitisTarihi = new TextBox();
            txtGorevOncelik = new TextBox();
            txtGorevAciklama = new TextBox();
            txtGorevBaslik = new TextBox();
            label3 = new Label();
            cmbGorevDurum = new ComboBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(573, 286);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(119, 39);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnToplantıListesi
            // 
            btnToplantıListesi.Location = new Point(545, 120);
            btnToplantıListesi.Name = "btnToplantıListesi";
            btnToplantıListesi.Size = new Size(147, 43);
            btnToplantıListesi.TabIndex = 1;
            btnToplantıListesi.Text = "Toplantılar";
            btnToplantıListesi.UseVisualStyleBackColor = true;
            btnToplantıListesi.Click += btnToplantıListesi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(545, 71);
            button1.Name = "button1";
            button1.Size = new Size(147, 43);
            button1.TabIndex = 2;
            button1.Text = "Görevler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtGorevOlusturmaTarihi);
            groupBox1.Controls.Add(txtGorevBitisTarihi);
            groupBox1.Controls.Add(txtGorevOncelik);
            groupBox1.Controls.Add(txtGorevAciklama);
            groupBox1.Controls.Add(txtGorevBaslik);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 398);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Görevin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 268);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 237);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 10;
            label5.Text = "Oluşturma Tarihi";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 205);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Öncelik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 51);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Açıklama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 25);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 6;
            label1.Text = "Başlık";
            label1.Click += label1_Click;
            // 
            // txtGorevOlusturmaTarihi
            // 
            txtGorevOlusturmaTarihi.Location = new Point(112, 234);
            txtGorevOlusturmaTarihi.Name = "txtGorevOlusturmaTarihi";
            txtGorevOlusturmaTarihi.ReadOnly = true;
            txtGorevOlusturmaTarihi.Size = new Size(163, 23);
            txtGorevOlusturmaTarihi.TabIndex = 5;
            // 
            // txtGorevBitisTarihi
            // 
            txtGorevBitisTarihi.Location = new Point(112, 265);
            txtGorevBitisTarihi.Name = "txtGorevBitisTarihi";
            txtGorevBitisTarihi.ReadOnly = true;
            txtGorevBitisTarihi.Size = new Size(163, 23);
            txtGorevBitisTarihi.TabIndex = 4;
            // 
            // txtGorevOncelik
            // 
            txtGorevOncelik.Location = new Point(112, 202);
            txtGorevOncelik.Name = "txtGorevOncelik";
            txtGorevOncelik.ReadOnly = true;
            txtGorevOncelik.Size = new Size(121, 23);
            txtGorevOncelik.TabIndex = 3;
            // 
            // txtGorevAciklama
            // 
            txtGorevAciklama.Location = new Point(112, 51);
            txtGorevAciklama.Multiline = true;
            txtGorevAciklama.Name = "txtGorevAciklama";
            txtGorevAciklama.ReadOnly = true;
            txtGorevAciklama.Size = new Size(204, 145);
            txtGorevAciklama.TabIndex = 1;
            // 
            // txtGorevBaslik
            // 
            txtGorevBaslik.Location = new Point(112, 22);
            txtGorevBaslik.Name = "txtGorevBaslik";
            txtGorevBaslik.ReadOnly = true;
            txtGorevBaslik.Size = new Size(204, 23);
            txtGorevBaslik.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 345);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 13;
            label3.Text = "Durum";
            // 
            // cmbGorevDurum
            // 
            cmbGorevDurum.FormattingEnabled = true;
            cmbGorevDurum.Items.AddRange(new object[] { "Tamamlandı", "Tamamlanmadı", "Iptal" });
            cmbGorevDurum.Location = new Point(64, 342);
            cmbGorevDurum.Name = "cmbGorevDurum";
            cmbGorevDurum.Size = new Size(121, 23);
            cmbGorevDurum.TabIndex = 12;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(351, 426);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(343, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Görev Detay";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(cmbGorevDurum);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(343, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Görev Rapor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(225, 338);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 1;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Görev Raporu";
            textBox1.Size = new Size(311, 313);
            textBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(545, 183);
            button3.Name = "button3";
            button3.Size = new Size(147, 34);
            button3.TabIndex = 5;
            button3.Text = "Notlar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(btnToplantıListesi);
            Controls.Add(btnCikis);
            Name = "UserMainForm";
            Text = "UserMainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCikis;
        private Button btnToplantıListesi;
        private Button button1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtGorevOlusturmaTarihi;
        private TextBox txtGorevBitisTarihi;
        private TextBox txtGorevOncelik;
        private TextBox txtGorevAciklama;
        private TextBox txtGorevBaslik;
        private TextBox textBox1;
        private Label label3;
        private ComboBox cmbGorevDurum;
        private Button button2;
        private Button button3;
    }
}