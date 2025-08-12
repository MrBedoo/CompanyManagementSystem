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
    public partial class ToplantıPlanlama : Form
    {
        private ToplantiRepository _repo;

        public ToplantıPlanlama()
        {
            InitializeComponent();

            _repo = new ToplantiRepository();

            LoadKatilimcilar();
            LoadToplantilar();
        }

        private void LoadToplantilar()
        {
            var toplantilar = _repo.GetToplantilar();

            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Baslik");
            dt.Columns.Add("AciklamaOzeti");
            dt.Columns.Add("BaslamaTarihi");

            foreach (var t in toplantilar)
            {
                string aciklamaOzet = t.Aciklama.Length > 30 ? t.Aciklama.Substring(0, 30) + "..." : t.Aciklama;
                dt.Rows.Add(t.Id, t.Baslik, aciklamaOzet, t.BaslamaTarihi.ToString("dd.MM.yyyy HH:mm"));
            }

            dgvToplantilar.DataSource = dt;

            dgvToplantilar.Columns["Id"].Visible = false; // İstersen gizle
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Validasyon
            if (string.IsNullOrWhiteSpace(txtBaslik.Text))
            {
                MessageBox.Show("Başlık boş olamaz!");
                return;
            }

            if (cmbToplantiTuru.SelectedIndex < 0)
            {
                MessageBox.Show("Toplantı türünü seçiniz!");
                return;
            }

            if (dtpBitis.Value <= dtpBaslama.Value)
            {
                MessageBox.Show("Bitiş tarihi başlangıçtan önce olamaz!");
                return;
            }

            if (lstKatilimcilar.SelectedItems.Count == 0)
            {
                MessageBox.Show("En az bir katılımcı seçiniz!");
                return;
            }

            var yeniToplanti = new Toplanti
            {
                Baslik = txtBaslik.Text.Trim(),
                Aciklama = txtAciklama.Text.Trim(),
                BaslamaTarihi = dtpBaslama.Value,
                BitisTarihi = dtpBitis.Value,
                ToplantiTuru = cmbToplantiTuru.SelectedItem.ToString(),
                Adres = txtAdres.Text.Trim()
            };

            try
            {
                _repo.Add(yeniToplanti);

                // Katılımcıları eklemek için ayrı bir metot yazabilirsiniz, örn: _repo.AddKatilimcilar(yeniToplanti.Id, seçilenKatılımcılar)

                MessageBox.Show("Toplantı başarıyla kaydedildi!");

                TemizleFormu();
                LoadToplantilar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message);
            }
        }

        
        private void TemizleFormu()
        {
            txtBaslik.Clear();
            txtAciklama.Clear();
            dtpBaslama.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now;
            cmbToplantiTuru.SelectedIndex = -1;
            txtAdres.Clear();
            lstKatilimcilar.ClearSelected();
        }


        // Katılımcıları DB'den çekip lstKatilimcilar'a yükleme metodu örneği
        private void LoadKatilimcilar()
        {
            var repoKullanici = new KullaniciRepository();
            var kullanicilar = repoKullanici.GetAktifKullanicilar();
            lstKatilimcilar.DataSource = kullanicilar;
            lstKatilimcilar.DisplayMember = "AdSoyad"; // Bu property’yi Kullanici modelinde oluşturalım
            lstKatilimcilar.ValueMember = "Id";
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            TemizleFormu();
        }
    }
}
