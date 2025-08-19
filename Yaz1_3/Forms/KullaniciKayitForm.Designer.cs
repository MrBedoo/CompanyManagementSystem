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
            button2 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "İsim";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 51);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Soyisim";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 108);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(274, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(201, 137);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Gelir";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(8, 137);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Şifre";
            textBox5.Size = new Size(187, 23);
            textBox5.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBox1.Location = new Point(168, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(114, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(8, 79);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(168, 228);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(102, 38);
            Temizle.TabIndex = 10;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += Temizle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(8, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 124);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ResimYükle
            // 
            ResimYükle.Location = new Point(15, 301);
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
            dataGridView1.Location = new Point(314, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1044, 652);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.Enter += dataGridView1_Enter;
            // 
            // EkleGuncelle
            // 
            EkleGuncelle.Location = new Point(168, 184);
            EkleGuncelle.Name = "EkleGuncelle";
            EkleGuncelle.Size = new Size(102, 38);
            EkleGuncelle.TabIndex = 14;
            EkleGuncelle.Text = "Ekle/Güncelle";
            EkleGuncelle.UseVisualStyleBackColor = true;
            EkleGuncelle.Click += EkleGuncelle_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(8, 22);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Id";
            textBox6.Size = new Size(133, 23);
            textBox6.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(10, 707);
            button2.Name = "button2";
            button2.Size = new Size(133, 30);
            button2.TabIndex = 19;
            button2.Text = "Anasayfaya dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(Temizle);
            groupBox1.Controls.Add(EkleGuncelle);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(ResimYükle);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(10, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 351);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Görüntüleme/Kayıt";
            // 
            // KullaniciKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            MinimizeBox = false;
            Name = "KullaniciKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "Kullanıcı Kayıt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button button2;
        private GroupBox groupBox1;
    }
}
