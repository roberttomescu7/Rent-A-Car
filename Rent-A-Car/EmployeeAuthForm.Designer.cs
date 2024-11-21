namespace Rent_A_Car
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
            logInBtn = new Button();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            backBtn = new Button();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(364, 203);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(125, 29);
            logInBtn.TabIndex = 10;
            logInBtn.Text = "Conecteaza-te";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(364, 145);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(125, 27);
            passwordTB.TabIndex = 9;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(364, 94);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(125, 27);
            usernameTB.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 148);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 97);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 6;
            label1.Text = "Nume utilizator";
            // 
            // backBtn
            // 
            backBtn.Location = new Point(12, 724);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(94, 29);
            backBtn.TabIndex = 11;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // EmployeeAuthForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(backBtn);
            Controls.Add(logInBtn);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeAuthForm";
            Text = "EmployeeAuth";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(usernameTB, 0);
            Controls.SetChildIndex(passwordTB, 0);
            Controls.SetChildIndex(logInBtn, 0);
            Controls.SetChildIndex(backBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInBtn;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label label2;
        private Label label1;
        private Button backBtn;
    }
}