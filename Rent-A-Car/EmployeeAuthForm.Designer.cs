﻿namespace Rent_A_Car
{
    partial class EmployeeAuthForm
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
            logInBTN = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            backBtn.Location = new Point(0, 700);
            backBtn.Click += backBtn_Click;
            // 
            // logInBTN
            // 
            logInBTN.Location = new Point(596, 368);
            logInBTN.Name = "logInBTN";
            logInBTN.Size = new Size(266, 29);
            logInBTN.TabIndex = 10;
            logInBTN.Text = "Conecteaza-te";
            logInBTN.UseVisualStyleBackColor = true;
            logInBTN.Click += logInBtn_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(660, 273);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(266, 27);
            passwordTB.TabIndex = 9;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(660, 222);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(266, 27);
            usernameTB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 276);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Parola";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 225);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Nume utilizator";
            // 
            // EmployeeAuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(logInBTN);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(backBtn);
            Name = "EmployeeAuthForm";
            Text = "EmployeeAuth";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(backBtn, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(usernameTB, 0);
            Controls.SetChildIndex(passwordTB, 0);
            Controls.SetChildIndex(logInBTN, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInBTN;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label label3;
        private Label label4;
    }
}