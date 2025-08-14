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
        private Kullanici _currentUser;

        public AdminMainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new KullaniciKayit(_currentUser);
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var toplantiForm = new ToplantıPlanlama(_currentUser);
            toplantiForm.Show();

            this.Hide();
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

        private void btnToplantilar_Click(object sender, EventArgs e)
        {
            var toplantiForm = new Toplantilar(_currentUser);  // Yeni açmak istediğin formun ismi
            toplantiForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();                 // Mevcut formu gizler
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var gorevForm = new GorevOlusturForm(_currentUser);  // Yeni açmak istediğin formun ismi
            gorevForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var adminForm = new ProjeOlusturForm(_currentUser);  // Yeni açmak istediğin formun ismi
            adminForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var NotForm = new KullaniciNotu();  // Yeni açmak istediğin formun ismi
            NotForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }
}
