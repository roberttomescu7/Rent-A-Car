using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class EditContract_UC : UserControl
    {
        int selectedContractId;
        List<string> damages = new List<string>();
        public EditContract_UC(CarInfo carInfo, ContractInfo contractInfo, ClientInfo clientInfo)
        {
            InitializeComponent();

            try
            {
                string query = @"Select S.Strada + ', ' + S.Numar + ', ' + S.Oras + ', ' + S.Judet
                                 FROM Sucursale as S JOIN Contracte AS C ON S.SucursalaID = C.SucursalaID
                                 WHERE C.ContractID = " + contractInfo.contractNumber + ";";

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
                        contractInfo.branch = dt.Rows[0][0].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Inaccesible database", "ERROR");
            }

            brandTB.Text = carInfo.brand;
            modelTB.Text = carInfo.model;
            YearTB.Text = carInfo.year;
            carTypeTB.Text = carInfo.type;
            pricePerDayTB.Text = carInfo.pricePerDay.ToString();
            numberPlateTB.Text = carInfo.numberPlate;

            contractStartDateTB.Text = contractInfo.contractStartDate;
            contractEndDateTB.Text = contractInfo.contractEndDate;
            branchTB.Text = contractInfo.branch;
            priceTB.Text = contractInfo.price;
            depositTB.Text = contractInfo.deposit;
            totalTB.Text = (float.Parse(contractInfo.price) + float.Parse(contractInfo.deposit)).ToString("F2");
            selectedContractId = contractInfo.contractNumber;

            clientLastNameTB.Text = clientInfo.lastName;
            clientFirstNameTB.Text = clientInfo.firstName;
            clientCNPTB.Text = clientInfo.CNP;
            clientCountyTB.Text = clientInfo.county;
            clientCountyTB.ReadOnly = !string.IsNullOrEmpty(clientCountyTB.Text);
            clientCityTB.Text = clientInfo.city;
            clientCityTB.ReadOnly = !string.IsNullOrEmpty(clientCityTB.Text);
            clientStreetTB.Text = clientInfo.street;
            clientStreetTB.ReadOnly = !string.IsNullOrEmpty(clientStreetTB.Text);
            clientNumberTB.Text = clientInfo.number;
            clientNumberTB.ReadOnly = !string.IsNullOrEmpty(clientNumberTB.Text);
        }

        private void generateContractBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string updateClientAddressQuery = @"UPDATE Clienti
                       SET Strada = @Street, Numar = @Number, Oras = @City, Judet = @County
                       WHERE CNP = @CNP;";

                using (SqlCommand updateAddressCommand = new SqlCommand(updateClientAddressQuery, MainForm.Conn))
                {
                    updateAddressCommand.Parameters.AddWithValue("@Street", clientStreetTB.Text);
                    updateAddressCommand.Parameters.AddWithValue("@Number", clientNumberTB.Text);
                    updateAddressCommand.Parameters.AddWithValue("@City", clientCityTB.Text);
                    updateAddressCommand.Parameters.AddWithValue("@County", clientCountyTB.Text);
                    updateAddressCommand.Parameters.AddWithValue("@CNP", clientCNPTB.Text);

                    if (MainForm.Conn.State != System.Data.ConnectionState.Open)
                    {
                        MainForm.Conn.Open();
                    }

                    int rowsAffected = updateAddressCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Adresa clientului a fost updatata cu succes!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Adresa clientului NU a putut fi updatata!", "Warning");
                    }
                }

                string updateContractQuery = @"UPDATE Contracte
                                               SET AngajatID = @EmployeeID
                                               WHERE ContractID = @ContractID;";

                using (SqlCommand updateContractCommand = new SqlCommand(updateContractQuery, MainForm.Conn))
                {
                    updateContractCommand.Parameters.AddWithValue("@EmployeeID", SessionData.UserID);
                    updateContractCommand.Parameters.AddWithValue("@ContractID", selectedContractId);

                    int rowsAffected = updateContractCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contract updatat cu succes", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Contractul nu a putut fi updatat", "Warning");
                    }
                }

                GeneratePDFContract();
                this.Parent.Controls[1].Show();
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
            catch
            {
                MessageBox.Show($"Inaccesible database", "Error");
            }
        }

        private void GeneratePDFContract()
        {
            string filePath = $"C:/MyFolder/BD/Rent-A-Car/Contracte/Contract_nr_{selectedContractId}.pdf";
            getDamages();

            try
            {
                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                
                PdfFont boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);




                document.Add(new iText.Layout.Element.Paragraph("Contract de Inchiriere")
                        .SetFontSize(20)
                        .SetFont(boldFont)
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    );

                document.Add(new iText.Layout.Element.Paragraph("Date Client:")
                    .SetFontSize(14)
                    .SetFont(boldFont)
                    .SetMarginTop(20)
                );

                document.Add(new iText.Layout.Element.Paragraph(
                    $"Nume Client: {clientLastNameTB.Text} {clientFirstNameTB.Text}\n" +
                    $"CNP: {clientCNPTB.Text}\n" +
                    $"Adresa: {clientStreetTB.Text}, {clientNumberTB.Text}, {clientCityTB.Text}, {clientCountyTB.Text}"
                ).SetFontSize(12));

                document.Add(new iText.Layout.Element.Paragraph("Date Masina:")
                    .SetFontSize(14)
                    .SetFont(boldFont)
                    .SetMarginTop(20)
                );

                document.Add(new iText.Layout.Element.Paragraph(
                    $"Marca: {brandTB.Text}\n" +
                    $"Model: {modelTB.Text}\n" +
                    $"An: {YearTB.Text}\n" +
                    $"Tip Masina: {carTypeTB.Text}\n" +
                    $"Numar Inmatriculare: {numberPlateTB.Text}\n" +
                    $"Pret Per Zi: {pricePerDayTB.Text}"
                ).SetFontSize(12));

                document.Add(new iText.Layout.Element.Paragraph("La primire, masina are urmatoarele daune:")
                    .SetFontSize(14)
                    .SetFont(boldFont)
                    .SetMarginTop(20)
                );

                if (damages.Count > 0)
                {
                    foreach (var damage in damages)
                    {
                        document.Add(new iText.Layout.Element.Paragraph($"- {damage}")
                            .SetFontSize(12)
                            .SetMarginLeft(20)
                            .SetMarginTop(5)
                        );
                    }
                }
                else
                {
                    document.Add(new iText.Layout.Element.Paragraph("Nu există daune raportate.")
                        .SetFontSize(12)
                        .SetMarginLeft(20)
                        .SetMarginTop(5)
                    );
                }

                document.Add(new iText.Layout.Element.Paragraph("Date Contract:")
                    .SetFontSize(14)
                    .SetFont(boldFont)
                    .SetMarginTop(20)
                );

                document.Add(new iText.Layout.Element.Paragraph(
                    $"Data Inceput: {contractStartDateTB.Text}\n" +
                    $"Data Sfarsit: {contractEndDateTB.Text}\n" +
                    $"Pret: {priceTB.Text} RON\n" +
                    $"Garantie: {depositTB.Text} RON\n" +
                    $"Total: {totalTB.Text} RON"
                    ).SetFontSize(12));

                document.Add(new Paragraph("\n"));

                Table signatureTable = new Table(2);
                signatureTable.SetWidth(500);

                // Adaugă clientul în coloana din stânga
                signatureTable.AddCell(new Paragraph("Client")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );
                signatureTable.AddCell(new Paragraph("Reprezentant")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );

                signatureTable.AddCell(new Paragraph($"Nume: {clientFirstNameTB.Text} {clientLastNameTB.Text}")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );
                signatureTable.AddCell(new Paragraph($"Nume: {SessionData.UserFullName}")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );

                signatureTable.AddCell(new Paragraph("Semnatura: ___________________")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );
                signatureTable.AddCell(new Paragraph("Semnatura: ___________________")
                    .SetFontSize(12)
                    .SetTextAlignment(TextAlignment.LEFT)
                );

                // Adaugă tabelul la document
                document.Add(signatureTable);
        

                        document.Close();

                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"PDF-ul a fost generat, dar nu a putut fi deschis automat", "Eroare la deschidere");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error occurred while generating the PDF: {e.Message}", "Error");
            }
        }

        private void getDamages()
        {
            string query = @"SELECT TD.Denumire + ': ' + D.Descriere AS Dauna
                             FROM Vehicule AS V JOIN VehiculeDaune AS VD ON V.VehiculID = VD.VehiculID
                                                JOIN Daune AS D ON D.DaunaID = VD.DaunaID
                                                JOIN TipuriDaune AS TD ON TD.TipDaunaID = D.TipDaunaID
                             WHERE V.NumarInmatriculare = @LicensePlate;";
            using (SqlCommand cmd = new SqlCommand(query, MainForm.Conn))
            {
                cmd.Parameters.AddWithValue("@LicensePlate", numberPlateTB.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        damages.Add(reader["Dauna"].ToString());
                    }
                }
            }
        }
    }
}
