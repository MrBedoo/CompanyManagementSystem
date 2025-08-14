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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDevamEden).BeginInit();
            SuspendLayout();
            // 
            // dgvDevamEden
            // 
            dgvDevamEden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevamEden.Location = new Point(398, 27);
            dgvDevamEden.Name = "dgvDevamEden";
            dgvDevamEden.Size = new Size(390, 235);
            dgvDevamEden.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 303);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(438, 135);
            textBox1.TabIndex = 1;
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
            label2.Location = new Point(350, 285);
            label2.Name = "label2";
            label2.Size = new Size(206, 15);
            label2.TabIndex = 3;
            label2.Text = "Görevle ilgili Bilgilendirme ve Uyarılar:";
            // 
            // button1
            // 
            button1.Location = new Point(678, 268);
            button1.Name = "button1";
            button1.Size = new Size(110, 25);
            button1.TabIndex = 4;
            button1.Text = "Seçili Görevi Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 399);
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
            label3.Location = new Point(45, 48);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Başlık";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 77);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 7;
            label4.Text = "Açıklama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 230);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Öncelik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 259);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 9;
            label6.Text = "Başlama Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 288);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 10;
            label7.Text = "Bitiş Tarihi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 74);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 147);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 227);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(87, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(87, 285);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(223, 23);
            textBox6.TabIndex = 15;
            // 
            // GorevlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvDevamEden);
            Name = "GorevlerForm";
            Text = "Gorevler";
            Load += GorevlerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevamEden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDevamEden;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}