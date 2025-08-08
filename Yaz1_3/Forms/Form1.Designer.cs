namespace CompanyManagementSystem
{
    partial class KullaniciKayit
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
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            Temizle = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ResimYükle = new Button();
            dataGridView1 = new DataGridView();
            EkleGuncelle = new Button();
            textBox6 = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 105);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "İsim";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(655, 105);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Soyisim";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(529, 162);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(247, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(681, 191);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Gelir";
            textBox4.Size = new Size(95, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(529, 191);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Şifre";
            textBox5.Size = new Size(146, 23);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new Point(693, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(83, 23);
            comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(529, 133);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(158, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(656, 299);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(120, 38);
            Temizle.TabIndex = 10;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += Temizle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(529, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 112);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ResimYükle
            // 
            ResimYükle.Location = new Point(529, 343);
            ResimYükle.Name = "ResimYükle";
            ResimYükle.Size = new Size(118, 23);
            ResimYükle.TabIndex = 12;
            ResimYükle.Text = "Resim yükle";
            ResimYükle.UseVisualStyleBackColor = true;
            ResimYükle.Click += ResimYükle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1346, 299);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // EkleGuncelle
            // 
            EkleGuncelle.Location = new Point(656, 244);
            EkleGuncelle.Name = "EkleGuncelle";
            EkleGuncelle.Size = new Size(120, 38);
            EkleGuncelle.TabIndex = 14;
            EkleGuncelle.Text = "Ekle/Güncelle";
            EkleGuncelle.UseVisualStyleBackColor = true;
            EkleGuncelle.Click += EkleGuncelle_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(580, 76);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Kullanıcı Id";
            textBox6.Size = new Size(150, 23);
            textBox6.TabIndex = 15;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(653, 343);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 16;
            button1.Text = "Admin ekle/güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(811, 225);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(547, 150);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // KullaniciKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(EkleGuncelle);
            Controls.Add(dataGridView1);
            Controls.Add(ResimYükle);
            Controls.Add(pictureBox1);
            Controls.Add(Temizle);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MinimizeBox = false;
            Name = "KullaniciKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "Kullanıcı Kayıt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button Temizle;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button ResimYükle;
        private DataGridView dataGridView1;
        private Button EkleGuncelle;
        private TextBox textBox6;
        private Button button1;
        private DataGridView dataGridView2;
    }
}
