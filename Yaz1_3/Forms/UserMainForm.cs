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
        private Kullanici _currentUser;
        private Gorev _anasayfaGorev;

        public UserMainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;

            // Kullanıcının atanan görevlerini al
            var gorev = _currentUser.AtananGorevler.FirstOrDefault();
            if (gorev != null)
            {
                txtGorevBaslik.Text = gorev.Baslik;
                txtGorevAciklama.Text = gorev.Aciklama;
                txtGorevBitisTarihi.Text = gorev.BitisTarihi?.ToString("g") ?? "";
            }
            else
            {
                txtGorevBaslik.Text = "";
                txtGorevAciklama.Text = "";
                txtGorevBitisTarihi.Text = "";
            }

        }

        public void SetAnasayfaGorev(Gorev gorev)
        {
            _anasayfaGorev = gorev;

            txtGorevBaslik.Text = _anasayfaGorev.Baslik;
            txtGorevAciklama.Text = _anasayfaGorev.Aciklama;
            txtGorevBitisTarihi.Text = _anasayfaGorev.BitisTarihi?.ToString("g") ?? "";
        }



        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Oturumu sıfırla
            Properties.Settings.Default.UserToken = string.Empty;
            Properties.Settings.Default.KullaniciId = 0;
            Properties.Settings.Default.TokenGecerlilik = DateTime.MinValue;
            Properties.Settings.Default.Save();

            Program.AktifOturum = null;

            // Login formunu aç ve mevcut formu kapat
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnToplantıListesi_Click(object sender, EventArgs e)
        {
            var toplantiForm = new ToplantilarForm(_currentUser);  // Yeni açmak istediğin formun ismi
            toplantiForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();                 // Mevcut formu gizler
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // UserMainForm'dan Gorevler formunu aç
            var gorevlerForm = new GorevlerForm(_currentUser, this); // this = UserMainForm referansı
            gorevlerForm.Show(); // Show() ile formu aç

            this.Hide(); // Mevcut formu gizle
        }
    }
}
