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
    public partial class PendingContracts_UC : UserControl
    {
        private string currentDay = DateTime.Now.ToString("yyyy-MM-dd");
        private Dictionary<string, (CarInfo, ContractInfo, ClientInfo)> startingContracts =
            new Dictionary<string, (CarInfo, ContractInfo, ClientInfo)>();
        private Dictionary<string, (CarInfo, ContractInfo, ClientInfo)> endingContracts =
            new Dictionary<string, (CarInfo, ContractInfo, ClientInfo)>();

        public PendingContracts_UC()
        {
            InitializeComponent();
        }

        private void PendingContracts_UC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                startingContracts.Clear();
                endingContracts.Clear();
                this.startingContractsDGV.Rows.Clear();
                this.endingContractsDGV.Rows.Clear();
                getStartingContracts();
                getEndingContracts();
            }
        }

        private void getStartingContracts()
        {
            try
            {
                string query = @"SELECT V.Marca, V.Model, V.An, V.TipMasina, V.PretPerZi, V.NumarInmatriculare,
	                                    C.DataIncepere, C.DataIncheiere, C.Pret, C.Garantie, C.ContractID,
	                                    CL.Nume, CL.Prenume, CL.CNP, CL.Strada, CL.Numar, CL.Oras, CL.Judet
                                 FROM Contracte AS C JOIN Vehicule AS V ON C.VehiculID = V.VehiculID
					                                 JOIN Clienti AS CL ON CL.ClientID = C.ClientID
                                 WHERE C.isValid = 'True' AND
                                       C.DataIncepere = '" + currentDay + @"' AND
                                       C.AngajatID IS NULL AND
	                                   C.SucursalaID = (Select A.SucursalaID 
                                                        FROM Angajati AS A 
                                                        WHERE A.AngajatID = " + SessionData.UserID + ");";

                if (MainForm.Conn.State != ConnectionState.Open)
                {
                    MainForm.Conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, MainForm.Conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string _brand = dt.Rows[i][0].ToString();
                        string _model = dt.Rows[i][1].ToString();
                        string _year = dt.Rows[i][2].ToString();
                        string _type = dt.Rows[i][3].ToString();
                        int _pricePerDay = (int)dt.Rows[i][4];
                        string _numberPlate = dt.Rows[i][5].ToString();


                        CarInfo tmpCar = new CarInfo(_brand, _model, _year, _type, _pricePerDay, _numberPlate);

                        string _startDate = ((DateTime)dt.Rows[i][6]).ToString("dd/MM/yyyy");
                        string _endDate = ((DateTime)dt.Rows[i][7]).ToString("dd/MM/yyyy");
                        string _price = dt.Rows[i][8].ToString();
                        string _deposit = dt.Rows[i][9].ToString();
                        int _contractNumber = (int)dt.Rows[i][10];

                        ContractInfo tmpContract = new ContractInfo(_startDate, _endDate, _price, _deposit, _contractNumber);

                        string _lastName = dt.Rows[i][11].ToString();
                        string _fisrtName = dt.Rows[i][12].ToString();
                        string _cnp = dt.Rows[i][13].ToString();
                        string _street = dt.Rows[i][14].ToString();
                        string _number = dt.Rows[i][15].ToString();
                        string _city = dt.Rows[i][16].ToString();
                        string _county = dt.Rows[i][17].ToString();

                        ClientInfo tmpClient = new ClientInfo(_fisrtName, _lastName, _cnp, _street, _number, _city, _county);

                        startingContracts[_numberPlate] = (tmpCar, tmpContract, tmpClient);
                        startingContractsDGV.Rows.Add(_fisrtName + " " + _lastName, _brand + " " + _model, _numberPlate);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        private void getEndingContracts()
        {
            try
            {
                string query = @"SELECT V.Marca, V.Model, V.An, V.TipMasina, V.PretPerZi, V.NumarInmatriculare, V.SucursalaID,
	                                    C.DataIncepere, C.DataIncheiere, C.Pret, C.Garantie, C.ContractID,
	                                    CL.Nume, CL.Prenume, CL.CNP, CL.Strada, CL.Numar, CL.Oras, CL.Judet
                                 FROM Contracte AS C JOIN Vehicule AS V ON C.VehiculID = V.VehiculID
					                                 JOIN Clienti AS CL ON CL.ClientID = C.ClientID
                                 WHERE C.isValid = 'True' AND
                                       C.DataIncheiere = '" + currentDay + @"' AND
                                       C.AngajatID = " + SessionData.UserID + @" AND
	                                   C.SucursalaID = (Select A.SucursalaID 
                                                        FROM Angajati AS A 
                                                        WHERE A.AngajatID = " + SessionData.UserID + ");";

                if (MainForm.Conn.State != ConnectionState.Open)
                {
                    MainForm.Conn.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, MainForm.Conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string _brand = dt.Rows[i][0].ToString();
                        string _model = dt.Rows[i][1].ToString();
                        string _year = dt.Rows[i][2].ToString();
                        string _type = dt.Rows[i][3].ToString();
                        int _pricePerDay = (int)dt.Rows[i][4];
                        string _numberPlate = dt.Rows[i][5].ToString();
                        int _branch = (int)dt.Rows[i][6];

                        CarInfo tmpCar = new CarInfo(_brand, _model, _year, _type, _pricePerDay, _numberPlate);

                        string _startDate = dt.Rows[i][7].ToString();
                        string _endDate = dt.Rows[i][8].ToString();
                        string _price = dt.Rows[i][9].ToString();
                        string _deposit = dt.Rows[i][10].ToString();
                        int _contractNumber = (int)dt.Rows[i][11];

                        ContractInfo tmpContract = new ContractInfo(_startDate, _endDate, _price, _deposit, _contractNumber);

                        string _lastName = dt.Rows[i][12].ToString();
                        string _fisrtName = dt.Rows[i][13].ToString();
                        string _cnp = dt.Rows[i][14].ToString();
                        string _street = dt.Rows[i][15].ToString();
                        string _number = dt.Rows[i][16].ToString();
                        string _city = dt.Rows[i][17].ToString();
                        string _county = dt.Rows[i][18].ToString();

                        ClientInfo tmpClient = new ClientInfo(_fisrtName, _lastName, _cnp, _street, _number, _city, _county);

                        endingContracts[_numberPlate] = (tmpCar, tmpContract, tmpClient);
                        endingContractsDGV.Rows.Add(_fisrtName + " " + _lastName, _brand + " " + _model, _numberPlate);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        private void startingContractsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == startingContractsDGV.Columns["edit"].Index && e.RowIndex >= 0)
            {
                string licensePlate = startingContractsDGV.Rows[e.RowIndex].Cells["numberPlate"].Value.ToString();

                if (startingContracts.TryGetValue(licensePlate, out (CarInfo Car, ContractInfo Contract, ClientInfo Client) info))
                {
                    EditContract_UC editContract_UC = new EditContract_UC(info.Car, info.Contract, info.Client);

                    this.Parent.Controls.Add(editContract_UC);
                    editContract_UC.Dock = DockStyle.Fill;
                    editContract_UC.BringToFront();
                    editContract_UC.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contract data not found for the selected vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex == startingContractsDGV.Columns["delete"].Index && e.RowIndex >= 0)
            {
                string carNumberPlate = startingContractsDGV.Rows[e.RowIndex].Cells["numberPlate"].Value.ToString();

                if (startingContracts.TryGetValue(carNumberPlate,
                    out (CarInfo Car, ContractInfo Contract, ClientInfo Client) info))
                {

                    int contractID = info.Contract.contractNumber;

                    DialogResult result = MessageBox.Show(
                    "Sunteți sigur că doriți să ștergeți acest contract?",
                    "Confirmare ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            string deleteQuery = "DELETE FROM Contracte WHERE ContractID = @ContractID";

                            using (SqlCommand command = new SqlCommand(deleteQuery, MainForm.Conn))
                            {
                                command.Parameters.AddWithValue("@ContractID", contractID);

                                if (MainForm.Conn.State != System.Data.ConnectionState.Open)
                                {
                                    MainForm.Conn.Open();
                                }

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Contractul a fost șters cu succes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    startingContractsDGV.Rows.RemoveAt(e.RowIndex);
                                }
                                else
                                {
                                    MessageBox.Show("Nu s-a putut șterge contractul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Eroare la ștergerea contractului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contractul nu a fost găsit în sistem.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void endingContractsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == endingContractsDGV.Columns["ok"].Index && e.RowIndex >= 0)
            {
                string licensePlate = endingContractsDGV.Rows[e.RowIndex].Cells["numberPlateEnd"].Value.ToString();

                if (endingContracts.TryGetValue(licensePlate, out (CarInfo Car, ContractInfo Contract, ClientInfo Client) info))
                {

                    string query = "UPDATE Contracte SET isValid = 'False' WHERE ContractID = @ContractID";

                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, MainForm.Conn))
                        {
                            command.Parameters.AddWithValue("@ContractID", info.Contract.contractNumber);

                            if (MainForm.Conn.State != System.Data.ConnectionState.Open)
                            {
                                MainForm.Conn.Open();
                            }

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Contractul a fost actualizat cu succes!", "Succes");
                                endingContractsDGV.Rows.RemoveAt(e.RowIndex);
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
                }
            }

            if (e.ColumnIndex == endingContractsDGV.Columns["hit"].Index && e.RowIndex >= 0)
            {
                string licensePlate = endingContractsDGV.Rows[e.RowIndex].Cells["numberPlateEnd"].Value.ToString();

                if (endingContracts.TryGetValue(licensePlate, out (CarInfo Car, ContractInfo Contract, ClientInfo Client) info))
                {
                    HitedCar_UC hitedCar_UC = new HitedCar_UC(info.Car.numberPlate, info.Contract.contractNumber);

                    this.Parent.Controls.Add(hitedCar_UC);
                    hitedCar_UC.Dock = DockStyle.Fill;
                    hitedCar_UC.BringToFront();
                    hitedCar_UC.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contract data not found for the selected vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
