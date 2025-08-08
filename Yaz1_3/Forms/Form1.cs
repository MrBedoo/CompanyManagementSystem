using CompanyManagementSystem.Data;
using CompanyManagementSystem.Models;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace CompanyManagementSystem
{
    public partial class KullaniciKayit : Form
    {
        private readonly KullaniciRepository _repository = new KullaniciRepository();

        public KullaniciKayit()
        {
            InitializeComponent();

            // Minimum boyut belirle
            this.MinimumSize = new Size(1000, 600);

            VerileriListele();
            AdminListele();
        }

        private byte[] secilenResim = null;

        private void VerileriListele()
        {
            var repo = new KullaniciRepository();
            var liste = repo.Listele();
            dataGridView1.DataSource = liste;

        }

        private void AdminListele()
        {
            var repoBase = new BaseRepository<Admin>();
            var adminListe = repoBase.Listele<Admin>();
            dataGridView2.DataSource = adminListe;
        }

        private void AlanlariTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
            secilenResim = null;
        }



        private void EkleGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Ad, Soyad, Email ve Şifre alanları boş bırakılamaz.");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int parsedId))
            {
                MessageBox.Show("Geçerli bir ID giriniz.");
                return;
            }

            if (!decimal.TryParse(textBox4.Text, out decimal gelir))
            {
                MessageBox.Show("Geçerli bir gelir değeri giriniz.");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.");
                return;
            }

            
            var repo = new BaseRepository<Kullanici>();

            // Id 0 veya daha küçükse yeni kayıt
            bool yeniKayit = parsedId <= 0;

            if (!yeniKayit)
            {
                // Güncelleme için, Id veritabanında var mı kontrol et
                var mevcut = repo.GetById(parsedId);
                if (mevcut == null)
                {
                    MessageBox.Show("Geçersiz Id girdiniz.");
                    return;
                }
            }

            var kullanici = new Kullanici
            {
                Id = parsedId,
                Ad = textBox1.Text,
                Soyad = textBox2.Text,
                Email = textBox3.Text,
                DogumTarihi = dateTimePicker1.Value,
                Cinsiyet = comboBox1.SelectedItem.ToString()[0], // E/K gibi
                Gelir = gelir,
                Sifre = textBox5.Text,
                Resim = secilenResim
            };

            var repoKullanici = new KullaniciRepository();

            if (repoKullanici.BaskaKullanicidaVarMi(kullanici))
            {
                MessageBox.Show("Aynı ad, soyad veya email başka bir kullanıcıya ait.");
                return;
            }

            if (kullanici.Gelir > 1000000)
            {
                MessageBox.Show("Gelir en fazla 1.000.000 olabilir.");
                return;
            }

            var repoBase = new BaseRepository<Kullanici>();
            var result = repoBase.RunInsertOrUpdate(kullanici);

            if (result == 1)
                MessageBox.Show("Güncelleme başarılı.");
            else if (result == 0)
                MessageBox.Show("Yeni kullanıcı eklendi.");
            else if (result == -1)
                MessageBox.Show("ID veritabanında bulunamadı. Güncelleme yapılamadı.");
            else
                MessageBox.Show("Bir hata oluştu.");

            AlanlariTemizle();
            VerileriListele();
        }





        private void ResimYükle_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                secilenResim = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {


            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Silmek için lütfen kullanıcı seçiniz");
                return;
            }

            var result = MessageBox.Show("Seçilen kullanıcı silinecek, emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            try
            {
                _repository.sil(secilenId);
                MessageBox.Show("Kullanıcı silindi.");
                VerileriListele();
                AlanlariTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Renk ayarları
            Temizle.BackColor = Color.IndianRed;
            Temizle.ForeColor = Color.White;

            EkleGuncelle.BackColor = Color.Green;
            EkleGuncelle.ForeColor = Color.White;

            textBox6.BackColor = Color.WhiteSmoke;
            textBox6.ForeColor = Color.Black;

            this.BackColor = Color.FromArgb(255, 253, 208);

            // Buton görsel ayarları

            EkleGuncelle.FlatStyle = FlatStyle.Flat;
            EkleGuncelle.FlatAppearance.BorderSize = 0;

            Temizle.FlatStyle = FlatStyle.Flat;
            Temizle.FlatAppearance.BorderSize = 0;

            // Tooltip
            System.Windows.Forms.ToolTip t = new System.Windows.Forms.ToolTip();
            t.SetToolTip(Temizle, "Seçilen kullanıcıyı silin");

        }


        private void KullaniciBilgileriniDoldur(Kullanici kullanici)
        {
            textBox1.Text = kullanici.Ad;
            textBox2.Text = kullanici.Soyad;
            textBox3.Text = kullanici.Email;
            textBox4.Text = kullanici.Gelir.ToString();
            textBox5.Text = kullanici.Sifre;

            comboBox1.SelectedItem = kullanici.Cinsiyet == 'E' ? "Erkek" : "Kadın";

            dateTimePicker1.Value = kullanici.DogumTarihi;

            if (kullanici.Resim != null)
            {
                using var ms = new MemoryStream(kullanici.Resim);
                pictureBox1.Image = Image.FromStream(ms);

                secilenResim = kullanici.Resim;
            }
            else
            {
                pictureBox1.Image = null; // resim yoksa temizle
                secilenResim = null;
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                var repo = new BaseRepository<Kullanici>();

                if (int.TryParse(textBox6.Text, out int secilenId))
                {
                    var kullanici = repo.GetById(secilenId);

                    if (kullanici == null)
                    {
                        MessageBox.Show("Bu Id'ye sahip bir kullanıcı bulunmamaktadır.");

                        AlanlariTemizle();
                    }
                    else
                    {
                        KullaniciBilgileriniDoldur(kullanici);
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ID girin.");
                }
            }
        }



        private void KullaniciDoldur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                var repo = new BaseRepository<Kullanici>();

                if (int.TryParse(textBox6.Text, out int secilenId))
                {
                    var kullanici = repo.GetById(secilenId);

                    if (kullanici == null)
                    {
                        MessageBox.Show("Bu Id ye  sahip bir kullanıcı bulunmamaktadır lütfen tekrar kontrol ediniz.");
                        AlanlariTemizle();
                    }
                    else
                    {
                        KullaniciBilgileriniDoldur(kullanici);
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir ID girin.");
                }
            }
        }


        private bool AlanlarGecerliMi(out decimal gelir)
        {
            gelir = 0;

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                comboBox1.SelectedIndex == -1 ||
                secilenResim == null)
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.");
                return false;
            }

            if (!decimal.TryParse(textBox4.Text, out gelir))
            {
                MessageBox.Show("Gelir sayısal olmalıdır.");
                return false;
            }

            if (gelir < 0 || gelir > 1000000)
            {
                MessageBox.Show("Gelir 0 ile 1.000.000 arasında olmalıdır.");
                return false;
            }

            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                //textBox6.Text = id.ToString(); // ID'yi kutuya yaz

                var repo = new BaseRepository<Kullanici>();
                var kullanici = repo.GetById(id);

                if (kullanici != null)
                {
                    KullaniciBilgileriniDoldur(kullanici);
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ad, Soyad ve Email alanları boş bırakılamaz.");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int parsedId))
            {
                MessageBox.Show("Geçerli bir ID giriniz.");
                return;
            }

            var repo = new BaseRepository<Admin>();

            bool yeniKayit = parsedId <= 0;

            if (!yeniKayit)
            {
                var mevcut = repo.GetById(parsedId);
                if (mevcut == null)
                {
                    MessageBox.Show("Geçersiz Id girdiniz.");
                    return;
                }
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.");
                return;
            }

            string secilenCinsiyet = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(secilenCinsiyet))
            {
                MessageBox.Show("Geçerli bir cinsiyet seçiniz.");
                return;
            }


            var admin = new Admin
            {
                Ad = textBox1.Text,
                Soyad = textBox2.Text,
                DogumTarihi = dateTimePicker1.Value,
                Cinsiyet = comboBox1.SelectedItem.ToString()[0],
                Email = textBox3.Text,
                Sifre = textBox5.Text,
                Gelir = decimal.Parse(textBox4.Text),
                Resim = null
            };

            var repoAdmin = new AdminRepository();

            if (repoAdmin.BaskaAdmindeVarMi(admin))
            {
                MessageBox.Show("Aynı ad, soyad veya email başka bir kullanıcıya ait.");
                return;
            }

            var repoBase = new BaseRepository<Admin>();
            var result = repoBase.RunInsertOrUpdate(admin);

            if (result == 1)
                MessageBox.Show("Güncelleme başarılı.");
            else if (result == 0)
                MessageBox.Show("Yeni admin eklendi.");
            else if (result == -1)
                MessageBox.Show("ID veritabanında bulunamadı. Güncelleme yapılamadı.");
            else
                MessageBox.Show("Bir hata oluştu.");

            AlanlariTemizle();
            AdminListele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



