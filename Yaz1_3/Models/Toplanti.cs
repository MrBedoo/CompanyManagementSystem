using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Toplanti
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; } // Planlanan bitiş olabilir, zorunlu değil
        public string Konum { get; set; } // Fiziksel adres veya online link
        public string ToplantiTuru { get; set; } // "Online" veya "Fiziksel"
        public string Durum { get; set; } = "Planlandı"; // Varsayılan değer
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
        public int OlusturanId { get; set; } // Admin veya kullanıcı ID
        public string Adres { get; set; }
    }
}
