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
    public partial class ToplantıPlanlamaForm : Form
    {

        private Kullanici _currentUser;

        private readonly ToplantiKatilimciRepository _katilimciRepo;
        private readonly KullaniciRepository _kullaniciRepo;
        private readonly BaseRepository<Toplanti> _toplantiBaseRepo;
        private readonly BaseRepository<ToplantiKatilimci> _katilimciBaseRepo;


        public ToplantıPlanlamaForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
            _katilimciRepo = new ToplantiKatilimciRepository();
            _kullaniciRepo = new KullaniciRepository();
            _toplantiBaseRepo = new BaseRepository<Toplanti>();
            _katilimciBaseRepo = new BaseRepository<ToplantiKatilimci>();

            // Tarih ve saat seçimi için ayarlar
            dtpBaslama.Format = DateTimePickerFormat.Custom;
            dtpBaslama.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpBaslama.ShowUpDown = false;

            dtpBitis.Format = DateTimePickerFormat.Custom;
            dtpBitis.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpBitis.ShowUpDown = false;


            checkedListBox1.DataSource = _kullaniciRepo.GetAll(); // Kullanıcıları çek
            checkedListBox1.DisplayMember = "Ad";  // Listede görünen isim
            checkedListBox1.ValueMember = "Id";    // Seçilen değerde Id

            LoadKatilimcilar();
            LoadToplantilar();
        }

        private void LoadToplantilar()
        {
            var toplantilar = _toplantiBaseRepo.GetAll();

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

            if (checkedListBox1.SelectedItems.Count == 0)
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
                Adres = txtAdres.Text.Trim(),
                OlusturanId = _currentUser.Id
            };

            try
            {
                // 1️⃣ Toplantıyı ekle, Add metodu Id'yi entity'ye set ediyor
                _toplantiBaseRepo.Add(yeniToplanti);

                // 2️⃣ Eklenen toplantının Id'sini al
                var toplantiId = yeniToplanti.Id;

                // 3️⃣ CheckedListBox'tan seçilen katılımcıları al
                var secilenKatilimcilar = checkedListBox1.CheckedItems
                    .Cast<Kullanici>()
                    .ToList();

                if (!secilenKatilimcilar.Any())
                {
                    MessageBox.Show("Lütfen en az bir katılımcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4️⃣ Katılımcıları veritabanına ekle
                foreach (var kullanici in secilenKatilimcilar)
                {
                    // Katılımcı entity’si
                    var katilimci = new ToplantiKatilimci
                    {
                        ToplantiId = yeniToplanti.Id,
                        KullaniciId = kullanici.Id,
                        KatilimDurumu = "Katılıyor",
                        Rol = "Katılımcı"
                    };

                    _katilimciBaseRepo.Add(katilimci);
                }

                MessageBox.Show("Katılımcılar başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5️⃣ İşlem sonrası seçimleri temizle
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);

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
            checkedListBox1.ClearSelected();
        }


        // Katılımcıları DB'den çekip lstKatilimcilar'a yükleme metodu örneği
        private void LoadKatilimcilar()
        {
            var repoKullanici = new KullaniciRepository();
            var kullanicilar = repoKullanici.GetAktifKullanicilar();
            checkedListBox1.DataSource = kullanicilar;
            checkedListBox1.DisplayMember = "AdSoyad"; // Bu property’yi Kullanici modelinde oluşturalım
            checkedListBox1.ValueMember = "Id";
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            TemizleFormu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var AdminMainForm = new AdminMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            AdminMainForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenKullanici = checkedListBox1.SelectedItem as Kullanici;

            if (secilenKullanici != null)
            {
                string isim = secilenKullanici.Ad;   // Görünen isim
                int id = secilenKullanici.Id;        // Id
                                                     // İstersen textbox veya label’a yazabilirsin

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1️⃣ Seçili toplantıyı al
            if (dgvToplantilar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen önce bir toplantı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
        }

        private void dtpBaslama_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
