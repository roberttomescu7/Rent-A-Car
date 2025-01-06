namespace Rent_A_Car
{
    partial class Appointment_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carsListCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            carTypeL = new Label();
            yearL = new Label();
            modelL = new Label();
            brandL = new Label();
            confirmAppointmentBTN = new Button();
            SuspendLayout();
            // 
            // carsListCB
            // 
            carsListCB.DropDownStyle = ComboBoxStyle.DropDownList;
            carsListCB.FormattingEnabled = true;
            carsListCB.Location = new Point(164, 32);
            carsListCB.Name = "carsListCB";
            carsListCB.Size = new Size(266, 28);
            carsListCB.TabIndex = 0;
            carsListCB.TextChanged += carsListCB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(123, 40);
            label1.TabIndex = 1;
            label1.Text = "Masinile valabile:\r\n ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 100);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 2;
            label2.Text = "Marca: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 3;
            label3.Text = "Model: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 250);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 5;
            label4.Text = "Tip masina: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 200);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "An: ";
            // 
            // carTypeL
            // 
            carTypeL.AutoSize = true;
            carTypeL.Location = new Point(160, 250);
            carTypeL.Name = "carTypeL";
            carTypeL.Size = new Size(0, 20);
            carTypeL.TabIndex = 9;
            // 
            // yearL
            // 
            yearL.AutoSize = true;
            yearL.Location = new Point(160, 200);
            yearL.Name = "yearL";
            yearL.Size = new Size(0, 20);
            yearL.TabIndex = 8;
            // 
            // modelL
            // 
            modelL.AutoSize = true;
            modelL.Location = new Point(160, 150);
            modelL.Name = "modelL";
            modelL.Size = new Size(0, 20);
            modelL.TabIndex = 7;
            // 
            // brandL
            // 
            brandL.AutoSize = true;
            brandL.Location = new Point(160, 100);
            brandL.Name = "brandL";
            brandL.Size = new Size(0, 20);
            brandL.TabIndex = 6;
            // 
            // confirmAppointmentBTN
            // 
            confirmAppointmentBTN.Location = new Point(35, 685);
            confirmAppointmentBTN.Name = "confirmAppointmentBTN";
            confirmAppointmentBTN.Size = new Size(220, 29);
            confirmAppointmentBTN.TabIndex = 10;
            confirmAppointmentBTN.Text = "Confirmati rezervarea";
            confirmAppointmentBTN.UseVisualStyleBackColor = true;
            confirmAppointmentBTN.Click += confirmAppointmentBTN_Click;
            // 
            // Appointment_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(confirmAppointmentBTN);
            Controls.Add(carTypeL);
            Controls.Add(yearL);
            Controls.Add(modelL);
            Controls.Add(brandL);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carsListCB);
            Margin = new Padding(0);
            Name = "Appointment_UC";
            Size = new Size(950, 750);
            VisibleChanged += Appointment_UC_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox carsListCB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label carTypeL;
        private Label yearL;
        private Label modelL;
        private Label brandL;
        private Button confirmAppointmentBTN;
    }
}
