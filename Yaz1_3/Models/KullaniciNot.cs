using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{

    public enum NotTuru
    {
        Gorev,
        Proje,
        Toplanti,
        Gunluk,
        Uyari,
        Diger
    }

    internal class KullaniciNot
    {
        public int Id { get; set; }
        public int GonderenId { get; set; }        // Notu gönderen kullanıcı
        public int HedefKullaniciId { get; set; } // Notu alan kullanıcı
        public DateTime NotTarihi { get; set; }
        public string NotMetni { get; set; }
        public NotTuru Turu { get; set; } // Enum
    }
}
