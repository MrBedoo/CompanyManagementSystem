namespace CompanyManagementSystem.Forms
{
    partial class ProjeOlusturForm
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
            button2 = new Button();
            button1 = new Button();
            cmbProjeLider = new ComboBox();
            dtpProjeBitis = new DateTimePicker();
            dtpProjeBaslangic = new DateTimePicker();
            txtProjeDurum = new TextBox();
            txtProjeAciklama = new TextBox();
            txtProjeBaslik = new TextBox();
            dataGridView1 = new DataGridView();
            txtProjeId = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtProjeId);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbProjeLider);
            groupBox1.Controls.Add(dtpProjeBitis);
            groupBox1.Controls.Add(dtpProjeBaslangic);
            groupBox1.Controls.Add(txtProjeDurum);
            groupBox1.Controls.Add(txtProjeAciklama);
            groupBox1.Controls.Add(txtProjeBaslik);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proje Oluştur";
            // 
            // button2
            // 
            button2.Location = new Point(6, 370);
            button2.Name = "button2";
            button2.Size = new Size(93, 38);
            button2.TabIndex = 7;
            button2.Text = "Anasayfaya Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(201, 299);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 6;
            button1.Text = "Projeyi kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbProjeLider
            // 
            cmbProjeLider.FormattingEnabled = true;
            cmbProjeLider.Location = new Point(60, 251);
            cmbProjeLider.Name = "cmbProjeLider";
            cmbProjeLider.Size = new Size(127, 23);
            cmbProjeLider.TabIndex = 5;
            cmbProjeLider.Text = "Lider";
            // 
            // dtpProjeBitis
            // 
            dtpProjeBitis.Location = new Point(60, 193);
            dtpProjeBitis.Name = "dtpProjeBitis";
            dtpProjeBitis.Size = new Size(200, 23);
            dtpProjeBitis.TabIndex = 4;
            // 
            // dtpProjeBaslangic
            // 
            dtpProjeBaslangic.Location = new Point(60, 164);
            dtpProjeBaslangic.Name = "dtpProjeBaslangic";
            dtpProjeBaslangic.Size = new Size(200, 23);
            dtpProjeBaslangic.TabIndex = 3;
            // 
            // txtProjeDurum
            // 
            txtProjeDurum.Location = new Point(60, 222);
            txtProjeDurum.Name = "txtProjeDurum";
            txtProjeDurum.PlaceholderText = "Durum";
            txtProjeDurum.Size = new Size(127, 23);
            txtProjeDurum.TabIndex = 2;
            // 
            // txtProjeAciklama
            // 
            txtProjeAciklama.Location = new Point(60, 71);
            txtProjeAciklama.Multiline = true;
            txtProjeAciklama.Name = "txtProjeAciklama";
            txtProjeAciklama.PlaceholderText = "Açıklama";
            txtProjeAciklama.Size = new Size(238, 87);
            txtProjeAciklama.TabIndex = 1;
            // 
            // txtProjeBaslik
            // 
            txtProjeBaslik.Location = new Point(60, 42);
            txtProjeBaslik.Name = "txtProjeBaslik";
            txtProjeBaslik.PlaceholderText = "Başlık";
            txtProjeBaslik.Size = new Size(156, 23);
            txtProjeBaslik.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(423, 426);
            dataGridView1.TabIndex = 1;
            // 
            // txtProjeId
            // 
            txtProjeId.Location = new Point(222, 42);
            txtProjeId.Name = "txtProjeId";
            txtProjeId.PlaceholderText = "Id";
            txtProjeId.Size = new Size(76, 23);
            txtProjeId.TabIndex = 8;
            // 
            // ProjeOlusturForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ProjeOlusturForm";
            Text = "ProjeOlusturForm";
            Load += ProjeOlusturForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtProjeAciklama;
        private TextBox txtProjeBaslik;
        private DateTimePicker dtpProjeBitis;
        private DateTimePicker dtpProjeBaslangic;
        private TextBox txtProjeDurum;
        private ComboBox cmbProjeLider;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox txtProjeId;
    }
}