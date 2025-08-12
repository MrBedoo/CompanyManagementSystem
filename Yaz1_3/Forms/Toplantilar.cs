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

namespace CompanyManagementSystem.Forms
{
    public partial class Toplantilar : Form
    {
        private readonly ToplantiRepository _toplantiRepo;
        private DataTable _dtToplantilar;

        public Toplantilar()
        {
            InitializeComponent();

            _toplantiRepo = new ToplantiRepository();

            // SplitContainer ayarları (kodla da yapabilirsiniz)
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 300; // Sol panel genişliği

            // DataGridView ayarları
            dgvToplantilar.Dock = DockStyle.Fill;
            dgvToplantilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToplantilar.MultiSelect = false;
            dgvToplantilar.AutoGenerateColumns = false;

            // Kolonlar
            dgvToplantilar.Columns.Clear();

            dgvToplantilar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Baslik",
                HeaderText = "Başlık",
                Width = 140
            });
            dgvToplantilar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AciklamaKisa",
                HeaderText = "Açıklama",
                Width = 120
            });
            dgvToplantilar.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "BaslamaTarihi",
                HeaderText = "Başlama Tarihi",
                Width = 130
            });

            dgvToplantilar.SelectionChanged += dgvToplantilar_SelectionChanged;


            LoadToplantilar();

        }

        private void LoadToplantilar()
        {
            var toplantilar = _toplantiRepo.GetToplantilar();

            // DataTable oluştur, kısa açıklama için hesaplama yap
            _dtToplantilar = new DataTable();
            _dtToplantilar.Columns.Add("Id", typeof(int));
            _dtToplantilar.Columns.Add("Baslik", typeof(string));
            _dtToplantilar.Columns.Add("AciklamaKisa", typeof(string));
            _dtToplantilar.Columns.Add("BaslamaTarihi", typeof(string));

            foreach (var t in toplantilar)
            {
                string aciklamaKisa = t.Aciklama?.Length > 30 ? t.Aciklama.Substring(0, 30) + "..." : t.Aciklama ?? "";

                _dtToplantilar.Rows.Add(
                    t.Id,
                    t.Baslik,
                    aciklamaKisa,
                    t.BaslamaTarihi.ToString("g") // genel tarih saat formatı
                );
            }

            dgvToplantilar.DataSource = _dtToplantilar;
            if (dgvToplantilar.Rows.Count > 0)
                dgvToplantilar.Rows[0].Selected = true;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvToplantilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvToplantilar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvToplantilar.SelectedRows.Count == 0)
            {
                ClearDetails();
                return;
            }

            int id = Convert.ToInt32(dgvToplantilar.SelectedRows[0].Cells["Id"].Value);

            var toplantı = _toplantiRepo.GetById(id);
            if (toplantı == null)
            {
                ClearDetails();
                return;
            }

            txtBaslik.Text = toplantı.Baslik;
            txtAciklama.Text = toplantı.Aciklama;
            txtAdres.Text = toplantı.Adres;
            txtBaslamaTarihi.Text = toplantı.BaslamaTarihi.ToString("g");
            txtBitisTarihi.Text = toplantı.BitisTarihi.HasValue ? toplantı.BitisTarihi.Value.ToString("g") : "";
            txtDurum.Text = toplantı.Durum;

        }

        private void ClearDetails()
        {
            txtBaslik.Text = "";
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtBaslamaTarihi.Text = "";
            txtBitisTarihi.Text = "";
            txtDurum.Text = "";
        }


    }
}
