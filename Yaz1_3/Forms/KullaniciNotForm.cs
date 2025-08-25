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
        private readonly BaseRepository<KullaniciNot> _notBaseRepo;

        public KullaniciNotForm(Kullanici hedefKullanici, Kullanici currentUser)
        {
            InitializeComponent();
            _hedefKullanici = hedefKullanici;
            _currentUser = currentUser;
            _notBaseRepo = new BaseRepository<KullaniciNot>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notMetni = txtNot.Text.Trim();
            if (string.IsNullOrEmpty(notMetni))
            {
                MessageBox.Show("Not boş olamaz!");
                return;
            }

            if (cmbNotTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen not türünü seçiniz!");
                return;
            }

            var secilenTuru = (NotTuru)cmbNotTuru.SelectedItem;

            var yeniNot = new KullaniciNot
            {
                AtananKullaniciId = _hedefKullanici.Id,   // Notu alacak kullanıcı
                GonderenId = _currentUser.Id,             // Notu gönderen kullanıcı
                NotMetni = notMetni,
                Turu = secilenTuru,
                NotTarihi = DateTime.Now
            };

            _notBaseRepo.Add(yeniNot);
            MessageBox.Show("Not başarıyla eklendi!");
            this.Close();
        }

        private void KullaniciNotForm_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = _hedefKullanici.Ad + " " + _hedefKullanici.Soyad;  // Gösterilecek kişi
            cmbNotTuru.DataSource = Enum.GetValues(typeof(NotTuru));
        }

        private void cmbNotTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
