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
    public partial class KullaniciNotForm : Form
    {
        private readonly Kullanici _hedefKullanici;   // Notu alacak kişi
        private readonly Kullanici _currentUser;       // Notu gönderen kişi
        private readonly KullaniciNotRepository _notRepo = new KullaniciNotRepository();

        public KullaniciNotForm(Kullanici hedefKullanici, Kullanici currentUser)
        {
            InitializeComponent();
            _hedefKullanici = hedefKullanici;
            _currentUser = currentUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notMetni = txtNot.Text.Trim();
            var secilenTuru = (NotTuru)cmbNotTuru.SelectedItem;

            if (string.IsNullOrEmpty(notMetni))
            {
                MessageBox.Show("Not boş olamaz!");
                return;
            }

            if (string.IsNullOrEmpty(cmbNotTuru.Text))
            {
                MessageBox.Show("Not türü boş olamaz!");
                return;
            }

            var yeniNot = new KullaniciNot
            {
                HedefKullaniciId = _hedefKullanici.Id,   // Notu alacak kullanıcı
                GonderenId = _currentUser.Id,             // Notu gönderen kullanıcı
                NotMetni = notMetni,
                Turu = secilenTuru,
                NotTarihi = DateTime.Now
            };

            _notRepo.Add(yeniNot);
            MessageBox.Show("Not başarıyla eklendi!");
            this.Close();
        }

        private void KullaniciNotForm_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = _hedefKullanici.AdSoyad;  // Gösterilecek kişi
            cmbNotTuru.DataSource = Enum.GetValues(typeof(NotTuru));
        }

        private void cmbNotTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
