﻿namespace Rent_A_Car
{
    partial class ClientAuthForm
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
            label1 = new Label();
            label2 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            signUpLabel = new Label();
            logInBtn = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 111);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Nume utilizator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 162);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(312, 108);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(125, 27);
            usernameTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(312, 159);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(125, 27);
            passwordTB.TabIndex = 3;
            // 
            // signUpLabel
            // 
            signUpLabel.AutoSize = true;
            signUpLabel.Location = new Point(312, 268);
            signUpLabel.Name = "signUpLabel";
            signUpLabel.Size = new Size(113, 20);
            signUpLabel.TabIndex = 4;
            signUpLabel.Text = "Inregistreaza-te";
            signUpLabel.Click += signUpLabel_Click;
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(312, 217);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(125, 29);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Conecteaza-te";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 724);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 6;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // UserAuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(backBtn);
            Controls.Add(logInBtn);
            Controls.Add(signUpLabel);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserAuthForm";
            Text = "UserAuth";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(usernameTB, 0);
            Controls.SetChildIndex(passwordTB, 0);
            Controls.SetChildIndex(signUpLabel, 0);
            Controls.SetChildIndex(logInBtn, 0);
            Controls.SetChildIndex(backBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private Label signUpLabel;
        private Button logInBtn;
        private Button backBtn;
    }
}