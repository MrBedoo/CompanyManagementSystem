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
            button1 = new Button();
            dataGridView2 = new DataGridView();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 111);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "İsim";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 111);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Soyisim";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 168);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(216, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 197);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Gelir";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(37, 197);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Şifre";
            textBox5.Size = new Size(129, 23);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new Point(179, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(37, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(164, 267);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(89, 30);
            Temizle.TabIndex = 10;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += Temizle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(37, 231);
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
            ResimYükle.Location = new Point(37, 349);
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
            dataGridView1.Location = new Point(156, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1202, 299);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // EkleGuncelle
            // 
            EkleGuncelle.Location = new Point(164, 231);
            EkleGuncelle.Name = "EkleGuncelle";
            EkleGuncelle.Size = new Size(89, 30);
            EkleGuncelle.TabIndex = 14;
            EkleGuncelle.Text = "Ekle/Güncelle";
            EkleGuncelle.UseVisualStyleBackColor = true;
            EkleGuncelle.Click += EkleGuncelle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(164, 303);
            button1.Name = "button1";
            button1.Size = new Size(89, 40);
            button1.TabIndex = 16;
            button1.Text = "Admin \r\nekle/güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(289, 140);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1069, 264);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView2.Enter += dataGridView2_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(80, 82);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Id";
            textBox6.Size = new Size(133, 23);
            textBox6.TabIndex = 18;
            // 
            // KullaniciKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(textBox6);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
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
        private Button button1;
        private DataGridView dataGridView2;
        private TextBox textBox6;
    }
}
