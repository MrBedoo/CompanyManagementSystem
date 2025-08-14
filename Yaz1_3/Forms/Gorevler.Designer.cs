namespace CompanyManagementSystem.Forms
{
    partial class Gorevler
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
            ((System.ComponentModel.ISupportInitialize)dgvDevamEden).BeginInit();
            SuspendLayout();
            // 
            // dgvDevamEden
            // 
            dgvDevamEden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevamEden.Location = new Point(398, 47);
            dgvDevamEden.Name = "dgvDevamEden";
            dgvDevamEden.Size = new Size(390, 391);
            dgvDevamEden.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(284, 298);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Görev Listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 29);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Bilgilendirme ve Uyarılar:";
            // 
            // button1
            // 
            button1.Location = new Point(568, 12);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 4;
            button1.Text = "Seçili Görevi Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Gorevler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvDevamEden);
            Name = "Gorevler";
            Text = "Gorevler";
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
    }
}