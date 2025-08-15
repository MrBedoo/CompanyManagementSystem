using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Gorev
    {
        public int Id { get; set; }
        public int ProjeId { get; set; }
        public int? AtananKullaniciId { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Mesaj { get; set; }
        public string Rapor { get; set; }
        public string Durum { get; set; }
        public string Oncelik { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
    }
}
