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
        private Oturum _aktifOturum;
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (kullanici, hata) = _authService.GirisYap(txtEmail.Text, txtSifre.Text);

            if (hata != null)
            {
                MessageBox.Show(hata, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Başarılı giriş
            Program.AktifOturum = new Oturum
            {
                KullaniciId = kullanici.Id,
                KullaniciAdi = kullanici.Ad,
                GecerlilikTarihi = DateTime.Now.AddHours(8) // 8 saat geçerli olsun
            };

            // Gerekirse Settings’e kaydet
            Properties.Settings.Default.UserToken = Guid.NewGuid().ToString();
            Properties.Settings.Default.KullaniciId = kullanici.Id;
            Properties.Settings.Default.TokenGecerlilik = Program.AktifOturum.GecerlilikTarihi;
            Properties.Settings.Default.Save();

            // Rol kontrolü ve sayfa yönlendirme
            switch (kullanici.RolId)
            {
                case 1: // Admin
                    var adminForm = new AdminMainForm(kullanici);
                    adminForm.Show();
                    break;
                case 2: // Normal kullanıcı
                    var userForm = new UserMainForm(kullanici);
                    userForm.Show();
                    break;
                default:
                    MessageBox.Show("Rol tanımlanamıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            this.Hide();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
