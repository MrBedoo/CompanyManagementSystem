namespace CompanyManagementSystem.Forms
{
    partial class ProjelerForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtProjeAdi = new TextBox();
            txtProjeAciklama = new TextBox();
            txtProjeBaslama = new TextBox();
            txtProjeBitis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtProjeDurum = new TextBox();
            txtProjeYonetici = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(372, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(416, 426);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 412);
            button1.Name = "button1";
            button1.Size = new Size(99, 26);
            button1.TabIndex = 1;
            button1.Text = "Anasayfaya dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtProjeAdi
            // 
            txtProjeAdi.Location = new Point(101, 36);
            txtProjeAdi.Name = "txtProjeAdi";
            txtProjeAdi.ReadOnly = true;
            txtProjeAdi.Size = new Size(170, 23);
            txtProjeAdi.TabIndex = 2;
            // 
            // txtProjeAciklama
            // 
            txtProjeAciklama.Location = new Point(101, 65);
            txtProjeAciklama.Multiline = true;
            txtProjeAciklama.Name = "txtProjeAciklama";
            txtProjeAciklama.ReadOnly = true;
            txtProjeAciklama.Size = new Size(247, 148);
            txtProjeAciklama.TabIndex = 3;
            // 
            // txtProjeBaslama
            // 
            txtProjeBaslama.Location = new Point(101, 219);
            txtProjeBaslama.Name = "txtProjeBaslama";
            txtProjeBaslama.ReadOnly = true;
            txtProjeBaslama.Size = new Size(118, 23);
            txtProjeBaslama.TabIndex = 4;
            // 
            // txtProjeBitis
            // 
            txtProjeBitis.Location = new Point(101, 248);
            txtProjeBitis.Name = "txtProjeBitis";
            txtProjeBitis.ReadOnly = true;
            txtProjeBitis.Size = new Size(118, 23);
            txtProjeBitis.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Proje Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 68);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Açıklama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 222);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 251);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 280);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 10;
            label5.Text = "Durum";
            // 
            // txtProjeDurum
            // 
            txtProjeDurum.Location = new Point(101, 277);
            txtProjeDurum.Name = "txtProjeDurum";
            txtProjeDurum.ReadOnly = true;
            txtProjeDurum.Size = new Size(170, 23);
            txtProjeDurum.TabIndex = 11;
            // 
            // txtProjeYonetici
            // 
            txtProjeYonetici.Location = new Point(101, 316);
            txtProjeYonetici.Name = "txtProjeYonetici";
            txtProjeYonetici.ReadOnly = true;
            txtProjeYonetici.Size = new Size(136, 23);
            txtProjeYonetici.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 319);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 13;
            label6.Text = "Yönetici Adı:";
            // 
            // ProjelerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtProjeYonetici);
            Controls.Add(txtProjeDurum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProjeBitis);
            Controls.Add(txtProjeBaslama);
            Controls.Add(txtProjeAciklama);
            Controls.Add(txtProjeAdi);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ProjelerForm";
            Text = "Projeler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtProjeAdi;
        private TextBox txtProjeAciklama;
        private TextBox txtProjeBaslama;
        private TextBox txtProjeBitis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtProjeDurum;
        private TextBox txtProjeYonetici;
        private Label label6;
    }
}