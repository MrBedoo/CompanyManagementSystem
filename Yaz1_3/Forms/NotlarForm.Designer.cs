namespace CompanyManagementSystem.Forms
{
    partial class NotlarForm
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
            dgvNotlar = new DataGridView();
            txtNotMetni = new RichTextBox();
            lblGonderen = new Label();
            txtNotTarihi = new TextBox();
            button1 = new Button();
            txtNotTuru = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).BeginInit();
            SuspendLayout();
            // 
            // dgvNotlar
            // 
            dgvNotlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotlar.Location = new Point(428, 12);
            dgvNotlar.Name = "dgvNotlar";
            dgvNotlar.Size = new Size(360, 426);
            dgvNotlar.TabIndex = 0;
            dgvNotlar.CellContentClick += dataGridView1_CellContentClick;
            dgvNotlar.CellDoubleClick += dgvNotlar_CellDoubleClick;
            // 
            // txtNotMetni
            // 
            txtNotMetni.Location = new Point(46, 44);
            txtNotMetni.Name = "txtNotMetni";
            txtNotMetni.ReadOnly = true;
            txtNotMetni.Size = new Size(280, 309);
            txtNotMetni.TabIndex = 1;
            txtNotMetni.Text = "";
            // 
            // lblGonderen
            // 
            lblGonderen.AutoSize = true;
            lblGonderen.Location = new Point(242, 26);
            lblGonderen.Name = "lblGonderen";
            lblGonderen.Size = new Size(38, 15);
            lblGonderen.TabIndex = 2;
            lblGonderen.Text = "label1";
            // 
            // txtNotTarihi
            // 
            txtNotTarihi.Location = new Point(210, 359);
            txtNotTarihi.Name = "txtNotTarihi";
            txtNotTarihi.ReadOnly = true;
            txtNotTarihi.Size = new Size(116, 23);
            txtNotTarihi.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(25, 410);
            button1.Name = "button1";
            button1.Size = new Size(118, 28);
            button1.TabIndex = 4;
            button1.Text = "Anasayfaya Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNotTuru
            // 
            txtNotTuru.Location = new Point(98, 18);
            txtNotTuru.Name = "txtNotTuru";
            txtNotTuru.ReadOnly = true;
            txtNotTuru.Size = new Size(100, 23);
            txtNotTuru.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Not türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 362);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "Not Tarihi:";
            // 
            // NotlarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNotTuru);
            Controls.Add(button1);
            Controls.Add(txtNotTarihi);
            Controls.Add(lblGonderen);
            Controls.Add(txtNotMetni);
            Controls.Add(dgvNotlar);
            Name = "NotlarForm";
            Text = "Notlar";
            Load += NotlarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNotlar;
        private RichTextBox txtNotMetni;
        private Label lblGonderen;
        private TextBox txtNotTarihi;
        private Button button1;
        private TextBox txtNotTuru;
        private Label label1;
        private Label label2;
    }
}