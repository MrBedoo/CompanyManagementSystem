using CompanyManagementSystem.Data;
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
    public partial class ProjelerForm : Form
    {
        private readonly Kullanici _currentUser;

        public ProjelerForm(Kullanici kullanici)
        {
            InitializeComponent();
            _currentUser = kullanici;
        }

        public void LoadProjeler()
        {
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var UserMainForm1 = new UserMainForm(_currentUser);  // Yeni açmak istediğin formun ismi
            UserMainForm1.Show();                // Formu gösterir (aynı anda her iki form da açık kalır)

            this.Hide();
        }
    }
}
