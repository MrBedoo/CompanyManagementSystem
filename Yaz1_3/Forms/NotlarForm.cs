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
    public partial class NotlarForm : Form
    {
        private readonly KullaniciNotRepository _notRepo = new KullaniciNotRepository();
        private readonly KullaniciRepository _kullaniciRepo = new KullaniciRepository();
        private List<KullaniciNot> _tumNotlar;
        private readonly Kullanici _currentUser;
        private List<KullaniciNot> _girisKullaniciNotlari;

        public NotlarForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici; // Oturum açan kullanıcıyı sakla
        }


        private void LoadNotlar()
        {
            _tumNotlar = _notRepo.GetAll();

            _girisKullaniciNotlari = _tumNotlar
                .Where(n => n.HedefKullaniciId == _currentUser.Id)
                .ToList();

            dgvNotlar.DataSource = _girisKullaniciNotlari.Select(n => new
            {
                n.Id,
                n.GonderenId,
                n.HedefKullaniciId,
                Turu = n.Turu.ToString(),
                NotTarihi = n.NotTarihi.ToString("g"),
                NotOzet = string.IsNullOrEmpty(n.NotMetni)
                            ? ""
                            : (n.NotMetni.Length > 50 ? n.NotMetni.Substring(0, 50) + "..." : n.NotMetni)
            }).ToList();

            dgvNotlar.Columns["Id"].Visible = false;
            dgvNotlar.Columns["GonderenId"].Visible = false;
            dgvNotlar.Columns["HedefKullaniciId"].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var UserMainForm1 = new UserMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            UserMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNotlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.RowIndex >= _girisKullaniciNotlari.Count) return;

            //var secilenNot = _girisKullaniciNotlari[e.RowIndex];

            //txtNotMetni.Text = secilenNot.NotMetni;
            //txtNotTarihi.Text = secilenNot.NotTarihi.ToString("g");
            //txtNotTuru.Text = secilenNot.Turu.ToString(); // <- buraya ekle

            //var gonderen = _kullaniciRepo.GetById(secilenNot.GonderenId);
            //lblGonderen.Text = gonderen != null ? gonderen.AdSoyad : "Bilinmiyor";

        }

        private void NotlarForm_Load(object sender, EventArgs e)
        {
            LoadNotlar();
            dgvNotlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotlar.MultiSelect = false;

            dgvNotlar.CellDoubleClick += dgvNotlar_CellDoubleClick;
        }
    }
}
