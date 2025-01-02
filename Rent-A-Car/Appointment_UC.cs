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
using System.Windows.Forms.VisualStyles;

namespace Rent_A_Car
{
    public partial class Appointment_UC : UserControl
    {
        private string contractStartDate;
        private string contractEndDate;
        private string carType;
        private string city;
        Dictionary<string, CarInfo> cars = new Dictionary<string, CarInfo>();
        CarInfo selectedCar;

        public Appointment_UC()
        {
            InitializeComponent();
        }

        private void addCarsInList()
        {
            try
            {
                string getCarsQuery = @"SELECT V.VehiculID, V.Marca, V.Model, V.An, V.TipMasina, V.PretPerZi, V.SucursalaID
                                        FROM Vehicule AS V
                                        WHERE V.TipMasina = '" + carType + @"' 
	                                    AND V.SucursalaID = (SELECT S.SucursalaID FROM Sucursale AS S 
						                                     WHERE S.Oras = '" + city + @"')
	                                    AND V.VehiculID NOT IN (SELECT C.VehiculID FROM Contracte AS C 
							                                    WHERE (C.DataIncepere <= '" + contractStartDate + @"' 
							                                    AND C.DataIncheiere >= '" + contractStartDate + @"')
                                                                OR (C.DataIncepere <= '" + contractEndDate + @"' 
							                                    AND C.DataIncheiere >= '" + contractEndDate + @"')
                                                                OR (C.DataIncepere >= '" + contractStartDate + @"' 
							                                    AND C.DataIncheiere <= '" + contractEndDate + @"')
							                                    AND C.isValid = 'True');";

                if (MainForm.Conn.State != ConnectionState.Open)
                {
                    MainForm.Conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(getCarsQuery, MainForm.Conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int _id = (int)dt.Rows[i][0];
                        string _brand = dt.Rows[i][1].ToString();
                        string _model = dt.Rows[i][2].ToString();
                        string _year = dt.Rows[i][3].ToString();
                        string _type = dt.Rows[i][4].ToString();
                        int _pricePerDay = (int)dt.Rows[i][5];
                        int _branchId = (int)dt.Rows[i][6];

                        string displayText = _brand + " - " + _model;

                        carsListCB.Items.Add(displayText);
                        cars[displayText] = new CarInfo(_id, _brand, _model, _year, _type, _pricePerDay, _branchId);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        public void ReceiveData(string data)
        {
            string[] parts = data.Split(',');

            contractStartDate = parts[0];
            contractEndDate = parts[1];
            carType = parts[2];
            city = parts[3];
        }

        private void Appointment_UC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                cars.Clear();
                carsListCB.Items.Clear();
                addCarsInList();
                carsListCB.Text = carsListCB.Items[0].ToString();
            }
        }

        private void carsListCB_TextChanged(object sender, EventArgs e)
        {

            if (cars.TryGetValue(carsListCB.Text, out CarInfo carInfo))
            {
                selectedCar = carInfo;
                brandL.Text = carInfo.brand;
                modelL.Text = carInfo.model;
                yearL.Text = carInfo.year;
                carTypeL.Text = carInfo.type;
            }
        }

        private void confirmAppointmentBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"INSERT INTO Contracte
                                 (AngajatID, VehiculID, DataIncepere, DataIncheiere, Pret, Garantie, isValid, SucursalaID, ClientID)
                                 VALUES (@AngajatID, @VehiculID, @DataIncepere, @DataIncheiere, @Pret, @Garantie, 
                                 @isValid, @SucursalaID, @ClientID);";

                DateTime startDate = DateTime.ParseExact(contractStartDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime endDate = DateTime.ParseExact(contractEndDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

                int numberOfDays = (endDate - startDate).Days;

                using (SqlCommand command = new SqlCommand(query, MainForm.Conn))
                {
                    command.Parameters.AddWithValue("@AngajatID", (object)DBNull.Value);
                    command.Parameters.AddWithValue("@VehiculID", selectedCar.id);
                    command.Parameters.AddWithValue("@DataIncepere", contractStartDate);
                    command.Parameters.AddWithValue("@DataIncheiere", contractEndDate);
                    command.Parameters.AddWithValue("@Pret", selectedCar.pricePerDay * numberOfDays);
                    command.Parameters.AddWithValue("@Garantie", 1000);
                    command.Parameters.AddWithValue("@isValid", "True");
                    command.Parameters.AddWithValue("@SucursalaID", selectedCar.branchId);
                    command.Parameters.AddWithValue("@ClientID", SessionData.ClientId);

                    if (MainForm.Conn.State != System.Data.ConnectionState.Open)
                    {
                        MainForm.Conn.Open();
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rezervarea a fost realizata cu succes!", "Success");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Rezervarea NU a fost realizata!", "ERROR");
            }
            /*catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "ERROR");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid date format: {ex.Message}", "ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "ERROR");
            }*/
        }
    }
}
