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
    public partial class ProjeOlusturForm : Form
    {
        private readonly ProjeRepository _projeRepo;
        private readonly KullaniciRepository _kullaniciRepo;
        private readonly Kullanici _currentUser;

        public ProjeOlusturForm(Kullanici kullanici)
        {
            InitializeComponent();
            _projeRepo = new ProjeRepository();
            _kullaniciRepo = new KullaniciRepository();
            _currentUser = kullanici;
        }

        private void ProjeOlusturForm_Load(object sender, EventArgs e)
        {
            YoneticileriYukle();  // combobox doldurma metodu
            ProjeleriListele();

            try
            {
                // RolId = 1 olan yöneticileri çek
                var yoneticiler = _kullaniciRepo.GetAll()
                                                .Where(k => k.RolId == 1)  // sadece yöneticiler
                                                .Select(k => new { k.Id, k.Ad })
                                                .ToList();

                // ComboBox'a bağla
                cmbProjeLider.DataSource = yoneticiler;
                cmbProjeLider.DisplayMember = "Ad";   // ComboBox'ta görünen isim
                cmbProjeLider.ValueMember = "Id";     // Seçilenin Id'si
                cmbProjeLider.SelectedIndex = -1;     // Başlangıçta boş

            }
            catch (Exception ex)
            {
                MessageBox.Show("Yöneticiler yüklenirken hata oluştu: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProjeBaslik.Text))
            {
                MessageBox.Show("Proje adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbProjeLider.SelectedValue == null)
            {
                MessageBox.Show("Bir yönetici seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var proje = new Proje
            {
                Ad = txtProjeBaslik.Text.Trim(),
                Aciklama = txtProjeAciklama.Text.Trim(),
                BaslangicTarihi = dtpProjeBaslangic.Value,
                BitisTarihi = dtpProjeBitis.Value,
                Durum = "Aktif",
                YoneticiId = Convert.ToInt32(cmbProjeLider.SelectedValue)
            };

            try
            {
                _projeRepo.Add(proje);

                MessageBox.Show("Proje başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TemizleFormu();
                ProjeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje ekleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjeleriListele()
        {
            var projeler = _projeRepo.GetAll()
                .Select(p => new
                {
                    p.Id,
                    p.Ad,
                    p.Aciklama,
                    p.BaslangicTarihi,
                    p.BitisTarihi,
                    ProjeLider = _kullaniciRepo.GetById(p.YoneticiId)?.Ad
                })
                .ToList();

            dataGridView1.DataSource = projeler;
        }


        private void YoneticileriYukle()
        {
            try
            {
                // RolId = 1 olan yöneticileri çek
                var yoneticiler = _kullaniciRepo.GetAll()
                                                .Where(k => k.RolId == 1)  // sadece yöneticiler
                                                .Select(k => new { k.Id, k.Ad })
                                                .ToList();

                // ComboBox'a bağla
                cmbProjeLider.DataSource = yoneticiler;
                cmbProjeLider.DisplayMember = "Ad";   // ComboBox'ta görünen isim
                cmbProjeLider.ValueMember = "Id";     // Seçilenin Id'si
                cmbProjeLider.SelectedIndex = -1;     // Başlangıçta boş

            }
            catch (Exception ex)
            {
                MessageBox.Show("Yöneticiler yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void TemizleFormu()
        {
            txtProjeBaslik.Text = "";
            txtProjeAciklama.Text = "";
            dtpProjeBaslangic.Value = DateTime.Now;
            dtpProjeBitis.Value = DateTime.Now;
            cmbProjeLider.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            adminForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }
}
