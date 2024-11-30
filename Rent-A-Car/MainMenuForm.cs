using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class MainMenuForm : MainForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }  

        private void clientBtn_Click(object sender, EventArgs e)
        {
            ClientAuthForm userAuthPage = new ClientAuthForm(this);
            userAuthPage.Show();
            this.Hide();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeAuthForm employeeAuthPage = new EmployeeAuthForm(this);
            employeeAuthPage.Show();
            this.Hide();
        }
    }
}
