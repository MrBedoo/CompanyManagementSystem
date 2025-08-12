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
using static System.Windows.Forms.DataFormats;
using CompanyManagementSystem;
using CompanyManagementSystem.Forms;


namespace CompanyManagementSystem.Forms
{
    public partial class AdminMainForm : Form
    {
        private Kullanici _girisYapanKullanici;

        public AdminMainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _girisYapanKullanici = kullanici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new KullaniciKayit();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var toplantiForm = new ToplantıPlanlama();
            toplantiForm.Show();

            this.Hide();
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
    }
}
