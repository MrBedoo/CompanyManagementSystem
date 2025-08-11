using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }

        // İstersen yetkiler JSON veya başka şekilde tutulabilir
        public string YetkilerJson { get; set; }
    }
}
