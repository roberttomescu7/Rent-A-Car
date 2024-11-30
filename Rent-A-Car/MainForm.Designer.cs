namespace Rent_A_Car
{
    partial class MainForm
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
            exitBtn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            backBtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(74, 202, 205);
            exitBtn.BackgroundImageLayout = ImageLayout.None;
            exitBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            exitBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.ForeColor = Color.Black;
            exitBtn.Location = new Point(0, 700);
            exitBtn.Margin = new Padding(0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(250, 50);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 101, 103);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 50);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(59, 162, 164);
            panel2.Controls.Add(backBtn);
            panel2.Controls.Add(exitBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 750);
            panel2.TabIndex = 2;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(74, 202, 205);
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(74, 202, 205);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(201, 239, 240);
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(201, 239, 240);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(0, 650);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(250, 50);
            backBtn.TabIndex = 7;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private Panel panel1;
        protected Panel panel2;
        protected Button backBtn;
    }
}