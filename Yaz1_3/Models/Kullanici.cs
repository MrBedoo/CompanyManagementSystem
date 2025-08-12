using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad {  get; set; }
        public string Email {  get; set; }
        public DateTime DogumTarihi {  get; set; }
        public char Cinsiyet {  get; set; }
        public decimal Gelir {  get; set; }
        public string SifreHash {  get; set; }
        public DateTime KayitZamani { get; set; }
        public byte[] Resim {  get; set; }
        public int YoneticiId { get; set; }   // Foreign key property // Yönetici foreign key
        public int RolId { get; set; }  // Tek rol
        public bool Durum { get; set; }
        public int FailedLoginAttempts { get; set; }      // Yeni alan
        public DateTime? LockoutEndTime { get; set; }

    }
}
