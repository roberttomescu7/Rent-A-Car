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
    public partial class HitedCar_UC : UserControl
    {
        Dictionary<string, (int damageTypeId, int value)> damageTypes = new Dictionary<string, (int, int)>();

        int contractID;
        int carID;

        public HitedCar_UC(string carLicensePlate, int contractNumber)
        {
            InitializeComponent();

            this.contractID = contractNumber;
            DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)damagesDGV.Columns["damageType"];

            string query = "SELECT VehiculID FROM Vehicule WHERE NumarInmatriculare = '" + carLicensePlate + "';";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, MainForm.Conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        this.carID = int.Parse(result.ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Eroare la obținerea VehiculID");
            }

            query = "SELECT * FROM TipuriDaune";

            using (SqlCommand cmd = new SqlCommand(query, MainForm.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string damageName = reader["Denumire"].ToString();
                        int damageId = int.Parse(reader["TipDaunaID"].ToString());
                        int value = int.Parse(reader["ValoareAproxReparatie"].ToString());

                        damageTypes[damageName] = (damageId, value);
                        comboColumn.Items.Add(damageName);
                    }
                }
            }
            damagesDGV.CellValueChanged += damagesDGV_CellValueChanged;
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in damagesDGV.Rows)
            {
                string damageType = row.Cells["damageType"].Value?.ToString();
                string description = row.Cells["description"].Value?.ToString();

                if (!string.IsNullOrEmpty(damageType) && !string.IsNullOrEmpty(description))
                {

                    string insertDamageQuery = @"INSERT INTO Daune (TipDaunaID, ContractID, Descriere) 
                                                 OUTPUT INSERTED.DaunaID VALUES (@TipDaunaID, @ContractID, @Descriere)";

                    using (SqlCommand cmd = new SqlCommand(insertDamageQuery, MainForm.Conn))
                    {
                        damageTypes.TryGetValue(damageType, out var damage);

                        int damageTypeID = damage.damageTypeId;

                        cmd.Parameters.AddWithValue("@TipDaunaID", damageTypeID);
                        cmd.Parameters.AddWithValue("@ContractID", this.contractID);
                        cmd.Parameters.AddWithValue("@Descriere", description);

                        int damageID = (int)cmd.ExecuteScalar();


                        if (this.carID > 0)
                        {
                            string insertVehicleDamageQuery = "INSERT INTO VehiculeDaune (VehiculID, DaunaID) VALUES (@VehiculID, @DaunaID)";

                            using (SqlCommand cmd2 = new SqlCommand(insertVehicleDamageQuery, MainForm.Conn))
                            {
                                cmd2.Parameters.AddWithValue("@VehiculID", this.carID);
                                cmd2.Parameters.AddWithValue("@DaunaID", damageID);

                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            string query = "UPDATE Contracte SET isValid = 'False' WHERE ContractID = @ContractID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, MainForm.Conn))
                {
                    command.Parameters.AddWithValue("@ContractID", contractID);

                    if (MainForm.Conn.State != System.Data.ConnectionState.Open)
                    {
                        MainForm.Conn.Open();
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contractul a fost actualizat cu succes!", "Succes");
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a putut actualiza contractul.", "Eroare");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Baza de date este inaccesibila! {ex.Message}", "Eroare");
            }

            MessageBox.Show("Daunele au fost salvate și legătura a fost creată!");
            this.Parent.Controls[1].Show();
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }



        private void damagesDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == damagesDGV.Columns["damageType"].Index)
            {
                int total = 0;

                // Calculăm totalul pentru toate rândurile
                foreach (DataGridViewRow row in damagesDGV.Rows)
                {
                    string damageName = row.Cells["damageType"].Value?.ToString();

                    if (damageName != null && damageTypes.TryGetValue(damageName, out var damageData))
                    {
                        total += damageData.value;
                    }
                }

                // Actualizăm totalul pe UI
                totalL.Text = total.ToString();
            }
        }
    }
}
