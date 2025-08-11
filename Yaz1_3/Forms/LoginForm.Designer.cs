namespace CompanyManagementSystem.Forms
{
    partial class LoginForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtSifre = new Guna.UI2.WinForms.Guna2TextBox();
            BtnLogin = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(294, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(167, 31);
            txtEmail.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.CustomizableEdges = customizableEdges3;
            txtSifre.DefaultText = "";
            txtSifre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSifre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSifre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSifre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSifre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifre.Font = new Font("Segoe UI", 9F);
            txtSifre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSifre.Location = new Point(294, 172);
            txtSifre.Name = "txtSifre";
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.SelectedText = "";
            txtSifre.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSifre.Size = new Size(167, 31);
            txtSifre.TabIndex = 1;
            // 
            // BtnLogin
            // 
            BtnLogin.CustomizableEdges = customizableEdges5;
            BtnLogin.DisabledState.BorderColor = Color.DarkGray;
            BtnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            BtnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BtnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BtnLogin.Font = new Font("Segoe UI", 9F);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(316, 209);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BtnLogin.Size = new Size(131, 31);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Giriş Yap";
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLogin);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSifre;
        private Guna.UI2.WinForms.Guna2Button BtnLogin;
    }
}