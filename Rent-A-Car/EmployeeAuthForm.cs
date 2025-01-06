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
            String password = MainForm.ComputeSha256Hash(passwordTB.Text);

            try
            {
                String querry = "SELECT AngajatID, SupervizorID, Nume + ' ' + Prenume FROM Angajati " +
                            "WHERE Username = '" + username + "' AND Password = '" + password + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(querry, MainForm.Conn);
                DataTable result = new DataTable();
                adapter.Fill(result);

                if (result.Rows.Count > 0)
                {
                    SessionData.UserID = (int)result.Rows[0][0];
                    SessionData.IsAdmin = (result.Rows[0][1] == DBNull.Value) ? true : false;
                    SessionData.UserFullName = result.Rows[0][2].ToString(); 

                    EmployeeInterfaceForm emplyeeInterfacePage = new EmployeeInterfaceForm(this);
                    emplyeeInterfacePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Clear();
                    passwordTB.Clear();
                    usernameTB.Focus();
                }
                usernameTB.Clear();
                passwordTB.Clear();
                usernameTB.Focus();
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
