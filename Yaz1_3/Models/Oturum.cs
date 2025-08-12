using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Oturum
    {
        public string Token { get; set; }   
        public DateTime GecerlilikTarihi { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
    }
}
