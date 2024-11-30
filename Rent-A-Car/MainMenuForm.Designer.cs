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
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(clientBtn);
            panel2.Controls.Add(employeeBtn);
            panel2.Controls.SetChildIndex(employeeBtn, 0);
            panel2.Controls.SetChildIndex(clientBtn, 0);
            // 
            // clientBtn
            // 
            clientBtn.BackColor = Color.FromArgb(74, 202, 205);
            clientBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            clientBtn.FlatAppearance.BorderSize = 0;
            clientBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            clientBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            clientBtn.FlatStyle = FlatStyle.Flat;
            clientBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clientBtn.Location = new Point(0, 0);
            clientBtn.Margin = new Padding(0);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(250, 50);
            clientBtn.TabIndex = 0;
            clientBtn.Text = "Client";
            clientBtn.UseVisualStyleBackColor = false;
            clientBtn.Click += clientBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.BackColor = Color.FromArgb(74, 202, 205);
            employeeBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            employeeBtn.FlatAppearance.BorderSize = 0;
            employeeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            employeeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employeeBtn.Location = new Point(0, 50);
            employeeBtn.Margin = new Padding(0);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Size = new Size(250, 50);
            employeeBtn.TabIndex = 1;
            employeeBtn.Text = "Angajat";
            employeeBtn.UseVisualStyleBackColor = false;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car;
            pictureBox1.Location = new Point(579, 267);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1200, 800);
            Controls.Add(pictureBox1);
            Name = "MainMenuForm";
            Text = "MainMenu";
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button clientBtn;
        private Button employeeBtn;
        private PictureBox pictureBox1;
    }
}