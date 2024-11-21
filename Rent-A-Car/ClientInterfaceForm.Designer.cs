namespace Rent_A_Car
{
    partial class ClientInterfaceForm
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
            appointmentBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1200, 800);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // appointmentBtn
            // 
            appointmentBtn.Location = new Point(452, 240);
            appointmentBtn.Name = "appointmentBtn";
            appointmentBtn.Size = new Size(94, 29);
            appointmentBtn.TabIndex = 2;
            appointmentBtn.Text = "rezervare";
            appointmentBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(452, 296);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "cevgav";
            button2.UseVisualStyleBackColor = true;
            // 
            // ClientInterfaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(button2);
            Controls.Add(appointmentBtn);
            Controls.Add(label1);
            Name = "ClientInterfaceForm";
            Text = "UserInterfaceForm";
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(appointmentBtn, 0);
            Controls.SetChildIndex(button2, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button appointmentBtn;
        private Button button2;
    }
}