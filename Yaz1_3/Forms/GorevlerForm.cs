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
    public partial class GorevlerForm : Form
    {
        private readonly Kullanici _currentUser;
        private readonly GorevRepository _gorevRepo = new GorevRepository();

        public GorevlerForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
            LoadGorevler();

        }


        private void LoadGorevler()
        {
            var gorevler = _gorevRepo.GetByAtananKullaniciId(_currentUser.Id);

            var devamEden = gorevler.Where(g => g.Durum != "Tamamlandı").ToList();
            dgvDevamEden.DataSource = devamEden;
            dgvDevamEden.Columns["Id"].Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            var UserMainForm1 = new UserMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            UserMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void GorevlerForm_Load(object sender, EventArgs e)
        {
            cmbGorevDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGorevDurum.Items.AddRange(new string[] { "Beklemede", "Devam Ediyor", "Tamamlandı" });

            dgvDevamEden.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevamEden.MultiSelect = false; // İstersen tek satır seçimi

        }

        private void dgvDevamEden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDevamEden_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDevamEden.CurrentRow == null) return;
            Gorev seciliGorev = (Gorev)dgvDevamEden.CurrentRow.DataBoundItem;

            txtGorevBaslik.Text = seciliGorev.Baslik;
            txtGorevAciklama.Text = seciliGorev.Aciklama;
            txtGorevOncelik.Text = seciliGorev.Oncelik ?? "Belirtilmemiş";
            txtGorevBaslama.Text = seciliGorev.OlusturmaTarihi.ToString("g");
            txtGorevBitis.Text = seciliGorev.BitisTarihi.HasValue ? seciliGorev.BitisTarihi.Value.ToString("g") : "Belirtilmemiş";
            txtGorevMesaj.Text = seciliGorev.Mesaj ?? "Belirtilmemiş";
            txtGorevRapor.Text = seciliGorev.Rapor ?? "";
            cmbGorevDurum.SelectedItem = seciliGorev.Durum ?? "Beklemede"; // Varsayılan olarak "Beklemede" seçili olsun

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (dgvDevamEden.CurrentRow == null) return;
            Gorev seciliGorev = (Gorev)dgvDevamEden.CurrentRow.DataBoundItem;

            seciliGorev.Rapor = txtGorevRapor.Text;
            seciliGorev.Durum = cmbGorevDurum.Text;

            _gorevRepo.Update(seciliGorev);

            MessageBox.Show("Görev Raporu ve Durumu güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGorevler(); // Güncellemeleri yansıtmak için görevleri yeniden yükle


        }
    }
}
