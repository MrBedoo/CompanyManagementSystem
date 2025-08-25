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
    public partial class KullaniciNotListeForm : Form
    {
        private List<Kullanici> _tumKullanicilar; // Sadece bu olacak
        private readonly KullaniciRepository _kullaniciRepo = new KullaniciRepository();
        private readonly Kullanici _currentUser;


        public KullaniciNotListeForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici; // Oturum açan kullanıcıyı sakla
        }

        private void LoadKullanicilar()
        {
            _tumKullanicilar = _kullaniciRepo.GetAll();
            dgvKullanicilar.DataSource = _tumKullanicilar;
        }


        private void Filtrele()
        {
            string filtre = txtArama.Text.ToLower();
            var filtreliListe = _tumKullanicilar
                .Where(k => ($"{k.Ad} {k.Soyad}").ToLower().Contains(filtre))
                .ToList();

            dgvKullanicilar.DataSource = filtreliListe;
        }

        private void dataGridViewKullanicilar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var secilenKullanici = (Kullanici)dgvKullanicilar.Rows[e.RowIndex].DataBoundItem;
            if (secilenKullanici != null)
            {
                var notForm = new KullaniciNotForm(secilenKullanici, _currentUser);
                notForm.ShowDialog();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void KullaniciNotListeForm_Load(object sender, EventArgs e)
        {
            LoadKullanicilar();
            txtArama.TextChanged += (s, ev) => Filtrele();

            var btnCol = new DataGridViewButtonColumn
            {
                HeaderText = "İşlem",
                Text = "Not Gönder",
                UseColumnTextForButtonValue = true
            };
            dgvKullanicilar.Columns.Add(btnCol);
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Başlığa veya boş alana tıklanmışsa çık

            if (dgvKullanicilar.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var secilenKullanici = (Kullanici)dgvKullanicilar.Rows[e.RowIndex].DataBoundItem;
                if (secilenKullanici != null)
                {
                    var notForm = new KullaniciNotForm(secilenKullanici, _currentUser);
                    notForm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AdminMainForm1 = new AdminMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            AdminMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }
}
