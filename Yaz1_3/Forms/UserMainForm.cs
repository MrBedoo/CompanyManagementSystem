using CompanyManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem.Forms
{
    public partial class UserMainForm : Form
    {
        private Kullanici _girisYapanKullanici;
        public UserMainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _girisYapanKullanici = kullanici;
        }
    }
}
