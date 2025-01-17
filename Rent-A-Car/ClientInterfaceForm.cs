using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class ClientInterfaceForm : MainForm
    {
        private Form _backForm;
        private static List<UserControl> _userControls = new List<UserControl>();

        public ClientInterfaceForm(Form backForm)
        {
            InitializeComponent();
            SetupCommunication();
            backBtn.Text = "Logout";
            _backForm = backForm;

            _userControls.Add(appointmentAvailable_uc);
            _userControls.Add(appointment_uc);

            appointment_uc.Hide();
            appointmentAvailable_uc.Hide();
            bookings_uc.Hide();
        }

        private void appointmentBTN_Click(object sender, EventArgs e)
        {
            appointmentAvailable_uc.Show();
            appointment_uc.Hide();
            bookings_uc.Hide();
        }

        private void bookingsBTN_Click(object sender, EventArgs e)
        {
            bookings_uc.Show();
            appointmentAvailable_uc.Hide();
            appointment_uc.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _backForm.Show();
            this.Close();
            SessionData.UserID = 0;
        }

        public static void ShowUC(String ucName)
        {
            foreach (var uc in _userControls)
            {
                if (uc.Name == ucName)
                    uc.Show();
                else
                    uc.Hide();
            }
        }

        private void SetupCommunication()
        {
            appointmentAvailable_uc.DataTransmitted += (s, data) =>
            {
                appointment_uc.ReceiveData(data);
            };
        }
    }
}
