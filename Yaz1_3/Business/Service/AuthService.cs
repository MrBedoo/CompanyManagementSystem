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
        private const int MAX_FAILED_ATTEMPTS = 5;
        private static readonly TimeSpan LOCKOUT_DURATION = TimeSpan.FromMinutes(15);

        public AuthService()
        {
            _kullaniciRepo = new KullaniciRepository();
        }

        public (Kullanici? kullanici, string? hataMesaji) GirisYap(string email, string sifre)
        {
            var kullanici = _kullaniciRepo.GetByEmail(email);
            if (kullanici == null)
                return (null, "Kullanıcı bulunamadı.");

            if (kullanici.LockoutEndTime.HasValue && kullanici.LockoutEndTime.Value > DateTime.Now)
            {
                var kalanSure = kullanici.LockoutEndTime.Value - DateTime.Now;
                return (null, $"Hesabınız {Math.Ceiling(kalanSure.TotalMinutes)} dakika kilitli.");
            }

            // Şifreyi hash'le karşılaştır
            var hashlenenSifre = Hash(sifre);
            if (kullanici.SifreHash != hashlenenSifre)
            {
                _kullaniciRepo.IncrementFailedLoginAttempts(kullanici.Id);

                kullanici = _kullaniciRepo.GetByEmail(email); // Güncel değerleri al
                if (kullanici.FailedLoginAttempts >= MAX_FAILED_ATTEMPTS)
                {
                    var lockoutEnd = DateTime.Now.Add(LOCKOUT_DURATION);
                    _kullaniciRepo.SetLockout(kullanici.Id, lockoutEnd);
                    return (null, $"Çok fazla başarısız giriş. Hesabınız {LOCKOUT_DURATION.TotalMinutes} dakika kilitlendi.");
                }

                return (null, "Yanlış şifre.");
            }

            if (kullanici.Durum == false)
                return (null, "Kullanıcı pasif durumda.");

            // Başarılı giriş: deneme sayısını sıfırla ve kilidi kaldır
            _kullaniciRepo.ResetFailedLoginAttempts(kullanici.Id);

            return (kullanici, null);
        }

       

        public string Hash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
