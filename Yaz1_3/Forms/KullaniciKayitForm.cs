using CompanyManagementSystem.Data;
using CompanyManagementSystem.Models;
using System.IO;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CompanyManagementSystem.Business.Service;
using CompanyManagementSystem.Forms;


namespace CompanyManagementSystem
{
    public partial class KullaniciKayit : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly KullaniciRepository _repository = new KullaniciRepository();
        private Kullanici _currentUser;


        public KullaniciKayit(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Minimum boyut belirle
            this.MinimumSize = new Size(1000, 600);

            VerileriListele();
            AdminListele();
        }

        private byte[] secilenResim = null;

        private void VerileriListele()
        {
            var repoBase = new BaseRepository<Kullanici>();
            var kullaniciListe = repoBase.Listele<Kullanici>();
            dataGridView1.DataSource = kullaniciListe;

        }

        private void AdminListele()
        {
            var repoBase = new BaseRepository<Yonetici>();
            var yoneticiListe = repoBase.Listele<Yonetici>();
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

            if (gelir > 1000000)
            {
                MessageBox.Show("Gelir alanı en fazla 1 milyon değerindedir.");
                return;
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
                SifreHash = _authService.Hash(textBox5.Text),
                Resim = secilenResim
            };



            var repoBase = new BaseRepository<Kullanici>();
            var result = repoBase.RunInsertOrUpdate(kullanici);

            if (result == 1)
                MessageBox.Show("Güncelleme başarılı.");
            else if (result == 0)
                MessageBox.Show("Yeni kullanıcı eklendi.");
            else if (result == -1)
                MessageBox.Show("ID veritabanında bulunamadı. Güncelleme yapılamadı.");
            else if (result == -2)
                MessageBox.Show("Aynı ad, soyad veya email başka bir kullanıcıya ait.");
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
            MessageBox.Show($"Kullanıcı seçili satır sayısı: {dataGridView1.SelectedRows.Count}\n");

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var repo = new BaseRepository<Kullanici>();
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                repo.Sil<Kullanici>(id);
                MessageBox.Show("Kullanıcı silindi.");
                VerileriListele();
                AlanlariTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir satır seçiniz.");
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

            this.BackColor = Color.LightBlue;

            // Buton görsel ayarları

            EkleGuncelle.FlatStyle = FlatStyle.Flat;
            EkleGuncelle.FlatAppearance.BorderSize = 0;

            Temizle.FlatStyle = FlatStyle.Flat;
            Temizle.FlatAppearance.BorderSize = 0;

            // Tooltip
            System.Windows.Forms.ToolTip t = new System.Windows.Forms.ToolTip();
            t.SetToolTip(Temizle, "Seçilen kullanıcıyı silin");

        }


        private void BilgileriDoldur<T>(T entity) where T : class
        {
            var type = typeof(T);

            foreach (var prop in type.GetProperties())
            {
                var propName = prop.Name;
                var value = prop.GetValue(entity);

                switch (propName)
                {
                    case "Id":
                        textBox6.Text = value?.ToString() ?? "";
                        break;
                    case "Ad":
                        textBox1.Text = value?.ToString() ?? "";
                        break;
                    case "Soyad":
                        textBox2.Text = value?.ToString() ?? "";
                        break;
                    case "Email":
                        textBox3.Text = value?.ToString() ?? "";
                        break;
                    case "Gelir":
                        textBox4.Text = value?.ToString() ?? "";
                        break;
                    case "Sifre":
                        textBox5.Text = value?.ToString() ?? "";
                        break;
                    case "Cinsiyet":
                        if (value is char c)
                            comboBox1.SelectedItem = c == 'E' ? "Erkek" : "Kadın";
                        break;
                    case "DogumTarihi":
                        if (value is DateTime dt)
                            dateTimePicker1.Value = dt;
                        break;
                    case "Resim":
                        if (value is byte[] bytes && bytes.Length > 0)
                        {
                            using var ms = new MemoryStream(bytes);
                            pictureBox1.Image = Image.FromStream(ms);
                            secilenResim = bytes;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            secilenResim = null;
                        }
                        break;

                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                textBox6.Text = id.ToString(); // ID'yi kutuya yaz

                var repo = new BaseRepository<Kullanici>();
                var kullanici = repo.GetById(id);

                if (kullanici != null)
                {
                    BilgileriDoldur<Kullanici>(kullanici);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

       

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var AdminMainForm1 = new AdminMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            AdminMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }

}



