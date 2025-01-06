using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Diagnostics.Contracts;
using System.Collections;

namespace Rent_A_Car
{
    public partial class AppointmentAvailable_UC : UserControl
    {
        public event Action<object, string> DataTransmitted;
        private string contractStartDate;
        private string contractEndDate;
        private string carType;
        private string city;

        public AppointmentAvailable_UC()
        {
            InitializeComponent();
            makeAnAppointmentBTN.Hide();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                contractStartDate = contractStartDateDT.Value.Date.ToString("yyyy-MM-dd");
                contractEndDate = contractEndDateDT.Value.Date.ToString("yyyy-MM-dd");
                carType = carTypeCB.Text;
                city = cityCB.Text;

                string verifyQuery = @"SELECT COUNT(*) 
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

                using (SqlCommand command = new SqlCommand(verifyQuery, MainForm.Conn))
                {
                    if (MainForm.Conn.State != ConnectionState.Open)
                    {
                        MainForm.Conn.Open();
                    }

                    int carsCount = (int)command.ExecuteScalar();

                    if (carsCount > 0)
                    {
                        availableL.Text = "Va putem prezenta " + carsCount + " masini in ziua selectata.";
                        makeAnAppointmentBTN.Show();
                    }
                    else
                    {
                        availableL.Text = "Ne pare rau dar nu avem masini disponibile pentru ziua selectata.\n" +
                            "Incercati o alta data sau un alt tip de masina.";
                    }
                }

            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        private void makeAnAppointmentBTN_Click(object sender, EventArgs e)
        {
            string data = contractStartDate + "," + contractEndDate + "," + carType + "," + city;
            DataTransmitted?.Invoke(this, data);
            ClientInterfaceForm.ShowUC("appointment_uc");

        }
    }
}
