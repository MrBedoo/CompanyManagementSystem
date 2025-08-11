using CompanyManagementSystem.Business.Service;
using CompanyManagementSystem.Data;
using CompanyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string sifre = txtSifre.Text;

            var kullanici = _authService.GirisYap(email, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Email veya şifre yanlış ya da kullanıcı pasif.");
                return;
            }

            switch (kullanici.RolId)  // veya kullanici.Rol.Ad gibi string olarak da olabilir
            {
                case 1: // Yönetici
                    var adminForm = new AdminMainForm(kullanici);
                    adminForm.Show();
                    break;

                case 2: // Normal kullanıcı
                    var userForm = new UserMainForm(kullanici);
                    userForm.Show();
                    break;

                // Yeni roller için buraya ekle
                default:
                    MessageBox.Show("Tanımlanmamış rol, giriş yapılamıyor.");
                    break;
            }

            this.Hide();
        }
    }
}
