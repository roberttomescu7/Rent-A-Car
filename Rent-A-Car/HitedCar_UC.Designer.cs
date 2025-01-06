namespace Rent_A_Car
{
    partial class HitedCar_UC
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
            damagesDGV = new DataGridView();
            damageType = new DataGridViewComboBoxColumn();
            description = new DataGridViewTextBoxColumn();
            saveBTN = new Button();
            label2 = new Label();
            totalL = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)damagesDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 3;
            label1.Text = "Adaugati avarii:";
            // 
            // damagesDGV
            // 
            damagesDGV.AllowUserToResizeColumns = false;
            damagesDGV.AllowUserToResizeRows = false;
            damagesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            damagesDGV.Columns.AddRange(new DataGridViewColumn[] { damageType, description });
            damagesDGV.Location = new Point(25, 53);
            damagesDGV.Margin = new Padding(0);
            damagesDGV.Name = "damagesDGV";
            damagesDGV.RowHeadersWidth = 51;
            damagesDGV.RowTemplate.Height = 29;
            damagesDGV.Size = new Size(900, 600);
            damagesDGV.TabIndex = 2;
            // 
            // damageType
            // 
            damageType.FillWeight = 200F;
            damageType.HeaderText = "Tip Dauna";
            damageType.MinimumWidth = 6;
            damageType.Name = "damageType";
            damageType.Width = 250;
            // 
            // description
            // 
            description.HeaderText = "Descriere";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 597;
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(793, 685);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(132, 29);
            saveBTN.TabIndex = 4;
            saveBTN.Text = "Salveaza";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 689);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 5;
            label2.Text = "Total reparatii:";
            // 
            // totalL
            // 
            totalL.AutoSize = true;
            totalL.Location = new Point(136, 689);
            totalL.Name = "totalL";
            totalL.Size = new Size(17, 20);
            totalL.TabIndex = 6;
            totalL.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 689);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 7;
            label3.Text = "RON";
            // 
            // HitedCar_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(totalL);
            Controls.Add(label2);
            Controls.Add(saveBTN);
            Controls.Add(label1);
            Controls.Add(damagesDGV);
            Name = "HitedCar_UC";
            Size = new Size(950, 750);
            ((System.ComponentModel.ISupportInitialize)damagesDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView damagesDGV;
        private Button saveBTN;
        private Label label2;
        private Label totalL;
        private Label label3;
        private DataGridViewComboBoxColumn damageType;
        private DataGridViewTextBoxColumn description;
    }
}
