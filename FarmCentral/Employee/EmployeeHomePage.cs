using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmCentral
{
    public partial class EmployeeHomePage : Form
    {
        public EmployeeHomePage()
        {
            InitializeComponent();
        }

        private void btnAddFarmer_Click(object sender, EventArgs e)
        {
            AddFarmer AD = new AddFarmer();
            AD.Show();
            this.Close();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewFarms VF = new ViewFarms();
            VF.Show();
            this.Close();
        }
    }
}
