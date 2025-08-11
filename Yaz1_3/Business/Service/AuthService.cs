using CompanyManagementSystem.Data;
using CompanyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using CompanyManagementSystem.Helpers;


namespace CompanyManagementSystem.Business.Service
{
    public class AuthService
    {
        private readonly KullaniciRepository _kullaniciRepo;

        public AuthService()
        {
            _kullaniciRepo = new KullaniciRepository();
        }

        public Kullanici? GirisYap(string email, string sifre)
        {
            var kullanici = _kullaniciRepo.GetByEmail(email);
            if (kullanici == null)
                return null; // Email yok

            //var hashlenenSifre = Hash(sifre);
            if (kullanici.SifreHash != sifre)
                return null; // Şifre yanlış

            if (kullanici.Durum == false)
                return null; // Kullanıcı pasif


            return kullanici;
        }

        public bool KullaniciYoneticiMi(Kullanici kullanici)
        {
            // Rol Id veya Rol Adına göre kontrol yapabilirsin
            return kullanici.RolId == 1; // Örnek: 1 = Yonetici
        }

        private string Hash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
