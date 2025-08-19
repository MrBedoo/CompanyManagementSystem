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
            button3 = new Button();
            SuspendLayout();
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(72, 399);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(119, 39);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnToplantıListesi
            // 
            btnToplantıListesi.Location = new Point(72, 101);
            btnToplantıListesi.Name = "btnToplantıListesi";
            btnToplantıListesi.Size = new Size(147, 43);
            btnToplantıListesi.TabIndex = 1;
            btnToplantıListesi.Text = "Toplantılar";
            btnToplantıListesi.UseVisualStyleBackColor = true;
            btnToplantıListesi.Click += btnToplantıListesi_Click;
            // 
            // button1
            // 
            button1.Location = new Point(72, 52);
            button1.Name = "button1";
            button1.Size = new Size(147, 43);
            button1.TabIndex = 2;
            button1.Text = "Görevler";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(225, 52);
            button3.Name = "button3";
            button3.Size = new Size(147, 43);
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
            Controls.Add(button1);
            Controls.Add(btnToplantıListesi);
            Controls.Add(btnCikis);
            Name = "UserMainForm";
            Text = "UserMainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCikis;
        private Button btnToplantıListesi;
        private Button button1;
        private Button button3;
    }
}