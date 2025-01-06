namespace Rent_A_Car
{
    partial class AppointmentAvailable_UC
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
            carTypeCB = new ComboBox();
            label1 = new Label();
            contractStartDateDT = new DateTimePicker();
            label2 = new Label();
            verifyBtn = new Button();
            availableL = new Label();
            makeAnAppointmentBTN = new Button();
            label3 = new Label();
            cityCB = new ComboBox();
            label4 = new Label();
            contractEndDateDT = new DateTimePicker();
            SuspendLayout();
            // 
            // carTypeCB
            // 
            carTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            carTypeCB.FormattingEnabled = true;
            carTypeCB.Items.AddRange(new object[] { "SUV", "Compact", "Sedan", "Electric/Hybrid", "MPV", "Comercial", "Cabrio", "Off-road", "Minivan" });
            carTypeCB.Location = new Point(134, 174);
            carTypeCB.Name = "carTypeCB";
            carTypeCB.Size = new Size(276, 28);
            carTypeCB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 151);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 1;
            label1.Text = "Ce tip de masina doresti?";
            // 
            // contractStartDateDT
            // 
            contractStartDateDT.Location = new Point(134, 105);
            contractStartDateDT.Name = "contractStartDateDT";
            contractStartDateDT.Size = new Size(276, 27);
            contractStartDateDT.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 82);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 3;
            label2.Text = "Din ce zi ai nevoie de masina?";
            // 
            // verifyBtn
            // 
            verifyBtn.Location = new Point(332, 260);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(276, 29);
            verifyBtn.TabIndex = 4;
            verifyBtn.Text = "Verifica disponibilitatea";
            verifyBtn.UseVisualStyleBackColor = true;
            verifyBtn.Click += verifyBtn_Click;
            // 
            // availableL
            // 
            availableL.Location = new Point(332, 302);
            availableL.Name = "availableL";
            availableL.Size = new Size(276, 111);
            availableL.TabIndex = 5;
            // 
            // makeAnAppointmentBTN
            // 
            makeAnAppointmentBTN.Location = new Point(332, 549);
            makeAnAppointmentBTN.Name = "makeAnAppointmentBTN";
            makeAnAppointmentBTN.Size = new Size(276, 29);
            makeAnAppointmentBTN.TabIndex = 6;
            makeAnAppointmentBTN.Text = "Faceti o rezervare";
            makeAnAppointmentBTN.UseVisualStyleBackColor = true;
            makeAnAppointmentBTN.Click += makeAnAppointmentBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 151);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(225, 20);
            label3.TabIndex = 7;
            label3.Text = "In ce oras doresti sa ne intalnim?";
            // 
            // cityCB
            // 
            cityCB.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCB.FormattingEnabled = true;
            cityCB.Items.AddRange(new object[] { "Bucuresti", "Cluj-Napoca", "Timisoara", "Iasi", "Constanta" });
            cityCB.Location = new Point(535, 174);
            cityCB.Name = "cityCB";
            cityCB.Size = new Size(276, 28);
            cityCB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 82);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(233, 20);
            label4.TabIndex = 10;
            label4.Text = "Pana in ce zi ai nevoie de masina?";
            // 
            // contractEndDateDT
            // 
            contractEndDateDT.Location = new Point(535, 105);
            contractEndDateDT.Name = "contractEndDateDT";
            contractEndDateDT.Size = new Size(276, 27);
            contractEndDateDT.TabIndex = 9;
            // 
            // AppointmentAvailable_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(contractEndDateDT);
            Controls.Add(cityCB);
            Controls.Add(label3);
            Controls.Add(makeAnAppointmentBTN);
            Controls.Add(availableL);
            Controls.Add(verifyBtn);
            Controls.Add(label2);
            Controls.Add(contractStartDateDT);
            Controls.Add(label1);
            Controls.Add(carTypeCB);
            Margin = new Padding(0);
            Name = "AppointmentAvailable_UC";
            Size = new Size(950, 750);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox carTypeCB;
        private Label label1;
        private DateTimePicker contractStartDateDT;
        private Label label2;
        private Button verifyBtn;
        private Label availableL;
        private Button makeAnAppointmentBTN;
        private Label label3;
        private ComboBox cityCB;
        private Label label4;
        private DateTimePicker contractEndDateDT;
    }
}
