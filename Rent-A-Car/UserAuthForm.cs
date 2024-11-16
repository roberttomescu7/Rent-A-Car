using Microsoft.Win32;
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
    public partial class UserAuthForm : MainForm
    {
        public UserAuthForm()
        {
            InitializeComponent();
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            SignUpForm signUpPage = new SignUpForm();
            signUpPage.Show();
            this.Close();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTB.Text;
            String password = passwordTB.Text;

            try
            {
                String querry = "SELECT * FROM Clienti " +
                            "WHERE Username = '" + username + "' AND Password = '" + password + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(querry, MainForm.conn);
                DataTable result = new DataTable();
                adapter.Fill(result);

                if(result.Rows.Count > 0)
                {
                    UserInterfaceForm userInterfacePage = new UserInterfaceForm();
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
    }
}
