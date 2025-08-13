using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    internal class ToplantiKatilimci
    {
        public int Id { get; set; }
        public int ToplantiId { get; set; }       // Hangi toplantı
        public int KullaniciId { get; set; }      // Katılımcı kullanıcı
        public string KatilimDurumu { get; set; } = "Belirsiz"; // default
        public string Rol { get; set; } = "Katılımcı";         // default
    }
}
