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
    public partial class Bookings_UC : UserControl
    {

        Dictionary<string, (CarInfo, ContractInfo)> carsAndContracts = new Dictionary<string, (CarInfo, ContractInfo)>();

        public Bookings_UC()
        {
            InitializeComponent();
        }

        private void Bookings_UC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                carsAndContractsListCB.Items.Clear();
                carsAndContracts.Clear();
                addCarsInList();
                carsAndContractsListCB.Text = carsAndContractsListCB.Items[0].ToString();
            }
        }

        private void addCarsInList()
        {
            try
            {
                string getCarsQuery = @"SELECT V.Marca, V.Model, V.An, V.TipMasina, C.DataIncepere, C.DataIncheiere, C.Pret, 
                                               C.Garantie, C.ContractID, S.Judet, S.Oras, A.Nume, A.Prenume 
                                        FROM Contracte AS C JOIN Vehicule AS V ON C.VehiculID = V.VehiculID
                                                            JOIN Sucursale AS S ON C.SucursalaID = S.SucursalaID
                                                            LEFT JOIN Angajati AS A ON C.AngajatID = A.AngajatID 
                                        WHERE C.ClientID = " + SessionData.ClientId + ";";

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
                        string _brand = dt.Rows[i][0].ToString();
                        string _model = dt.Rows[i][1].ToString();
                        string _year = dt.Rows[i][2].ToString();
                        string _type = dt.Rows[i][3].ToString();
                        string _startDate = ((DateTime)dt.Rows[i][4]).ToString("dd/MM/yyyy");
                        string _endDate = ((DateTime)dt.Rows[i][5]).ToString("dd/MM/yyyy");
                        string _price = dt.Rows[i][6].ToString();
                        string _deposit = dt.Rows[i][7].ToString();
                        int _contractNumber = (int)dt.Rows[i][8];
                        string _county = dt.Rows[i][9].ToString();
                        string _city = dt.Rows[i][10].ToString();
                        string _employeeLName = dt.Rows[i][11].ToString();
                        string _employeeFName = dt.Rows[i][12].ToString();

                        string key = _brand + " - " + _model + " - " + _startDate;
                        string branch = _county + ", " + _city;
                        string employeeName = _employeeFName + " " + _employeeLName;

                        carsAndContractsListCB.Items.Add(key);
                        CarInfo tmpCarInfo = new CarInfo(_brand, _model, _year, _type);
                        ContractInfo tmpContractInfo =
                                     new ContractInfo(_startDate, _endDate, _price, _deposit, _contractNumber, branch, employeeName);

                        carsAndContracts[key] = (tmpCarInfo, tmpContractInfo);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }
        }

        private void carsListCB_TextChanged(object sender, EventArgs e)
        {
            if (carsAndContracts.TryGetValue(carsAndContractsListCB.Text, out (CarInfo Car, ContractInfo Contract) info))
            {
                brandL.Text = info.Car.brand;
                modelL.Text = info.Car.model;
                yearL.Text = info.Car.year;
                carTypeL.Text = info.Car.type;

                contractStartDateL.Text = info.Contract.contractStartDate;
                contractEndDateL.Text = info.Contract.contractEndDate;
                priceL.Text = info.Contract.price;
                depositL.Text = info.Contract.deposit;
                contractIDL.Text = info.Contract.contractNumber.ToString();
                branchL.Text = info.Contract.branch;
                employeeL.Text = info.Contract.employeeName;
            }
        }
    }
}
