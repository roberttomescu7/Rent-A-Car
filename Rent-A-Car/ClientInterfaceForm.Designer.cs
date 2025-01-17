namespace Rent_A_Car
{
    partial class ClientInterfaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            bookings_uc = new Bookings_UC();
            appointment_uc = new Appointment_UC();
            appointmentAvailable_uc = new AppointmentAvailable_UC();
            appointmentBTN = new Button();
            bookingsBTN = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(bookingsBTN);
            panel2.Controls.Add(appointmentBTN);
            panel2.Controls.SetChildIndex(backBtn, 0);
            panel2.Controls.SetChildIndex(appointmentBTN, 0);
            panel2.Controls.SetChildIndex(bookingsBTN, 0);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            backBtn.Click += backBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bookings_uc);
            panel3.Controls.Add(appointment_uc);
            panel3.Controls.Add(appointmentAvailable_uc);
            panel3.Location = new Point(250, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 750);
            panel3.TabIndex = 3;
            // 
            // bookings_uc
            // 
            bookings_uc.Dock = DockStyle.Fill;
            bookings_uc.Location = new Point(0, 0);
            bookings_uc.Name = "bookings_uc";
            bookings_uc.Size = new Size(950, 750);
            bookings_uc.TabIndex = 4;
            // 
            // appointment_uc
            // 
            appointment_uc.Dock = DockStyle.Fill;
            appointment_uc.Location = new Point(0, 0);
            appointment_uc.Margin = new Padding(0);
            appointment_uc.Name = "appointment_uc";
            appointment_uc.Size = new Size(950, 750);
            appointment_uc.TabIndex = 1;
            // 
            // appointmentAvailable_uc
            // 
            appointmentAvailable_uc.Dock = DockStyle.Fill;
            appointmentAvailable_uc.Location = new Point(0, 0);
            appointmentAvailable_uc.Margin = new Padding(0);
            appointmentAvailable_uc.Name = "appointmentAvailable_uc";
            appointmentAvailable_uc.Size = new Size(950, 750);
            appointmentAvailable_uc.TabIndex = 1;
            // 
            // appointmentBTN
            // 
            appointmentBTN.BackColor = Color.FromArgb(74, 202, 205);
            appointmentBTN.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            appointmentBTN.FlatAppearance.BorderSize = 0;
            appointmentBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            appointmentBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            appointmentBTN.FlatStyle = FlatStyle.Flat;
            appointmentBTN.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            appointmentBTN.Location = new Point(0, 0);
            appointmentBTN.Margin = new Padding(0);
            appointmentBTN.Name = "appointmentBTN";
            appointmentBTN.Size = new Size(250, 50);
            appointmentBTN.TabIndex = 8;
            appointmentBTN.Text = "Rezervare";
            appointmentBTN.UseVisualStyleBackColor = false;
            appointmentBTN.Click += appointmentBTN_Click;
            // 
            // bookingsBTN
            // 
            bookingsBTN.BackColor = Color.FromArgb(74, 202, 205);
            bookingsBTN.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            bookingsBTN.FlatAppearance.BorderSize = 0;
            bookingsBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            bookingsBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            bookingsBTN.FlatStyle = FlatStyle.Flat;
            bookingsBTN.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookingsBTN.Location = new Point(0, 50);
            bookingsBTN.Margin = new Padding(0);
            bookingsBTN.Name = "bookingsBTN";
            bookingsBTN.Size = new Size(250, 50);
            bookingsBTN.TabIndex = 9;
            bookingsBTN.Text = "Inchirierile tale";
            bookingsBTN.UseVisualStyleBackColor = false;
            bookingsBTN.Click += bookingsBTN_Click;
            // 
            // ClientInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel3);
            Name = "ClientInterfaceForm";
            Text = "UserInterfaceForm";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private AppointmentAvailable_UC appointmentAvailable_uc;
        private Button appointmentBTN;
        private Button bookingsBTN;
        private Appointment_UC appointment_uc;
        private Bookings_UC bookings_uc;
    }
}