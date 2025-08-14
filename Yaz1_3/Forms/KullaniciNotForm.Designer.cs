namespace CompanyManagementSystem.Forms
{
    partial class KullaniciNotForm
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
            lblKullanici = new Label();
            button1 = new Button();
            txtNot = new RichTextBox();
            cmbNotTuru = new ComboBox();
            SuspendLayout();
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.Location = new Point(29, 9);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(38, 15);
            lblKullanici.TabIndex = 0;
            lblKullanici.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(440, 266);
            button1.Name = "button1";
            button1.Size = new Size(93, 28);
            button1.TabIndex = 1;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(12, 56);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(555, 204);
            txtNot.TabIndex = 2;
            txtNot.Text = "";
            // 
            // cmbNotTuru
            // 
            cmbNotTuru.FormattingEnabled = true;
            cmbNotTuru.Location = new Point(12, 27);
            cmbNotTuru.Name = "cmbNotTuru";
            cmbNotTuru.Size = new Size(139, 23);
            cmbNotTuru.TabIndex = 3;
            cmbNotTuru.SelectedIndexChanged += cmbNotTuru_SelectedIndexChanged;
            // 
            // KullaniciNotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 306);
            Controls.Add(cmbNotTuru);
            Controls.Add(txtNot);
            Controls.Add(button1);
            Controls.Add(lblKullanici);
            Name = "KullaniciNotForm";
            Text = "KullaniciNotForm";
            Load += KullaniciNotForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullanici;
        private Button button1;
        private RichTextBox txtNot;
        private ComboBox cmbNotTuru;
    }
}