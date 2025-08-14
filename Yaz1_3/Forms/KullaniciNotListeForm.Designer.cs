namespace CompanyManagementSystem.Forms
{
    partial class KullaniciNotListeForm
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
            dgvKullanicilar = new DataGridView();
            txtArama = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(12, 70);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.Size = new Size(776, 368);
            dgvKullanicilar.TabIndex = 0;
            dgvKullanicilar.CellClick += dgvKullanicilar_CellClick;
            dgvKullanicilar.CellDoubleClick += dataGridViewKullanicilar_CellDoubleClick;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(12, 41);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(196, 23);
            txtArama.TabIndex = 1;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(638, 36);
            button1.Name = "button1";
            button1.Size = new Size(123, 28);
            button1.TabIndex = 2;
            button1.Text = "Anasayfaya Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KullaniciNotListeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtArama);
            Controls.Add(dgvKullanicilar);
            Name = "KullaniciNotListeForm";
            Text = "KullaniciNotu";
            Load += KullaniciNotListeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKullanicilar;
        private TextBox txtArama;
        private Button button1;
    }
}