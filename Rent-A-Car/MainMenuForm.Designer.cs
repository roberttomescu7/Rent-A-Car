namespace Rent_A_Car
{
    partial class MainMenuForm
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
            clientBtn = new Button();
            employeeBtn = new Button();
            SuspendLayout();
            // 
            // clientBtn
            // 
            clientBtn.Location = new Point(516, 249);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(94, 29);
            clientBtn.TabIndex = 0;
            clientBtn.Text = "Client";
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += clientBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Location = new Point(516, 314);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(94, 29);
            employeeBtn.TabIndex = 1;
            employeeBtn.Text = "Angajat";
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1200, 800);
            Controls.Add(employeeBtn);
            Controls.Add(clientBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button clientBtn;
        private Button employeeBtn;
    }
}