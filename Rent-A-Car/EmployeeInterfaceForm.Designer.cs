namespace Rent_A_Car
{
    partial class EmployeeInterfaceForm
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
            pendingContracts_uc = new PendingContracts_UC();
            label1 = new Label();
            panel3 = new Panel();
            todayContractsBTN = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(todayContractsBTN);
            panel2.Controls.SetChildIndex(backBtn, 0);
            panel2.Controls.SetChildIndex(todayContractsBTN, 0);
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            backBtn.Click += backBtn_Click;
            // 
            // pendingContracts_uc
            // 
            pendingContracts_uc.Dock = DockStyle.Fill;
            pendingContracts_uc.Location = new Point(0, 0);
            pendingContracts_uc.Margin = new Padding(0);
            pendingContracts_uc.Name = "pendingContracts_uc";
            pendingContracts_uc.Size = new Size(950, 750);
            pendingContracts_uc.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(950, 750);
            label1.TabIndex = 4;
            label1.Text = "Bine ai venit!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pendingContracts_uc);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 750);
            panel3.TabIndex = 4;
            // 
            // todayContractsBTN
            // 
            todayContractsBTN.BackColor = Color.FromArgb(74, 202, 205);
            todayContractsBTN.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            todayContractsBTN.FlatAppearance.BorderSize = 0;
            todayContractsBTN.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            todayContractsBTN.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            todayContractsBTN.FlatStyle = FlatStyle.Flat;
            todayContractsBTN.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            todayContractsBTN.Location = new Point(0, 0);
            todayContractsBTN.Margin = new Padding(0);
            todayContractsBTN.Name = "todayContractsBTN";
            todayContractsBTN.Size = new Size(250, 50);
            todayContractsBTN.TabIndex = 8;
            todayContractsBTN.Text = "Contractele de azi";
            todayContractsBTN.UseVisualStyleBackColor = false;
            todayContractsBTN.Click += todayContractsBTN_Click;
            // 
            // EmployeeInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel3);
            Name = "EmployeeInterfaceForm";
            Text = "";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel3, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PendingContracts_UC pendingContracts_uc;
        private Label label1;
        private Panel panel3;
        private Button todayContractsBTN;
    }
}