﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_A_Car
{
    public partial class EmployeeInterfaceForm : MainForm
    {
        private Form _backForm;
        public EmployeeInterfaceForm(Form backForm)
        {
            _backForm = backForm;
            backBtn.Text = "Logout";

            InitializeComponent();

            if (SessionData.IsAdmin == false)
            {
                statisticsBTN.Hide();
            }
            pendingContracts_uc.Hide();
            statistics_uc.Hide();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this._backForm.Show();
            this.Close();
            SessionData.UserID = 0;
            SessionData.IsAdmin = false;
        }

        private void todayContractsBTN_Click(object sender, EventArgs e)
        {
            statistics_uc.Hide();
            pendingContracts_uc.Show();
        }

        private void statisticsBTN_Click(object sender, EventArgs e)
        {
            pendingContracts_uc.Hide();
            statistics_uc.Show();
        }
    }
}
