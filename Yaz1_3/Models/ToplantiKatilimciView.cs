using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class ToplantiKatilimciView
    {
        public int KullaniciId { get; set; }
        public string Rol { get; set; }
        public string KatilimDurumu { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
