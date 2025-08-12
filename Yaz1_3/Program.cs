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

            if (!string.IsNullOrEmpty(token) && kullaniciId > 0 && gecerlilik > DateTime.Now)
            {
                var kullaniciRepo = new KullaniciRepository();
                var kullanici = kullaniciRepo.GetById(kullaniciId);
                if (kullanici != null)
                {
                    AktifOturum = new Oturum
                    {
                        KullaniciId = kullanici.Id,
                        KullaniciAdi = kullanici.Ad,
                        GecerlilikTarihi = gecerlilik
                    };
                    Application.Run(new AdminMainForm(kullanici));
                    return;
                }
            }

            Application.Run(new LoginForm());

        }
    }
}