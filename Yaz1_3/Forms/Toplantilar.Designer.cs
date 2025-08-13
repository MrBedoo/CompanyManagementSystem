namespace CompanyManagementSystem.Forms
{
    partial class Toplantilar
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
            splitContainer1 = new SplitContainer();
            dgvToplantilar = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtDurum = new TextBox();
            Durum = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            txtAdres = new TextBox();
            txtBitisTarihi = new TextBox();
            txtBaslamaTarihi = new TextBox();
            txtAciklama = new TextBox();
            txtBaslik = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToplantilar).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvToplantilar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // dgvToplantilar
            // 
            dgvToplantilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToplantilar.Dock = DockStyle.Fill;
            dgvToplantilar.Location = new Point(0, 0);
            dgvToplantilar.Name = "dgvToplantilar";
            dgvToplantilar.ReadOnly = true;
            dgvToplantilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToplantilar.Size = new Size(410, 450);
            dgvToplantilar.TabIndex = 0;
            dgvToplantilar.CellContentClick += dgvToplantilar_CellContentClick;
            dgvToplantilar.SelectionChanged += dgvToplantilar_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDurum);
            groupBox1.Controls.Add(Durum);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(txtBitisTarihi);
            groupBox1.Controls.Add(txtBaslamaTarihi);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(txtBaslik);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 450);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toplantı Detayları";
            // 
            // button1
            // 
            button1.Location = new Point(283, 371);
            button1.Name = "button1";
            button1.Size = new Size(89, 39);
            button1.TabIndex = 14;
            button1.Text = "Anasayfaya dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDurum
            // 
            txtDurum.Location = new Point(105, 371);
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(135, 23);
            txtDurum.TabIndex = 13;
            // 
            // Durum
            // 
            Durum.AutoSize = true;
            Durum.Location = new Point(55, 371);
            Durum.Name = "Durum";
            Durum.Size = new Size(44, 15);
            Durum.TabIndex = 12;
            Durum.Text = "Durum";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(105, 250);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(239, 94);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 250);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 10;
            label6.Text = "Katılımcı Listesi";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(105, 194);
            txtAdres.Name = "txtAdres";
            txtAdres.ReadOnly = true;
            txtAdres.Size = new Size(169, 23);
            txtAdres.TabIndex = 9;
            // 
            // txtBitisTarihi
            // 
            txtBitisTarihi.Location = new Point(105, 165);
            txtBitisTarihi.Name = "txtBitisTarihi";
            txtBitisTarihi.ReadOnly = true;
            txtBitisTarihi.Size = new Size(169, 23);
            txtBitisTarihi.TabIndex = 8;
            // 
            // txtBaslamaTarihi
            // 
            txtBaslamaTarihi.Location = new Point(105, 136);
            txtBaslamaTarihi.Name = "txtBaslamaTarihi";
            txtBaslamaTarihi.ReadOnly = true;
            txtBaslamaTarihi.Size = new Size(169, 23);
            txtBaslamaTarihi.TabIndex = 7;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(105, 62);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.ReadOnly = true;
            txtAciklama.Size = new Size(285, 68);
            txtAciklama.TabIndex = 6;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(105, 33);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.ReadOnly = true;
            txtBaslik.Size = new Size(135, 23);
            txtBaslik.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 197);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Adres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 168);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "Bitiş Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 139);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Başlangıç Tarihi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Açıklama:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Başlık:";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // Toplantilar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Toplantilar";
            Text = "Toplantilar";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvToplantilar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dgvToplantilar;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Label label6;
        private TextBox txtAdres;
        private TextBox txtBitisTarihi;
        private TextBox txtBaslamaTarihi;
        private TextBox txtAciklama;
        private TextBox txtBaslik;
        private TextBox txtDurum;
        private Label Durum;
        private Button button1;
    }
}