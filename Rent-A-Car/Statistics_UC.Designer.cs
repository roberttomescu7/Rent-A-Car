namespace Rent_A_Car
{
    partial class Statistics_UC
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
            label1 = new Label();
            statisticsPanel = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(156, 46);
            label1.TabIndex = 0;
            label1.Text = "Statistici";
            // 
            // statisticsPanel
            // 
            statisticsPanel.AutoScroll = true;
            statisticsPanel.Location = new Point(25, 74);
            statisticsPanel.Name = "statisticsPanel";
            statisticsPanel.Size = new Size(900, 654);
            statisticsPanel.TabIndex = 1;
            // 
            // Statistics_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(statisticsPanel);
            Controls.Add(label1);
            Name = "Statistics_UC";
            Size = new Size(950, 750);
            VisibleChanged += Statistics_UC_VisibleChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel statisticsPanel;
    }
}
