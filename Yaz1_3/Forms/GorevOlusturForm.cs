using CompanyManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyManagementSystem.Models;

namespace CompanyManagementSystem.Forms
{
    public partial class GorevOlusturForm : Form
    {
        private readonly Kullanici _currentUser;
        private readonly GorevRepository _gorevRepo;
        private readonly KullaniciRepository _kullaniciRepo;
        private readonly ProjeRepository _projeRepo = new ProjeRepository();

        public GorevOlusturForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
            _gorevRepo = new GorevRepository();
            _kullaniciRepo = new KullaniciRepository();

            // Kullanıcıları comboBox’a doldur
            cmbAtananKullanici.DataSource = _kullaniciRepo.GetAll();
            cmbAtananKullanici.DisplayMember = "Ad";
            cmbAtananKullanici.ValueMember = "Id";

        }

        private void GorevOlusturForm_Load(object sender, EventArgs e)
        {
            var projeler = _projeRepo.GetAll();
            cmbProjeler.DataSource = projeler;
            cmbProjeler.DisplayMember = "Ad";
            cmbProjeler.ValueMember = "Id";
            LoadGorevler();
        }


        private void txtGorevBaslik_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGorevKaydet_Click(object sender, EventArgs e)
        {
            if (cmbProjeler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir proje seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var secilenProjeId = (int)cmbProjeler.SelectedValue;

            var yeniGorev = new Gorev
            {
                Baslik = txtGorevBaslik.Text.Trim(),
                Aciklama = txtGorevAciklama.Text.Trim(),
                BitisTarihi = dtpBitis.Value,
                Durum = "Beklemede",
                AtananKullaniciId = (int?)cmbAtananKullanici.SelectedValue, // opsiyonel
                ProjeId = secilenProjeId
            };

            try
            {
                _gorevRepo.Add(yeniGorev);
                MessageBox.Show("Görev başarıyla eklendi!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev eklenirken hata oluştu: " + ex.Message);
            }
        }




        private void LoadGorevler()
        {
            try
            {
                var gorevler = _gorevRepo.GetAll(); // Tüm görevleri çek

                // DataTable oluştur
                var dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Baslik", typeof(string));
                dt.Columns.Add("Aciklama", typeof(string));
                dt.Columns.Add("Durum", typeof(string));
                dt.Columns.Add("BitisTarihi", typeof(string));

                foreach (var g in gorevler)
                {
                    dt.Rows.Add(
                        g.Id,
                        g.Baslik,
                        g.Aciklama ?? "",
                        g.Durum ?? "",
                        g.BitisTarihi.HasValue ? g.BitisTarihi.Value.ToString("g") : ""
                    );
                }

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false; // Id görünmesin
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görevler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = new AdminMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            mainForm.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }
}
