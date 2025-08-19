using CompanyManagementSystem.Business.Service;
using CompanyManagementSystem.Data;
using CompanyManagementSystem.Forms;
using CompanyManagementSystem.Models;

namespace CompanyManagementSystem
{
    internal static class Program
    {
        public static Oturum AktifOturum { get; set; }


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var token = Properties.Settings.Default.UserToken;
            var kullaniciId = Properties.Settings.Default.KullaniciId;
            var gecerlilik = Properties.Settings.Default.TokenGecerlilik;

            // Debug için yazd?r
            Console.WriteLine($"Token: {token}");
            Console.WriteLine($"KullaniciId: {kullaniciId}");
            Console.WriteLine($"Gecerlilik: {gecerlilik}");


            Form anaForm = null;

            // Oturum geçerli mi kontrol et
            if (!string.IsNullOrEmpty(token) && kullaniciId > 0 && gecerlilik > DateTime.Now)
            {
                var kullaniciRepo = new BaseRepository<Kullanici>();
                var kullanici = kullaniciRepo.GetById(kullaniciId);

                if (kullanici != null)
                {
                    AktifOturum = new Oturum
                    {
                        KullaniciId = kullanici.Id,
                        KullaniciAdi = kullanici.Ad,
                        GecerlilikTarihi = gecerlilik
                    };

                    // Rol bazlý form aç
                    if (kullanici.RolId == 1)
                        anaForm = new AdminMainForm(kullanici);
                    else
                        anaForm = new UserMainForm(kullanici);
                }
            }

            // Oturum yoksa login formunu aç
            if (anaForm == null)
                anaForm = new LoginForm();

            //Form anaForm = new KullaniciKayit();
            Application.Run(anaForm);

        }
    }
}