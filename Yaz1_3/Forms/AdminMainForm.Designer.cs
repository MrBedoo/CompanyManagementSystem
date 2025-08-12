namespace CompanyManagementSystem.Forms
{
    partial class AdminMainForm
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
            button1 = new Button();
            btnToplantiPlanlama = new Button();
            button3 = new Button();
            button4 = new Button();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 51);
            button1.Name = "button1";
            button1.Size = new Size(155, 35);
            button1.TabIndex = 0;
            button1.Text = "Kullanıcı yönetim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnToplantiPlanlama
            // 
            btnToplantiPlanlama.Location = new Point(311, 51);
            btnToplantiPlanlama.Name = "btnToplantiPlanlama";
            btnToplantiPlanlama.Size = new Size(155, 35);
            btnToplantiPlanlama.TabIndex = 1;
            btnToplantiPlanlama.Text = "Toplantı planlama";
            btnToplantiPlanlama.UseVisualStyleBackColor = true;
            btnToplantiPlanlama.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 109);
            button3.Name = "button3";
            button3.Size = new Size(155, 35);
            button3.TabIndex = 2;
            button3.Text = "Proje/Görev işlemleri";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(472, 51);
            button4.Name = "button4";
            button4.Size = new Size(155, 35);
            button4.TabIndex = 3;
            button4.Text = "Proje/Görev oluşturma";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(595, 287);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(103, 37);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCikis);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnToplantiPlanlama);
            Controls.Add(button1);
            Name = "AdminMainForm";
            Text = "AdminMainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnToplantiPlanlama;
        private Button button3;
        private Button button4;
        private Button btnCikis;
    }
}