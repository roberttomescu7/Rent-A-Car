namespace Rent_A_Car
{
    partial class SignUpForm
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
            sendBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            usernameTB = new TextBox();
            passwordTB = new TextBox();
            numberTB = new TextBox();
            streetTB = new TextBox();
            countyTB = new TextBox();
            cityTB = new TextBox();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            cnpTB = new TextBox();
            sexMCB = new CheckBox();
            sexFCB = new CheckBox();
            dateOfBirthDTP = new DateTimePicker();
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
            // sendBtn
            // 
            sendBtn.Location = new Point(574, 726);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(134, 29);
            sendBtn.TabIndex = 1;
            sendBtn.Text = "Inregistreaza-te";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 130);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Nume*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 171);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Prenume*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 209);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "CNP*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 249);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Strada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(339, 293);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 6;
            label5.Text = "Numar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(339, 331);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 7;
            label6.Text = "Oras";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 375);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 8;
            label7.Text = "Judet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 415);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 9;
            label8.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 453);
            label9.Name = "label9";
            label9.Size = new Size(93, 20);
            label9.TabIndex = 10;
            label9.Text = "Data nasterii";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(336, 491);
            label10.Name = "label10";
            label10.Size = new Size(118, 20);
            label10.TabIndex = 11;
            label10.Text = "Nume utilizator*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(339, 532);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 12;
            label11.Text = "Parola*";
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(460, 488);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(125, 27);
            usernameTB.TabIndex = 13;
            usernameTB.TextChanged += usernameTB_TextChanged;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(460, 529);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(125, 27);
            passwordTB.TabIndex = 14;
            passwordTB.TextChanged += passwordTB_TextChanged;
            // 
            // numberTB
            // 
            numberTB.Location = new Point(460, 290);
            numberTB.Name = "numberTB";
            numberTB.Size = new Size(125, 27);
            numberTB.TabIndex = 20;
            // 
            // streetTB
            // 
            streetTB.Location = new Point(460, 246);
            streetTB.Name = "streetTB";
            streetTB.Size = new Size(125, 27);
            streetTB.TabIndex = 19;
            // 
            // countyTB
            // 
            countyTB.Location = new Point(460, 372);
            countyTB.Name = "countyTB";
            countyTB.Size = new Size(125, 27);
            countyTB.TabIndex = 18;
            // 
            // cityTB
            // 
            cityTB.Location = new Point(460, 331);
            cityTB.Name = "cityTB";
            cityTB.Size = new Size(125, 27);
            cityTB.TabIndex = 17;
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(460, 168);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(125, 27);
            firstNameTB.TabIndex = 23;
            firstNameTB.TextChanged += firstNameTB_TextChanged;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(460, 130);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(125, 27);
            lastNameTB.TabIndex = 22;
            lastNameTB.TextChanged += lastNameTB_TextChanged;
            // 
            // cnpTB
            // 
            cnpTB.Location = new Point(460, 206);
            cnpTB.Name = "cnpTB";
            cnpTB.Size = new Size(125, 27);
            cnpTB.TabIndex = 21;
            cnpTB.TextChanged += cnpTB_TextChanged;
            // 
            // sexMCB
            // 
            sexMCB.AutoSize = true;
            sexMCB.Location = new Point(460, 414);
            sexMCB.Name = "sexMCB";
            sexMCB.Size = new Size(89, 24);
            sexMCB.TabIndex = 24;
            sexMCB.Text = "Masculin";
            sexMCB.UseVisualStyleBackColor = true;
            sexMCB.CheckedChanged += sexMCB_CheckedChanged;
            // 
            // sexFCB
            // 
            sexFCB.AutoSize = true;
            sexFCB.Location = new Point(567, 414);
            sexFCB.Name = "sexFCB";
            sexFCB.Size = new Size(83, 24);
            sexFCB.TabIndex = 25;
            sexFCB.Text = "Feminin";
            sexFCB.UseVisualStyleBackColor = true;
            sexFCB.CheckedChanged += sexFCB_CheckedChanged;
            // 
            // dateOfBirthDTP
            // 
            dateOfBirthDTP.Location = new Point(458, 448);
            dateOfBirthDTP.Name = "dateOfBirthDTP";
            dateOfBirthDTP.Size = new Size(192, 27);
            dateOfBirthDTP.TabIndex = 26;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            ClientSize = new Size(1200, 800);
            Controls.Add(backBtn);
            Controls.Add(dateOfBirthDTP);
            Controls.Add(sexFCB);
            Controls.Add(sexMCB);
            Controls.Add(firstNameTB);
            Controls.Add(lastNameTB);
            Controls.Add(cnpTB);
            Controls.Add(numberTB);
            Controls.Add(streetTB);
            Controls.Add(countyTB);
            Controls.Add(cityTB);
            Controls.Add(passwordTB);
            Controls.Add(usernameTB);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sendBtn);
            Name = "SignUpForm";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(sendBtn, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            Controls.SetChildIndex(label11, 0);
            Controls.SetChildIndex(usernameTB, 0);
            Controls.SetChildIndex(passwordTB, 0);
            Controls.SetChildIndex(cityTB, 0);
            Controls.SetChildIndex(countyTB, 0);
            Controls.SetChildIndex(streetTB, 0);
            Controls.SetChildIndex(numberTB, 0);
            Controls.SetChildIndex(cnpTB, 0);
            Controls.SetChildIndex(lastNameTB, 0);
            Controls.SetChildIndex(firstNameTB, 0);
            Controls.SetChildIndex(sexMCB, 0);
            Controls.SetChildIndex(sexFCB, 0);
            Controls.SetChildIndex(dateOfBirthDTP, 0);
            Controls.SetChildIndex(backBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sendBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox usernameTB;
        private TextBox passwordTB;
        private TextBox numberTB;
        private TextBox streetTB;
        private TextBox countyTB;
        private TextBox cityTB;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox cnpTB;
        private CheckBox sexMCB;
        private CheckBox sexFCB;
        private DateTimePicker dateOfBirthDTP;
    }
}