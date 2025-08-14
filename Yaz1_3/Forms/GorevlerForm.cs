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
        private readonly UserMainForm _anasayfa;
        private readonly GorevRepository _gorevRepo = new GorevRepository();

        public GorevlerForm(Kullanici kullanici, UserMainForm anasayfa)
        {
            InitializeComponent();
            _currentUser = kullanici;
            _anasayfa = anasayfa;
            LoadGorevler();

        }




        private void LoadGorevler()
        {
            var gorevler = _gorevRepo.GetByAtananKullaniciId(_currentUser.Id);

            var devamEden = gorevler.Where(g => g.Durum != "Tamamlandı").ToList();
            dgvDevamEden.DataSource = devamEden;
            dgvDevamEden.Columns["Id"].Visible = false;
        }

        private int seciliGorevId;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvDevamEden.CurrentRow == null) return;

            var seciliGorev = (Gorev)dgvDevamEden.CurrentRow.DataBoundItem;

            // Ana sayfadaki _anasayfaGorev'e ata ve textboxları güncelle
            _anasayfa.SetAnasayfaGorev(seciliGorev);

            MessageBox.Show("Görev anasayfada gösterilecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UserMainForm1 = new UserMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            UserMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }

        private void GorevlerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
