using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    internal class Admin
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public char Cinsiyet { get; set; }
        public decimal Gelir { get; set; }
        public string Sifre { get; set; }
        public DateTime KayitTarihi { get; set; }
        public byte[] Resim { get; set; }
    }
}
