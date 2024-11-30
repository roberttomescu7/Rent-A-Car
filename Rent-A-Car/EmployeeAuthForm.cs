using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class EmployeeAuthForm : MainForm
    {
        private Form _backForm;

        public EmployeeAuthForm(Form backForm)
        {
            _backForm = backForm;
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTB.Text;
            String password = MainForm.ComputeSha256Hash(passwordTB.Text).Substring(0, 50);

            try
            {
                String querry = "SELECT * FROM Angajati " +
                            "WHERE Username = '" + username + "' AND Password = '" + password + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(querry, MainForm.conn);
                DataTable result = new DataTable();
                adapter.Fill(result);

                if (result.Rows.Count > 0)
                {
                    ClientInterfaceForm userInterfacePage = new ClientInterfaceForm();
                    userInterfacePage.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Clear();
                    passwordTB.Clear();
                    usernameTB.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _backForm.Show();
            this.Close();
        }
    }
}
