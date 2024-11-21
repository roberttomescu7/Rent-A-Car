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
    public partial class SignUpForm : MainForm
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            String sex = "";

            if (sexMCB.Checked)
            {
                sex = "M";
            }
            else if (sexFCB.Checked)
            {
                sex = "F";
            }

            if (isFilled())
            {
                if (isUnique())
                {

                    string hashedPassword = (MainForm.ComputeSha256Hash(passwordTB.Text)).Substring(0, 50);

                    try
                    {
                        String query = "INSERT INTO Clienti " +
                         "(Nume, Prenume, CNP, Strada, Numar, Oras, Judet, Sex, DataNasterii, Username, Password) " +
                         "VALUES (@LastName, @FirstName, @CNP, @Street, @Number, @City, @County, @Sex, @DateOfBirth, @Username, @Password)";

                        using (SqlCommand command = new SqlCommand(query, MainForm.conn))
                        {
                            command.Parameters.AddWithValue("@LastName", lastNameTB.Text);
                            command.Parameters.AddWithValue("@FirstName", firstNameTB.Text);
                            command.Parameters.AddWithValue("@CNP", cnpTB.Text);
                            command.Parameters.AddWithValue("@Street",
                                    string.IsNullOrWhiteSpace(streetTB.Text) ? (object)DBNull.Value : streetTB.Text);
                            command.Parameters.AddWithValue("@Number",
                                    string.IsNullOrWhiteSpace(numberTB.Text) ? (object)DBNull.Value : numberTB.Text);
                            command.Parameters.AddWithValue("@City",
                                    string.IsNullOrWhiteSpace(cityTB.Text) ? (object)DBNull.Value : cityTB.Text);
                            command.Parameters.AddWithValue("@County",
                                    string.IsNullOrWhiteSpace(countyTB.Text) ? (object)DBNull.Value : countyTB.Text);
                            command.Parameters.AddWithValue("@Sex",
                                    string.IsNullOrWhiteSpace(sex) ? (object)DBNull.Value : sex);
                            command.Parameters.AddWithValue("@DateOfBirth",
                                    dateOfBirthDTP.Value.Date == DateTime.Now.Date ? (object)DBNull.Value : dateOfBirthDTP.Value.Date);
                            command.Parameters.AddWithValue("@Username", usernameTB.Text);
                            command.Parameters.AddWithValue("@Password", hashedPassword);

                            if (MainForm.conn.State != System.Data.ConnectionState.Open)
                            {
                                MainForm.conn.Open();
                            }

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record inserted successfully!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert the record.", "Warning");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Inaccesible database", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in all the fields marked with \"*\"", "Warning");

            }
        }

        private void sexMCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sexMCB.Checked)
            {
                sexFCB.Checked = false;
            }
        }

        private void sexFCB_CheckedChanged(object sender, EventArgs e)
        {
            if (sexFCB.Checked)
            {
                sexMCB.Checked = false;
            }
        }

        private bool isFilled()
        {
            bool flag = true;

            if (string.IsNullOrWhiteSpace(firstNameTB.Text))
            {
                firstNameTB.Clear();
                firstNameTB.BackColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(lastNameTB.Text))
            {
                lastNameTB.Clear();
                lastNameTB.BackColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(cnpTB.Text))
            {
                cnpTB.Clear();
                cnpTB.BackColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(usernameTB.Text))
            {
                usernameTB.Clear();
                usernameTB.BackColor = Color.Red;
                flag = false;
            }
            if (string.IsNullOrWhiteSpace(passwordTB.Text))
            {
                passwordTB.Clear();
                passwordTB.BackColor = Color.Red;
                flag = false;
            }
            return flag;
        }

        private bool isUnique()
        {
            DataTable dt = new DataTable();

            String querry1 = "SELECT * FROM Clienti " +
                            "WHERE CNP = '" + cnpTB.Text + "';";
            SqlDataAdapter adapter1 = new SqlDataAdapter(querry1, MainForm.conn);

            String querry2 = "SELECT * FROM Clienti " +
                            "WHERE Username = '" + usernameTB.Text + "';";
            SqlDataAdapter adapter2 = new SqlDataAdapter(querry2, MainForm.conn);

            adapter1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Incorrect CNP. Must be unique", "Warning");
                return false;
            }

            adapter2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Incorrect username. Must be unique", "Warning");
                return false;
            }
            return true;
        }

        private void lastNameTB_TextChanged(object sender, EventArgs e)
        {
            lastNameTB.BackColor = Color.White;
        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {
            firstNameTB.BackColor = Color.White;
        }

        private void cnpTB_TextChanged(object sender, EventArgs e)
        {
            cnpTB.BackColor = Color.White;
        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {
            usernameTB.BackColor = Color.White;
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            passwordTB.BackColor = Color.White;
        }
    }
}
