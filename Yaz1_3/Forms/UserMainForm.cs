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
    public partial class UserMainForm : Form
    {
        private Kullanici _girisYapanKullanici;
        public UserMainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _girisYapanKullanici = kullanici;
        }




        private void btnCikis_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserToken = string.Empty;
            Properties.Settings.Default.KullaniciId = 0;
            Properties.Settings.Default.TokenGecerlilik = DateTime.MinValue;
            Properties.Settings.Default.Save();

            // Aktif oturumu sıfırla
            Program.AktifOturum = null;

            // Giriş formunu aç ve bu formu kapat
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnToplantıListesi_Click(object sender, EventArgs e)
        {

        }
    }
}
