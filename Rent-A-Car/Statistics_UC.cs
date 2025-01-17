using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Rent_A_Car
{
    public partial class Statistics_UC : UserControl
    {
        public Statistics_UC()
        {
            InitializeComponent();
        }

        public void getStatistics()
        {
            if (MainForm.Conn.State != ConnectionState.Open)
            {
                MainForm.Conn.Open();
            }

            int offsetY = 20;

            string pieChartQuery = @"
                    SELECT TD.Denumire, 
                           COUNT(D.DaunaID) * 100.0 / (SELECT COUNT(*) FROM Daune) AS Procent
                    FROM TipuriDaune TD
                    LEFT JOIN Daune D ON TD.TipDaunaID = D.TipDaunaID
                    GROUP BY TD.Denumire
                    HAVING COUNT(D.DaunaID) * 100.0 / (SELECT COUNT(*) FROM Daune) > 5
                    ORDER BY Procent DESC";

            Chart pieChart = CreatePieChart(MainForm.Conn, pieChartQuery);
            pieChart.Location = new Point(10, offsetY);
            statisticsPanel.Controls.Add(pieChart);
            offsetY += pieChart.Height + 20;

            DateTime today = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            string startDate = firstDayOfMonth.ToString("yyyy-MM-dd");
            string endDate = lastDayOfMonth.ToString("yyyy-MM-dd");

            var queries = new[]
            {
                new { Query = @$"SELECT TD.Denumire, COUNT(DISTINCT D.DaunaID) AS 'Nr. Daune' 
                                FROM TipuriDaune AS TD 
                                LEFT JOIN Daune AS D ON TD.TipDaunaID = D.TipDaunaID
                                JOIN VehiculeDaune AS VD ON VD.DaunaID = D.DaunaID
                                JOIN Vehicule AS V ON VD.VehiculID = V.VehiculID 
                                WHERE V.SucursalaID = {SessionData.branchID}
                                GROUP BY TD.TipDaunaID, TD.Denumire
                                ORDER BY 'Nr. Daune' DESC",
                       Title = "Nr. Daune Pe Fiecare Tip" },

                new { Query = $@"SELECT A.Prenume + ' ' + A.Nume AS 'Nume Angajat', COUNT(C.ContractID) AS 'Nr. Contracte'
                                FROM Angajati AS A 
                                LEFT JOIN Contracte AS C ON A.AngajatID = C.AngajatID
                                WHERE A.SupervizorID = {SessionData.UserID} AND
                                      C.DataIncepere BETWEEN '{startDate}' AND '{endDate}'
                                GROUP BY A.Prenume, A.Nume
                                ORDER BY 'Nr. Contracte' DESC",
                       Title = "Nr. Contracte Încheiate In Luna Curentă De Fiecare Angajat" },

                new { Query = $@"SELECT TOP 3 V.NumarInmatriculare AS 'Nr. Înmatriculare', V.Marca + ' - ' + V.Model AS Masina, COUNT(C.ContractID) AS 'Nr. Închirieri'
                                FROM Vehicule AS V 
                                JOIN Contracte AS C ON V.VehiculID = C.VehiculID
                                WHERE V.SucursalaID = {SessionData.branchID}
                                GROUP BY V.VehiculID, V.NumarInmatriculare, V.Marca, V.Model
                                ORDER BY 'Nr. Închirieri' DESC",
                       Title = "Top 3 Cele Mai Închiriate Mașini" },

                new { Query = $@"SELECT V.NumarInmatriculare as 'Nr. Înmatriculare', V.Marca + ' - ' + V.Model AS Masina, SUM(C.Pret) AS 'Venit Total'
                                FROM Vehicule AS V 
                                JOIN Contracte AS C ON V.VehiculID = C.VehiculID
                                WHERE V.SucursalaID = {SessionData.branchID}
                                GROUP BY V.VehiculID, V.NumarInmatriculare, V.Marca, V.Model
                                ORDER BY 'Venit Total' DESC",
                       Title = "Venitul Total Pe Mașină" },

                new { Query = @$"SELECT V.NumarInmatriculare AS 'Nr. Înmatriculare', V.Marca + ' - ' + V.Model AS Masina, 
                                       AVG(DATEDIFF(DAY, C.DataIncepere, C.DataIncheiere)) AS 'Perioada Medie Închirieri'
                                FROM Vehicule AS V 
                                JOIN Contracte AS C ON V.VehiculID = C.VehiculID
                                WHERE V.SucursalaID = {SessionData.branchID}
                                GROUP BY V.VehiculID, V.NumarInmatriculare, V.Marca, V.Model 
                                ORDER BY 'Perioada Medie Închirieri' DESC",
                       Title = "Perioada Medie De Închiriere [Zile]" },

                new { Query = @$"SELECT TOP 3 CL.Prenume + ' ' + CL.Nume AS 'Nume Client', COUNT(C.ContractID) AS 'Nr. Contracte'
                                 FROM Clienti AS CL
                                 LEFT JOIN Contracte AS C ON CL.ClientID = C.ClientID
                                 WHERE C.SucursalaID = {SessionData.branchID}
                                 GROUP BY CL.Prenume, CL.Nume
                                 ORDER BY 'Nr. Contracte' DESC;",
                       Title = "Top 3 cei mai fideli clienți" }
            };

            foreach (var query in queries)
            {
                Label titleLabel = new Label
                {
                    Text = query.Title,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(10, offsetY),
                    AutoSize = true
                };
                statisticsPanel.Controls.Add(titleLabel);
                offsetY += titleLabel.Height + 10;

                DataGridView dataGrid = CreateDataGrid(MainForm.Conn, query.Query);
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGrid.Location = new Point(10, offsetY);
                statisticsPanel.Controls.Add(dataGrid);
                offsetY += dataGrid.Height + 20;
            }
        }

        private Chart CreatePieChart(SqlConnection connection, string query)
        {
            Chart chart = new Chart
            {
                Size = new Size(400, 400)
            };
            chart.ChartAreas.Add(new ChartArea());

            Series series = new Series
            {
                ChartType = SeriesChartType.Pie
            };
            chart.Series.Add(series);

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    series.Points.AddXY(reader["Denumire"], reader["Procent"]);
                }
            }

            return chart;
        }

        private DataGridView CreateDataGrid(SqlConnection connection, string query)
        {
            DataGridView dataGrid = new DataGridView
            {
                Size = new Size(800, 200),
                ReadOnly = true,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White
            };

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGrid.DataSource = table;
            }

            return dataGrid;
        }

        private void Statistics_UC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                statisticsPanel.Controls.Clear();
                getStatistics();
            }
        }
    }
}
