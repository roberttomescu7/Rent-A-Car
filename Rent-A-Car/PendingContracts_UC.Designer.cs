namespace Rent_A_Car
{
    partial class PendingContracts_UC
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
            startingContractsDGV = new DataGridView();
            clientName = new DataGridViewTextBoxColumn();
            carBrandAndModel = new DataGridViewTextBoxColumn();
            numberPlate = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            endingContractsDGV = new DataGridView();
            clientNameEnd = new DataGridViewTextBoxColumn();
            carBrandAndModelEnd = new DataGridViewTextBoxColumn();
            numberPlateEnd = new DataGridViewTextBoxColumn();
            ok = new DataGridViewButtonColumn();
            hit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)startingContractsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endingContractsDGV).BeginInit();
            SuspendLayout();
            // 
            // startingContractsDGV
            // 
            startingContractsDGV.AllowUserToAddRows = false;
            startingContractsDGV.AllowUserToDeleteRows = false;
            startingContractsDGV.AllowUserToResizeColumns = false;
            startingContractsDGV.AllowUserToResizeRows = false;
            startingContractsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            startingContractsDGV.Columns.AddRange(new DataGridViewColumn[] { clientName, carBrandAndModel, numberPlate, edit, delete });
            startingContractsDGV.Location = new Point(25, 53);
            startingContractsDGV.Margin = new Padding(0);
            startingContractsDGV.Name = "startingContractsDGV";
            startingContractsDGV.RowHeadersWidth = 51;
            startingContractsDGV.RowTemplate.Height = 29;
            startingContractsDGV.Size = new Size(900, 309);
            startingContractsDGV.TabIndex = 0;
            startingContractsDGV.CellContentClick += startingContractsDGV_CellContentClick;
            // 
            // clientName
            // 
            clientName.Frozen = true;
            clientName.HeaderText = "Nume Client";
            clientName.MinimumWidth = 6;
            clientName.Name = "clientName";
            clientName.ReadOnly = true;
            clientName.SortMode = DataGridViewColumnSortMode.NotSortable;
            clientName.Width = 250;
            // 
            // carBrandAndModel
            // 
            carBrandAndModel.Frozen = true;
            carBrandAndModel.HeaderText = "Masina";
            carBrandAndModel.MinimumWidth = 6;
            carBrandAndModel.Name = "carBrandAndModel";
            carBrandAndModel.ReadOnly = true;
            carBrandAndModel.SortMode = DataGridViewColumnSortMode.NotSortable;
            carBrandAndModel.Width = 250;
            // 
            // numberPlate
            // 
            numberPlate.Frozen = true;
            numberPlate.HeaderText = "Numar inmatriculare";
            numberPlate.MinimumWidth = 6;
            numberPlate.Name = "numberPlate";
            numberPlate.ReadOnly = true;
            numberPlate.SortMode = DataGridViewColumnSortMode.NotSortable;
            numberPlate.Width = 200;
            // 
            // edit
            // 
            edit.Frozen = true;
            edit.HeaderText = "Editeaza";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Resizable = DataGridViewTriState.True;
            edit.Width = 73;
            // 
            // delete
            // 
            delete.HeaderText = "Sterge";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Width = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 1;
            label1.Text = "Contracte care incep azi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 387);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(219, 28);
            label2.TabIndex = 3;
            label2.Text = "Contracte care incep azi";
            // 
            // endingContractsDGV
            // 
            endingContractsDGV.AllowUserToAddRows = false;
            endingContractsDGV.AllowUserToDeleteRows = false;
            endingContractsDGV.AllowUserToResizeColumns = false;
            endingContractsDGV.AllowUserToResizeRows = false;
            endingContractsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            endingContractsDGV.Columns.AddRange(new DataGridViewColumn[] { clientNameEnd, carBrandAndModelEnd, numberPlateEnd, ok, hit });
            endingContractsDGV.Location = new Point(25, 415);
            endingContractsDGV.Margin = new Padding(0);
            endingContractsDGV.Name = "endingContractsDGV";
            endingContractsDGV.RowHeadersWidth = 51;
            endingContractsDGV.RowTemplate.Height = 29;
            endingContractsDGV.Size = new Size(900, 309);
            endingContractsDGV.TabIndex = 4;
            endingContractsDGV.CellContentClick += endingContractsDGV_CellContentClick;
            // 
            // clientNameEnd
            // 
            clientNameEnd.Frozen = true;
            clientNameEnd.HeaderText = "Nume Client";
            clientNameEnd.MinimumWidth = 6;
            clientNameEnd.Name = "clientNameEnd";
            clientNameEnd.ReadOnly = true;
            clientNameEnd.SortMode = DataGridViewColumnSortMode.NotSortable;
            clientNameEnd.Width = 250;
            // 
            // carBrandAndModelEnd
            // 
            carBrandAndModelEnd.Frozen = true;
            carBrandAndModelEnd.HeaderText = "Masina";
            carBrandAndModelEnd.MinimumWidth = 6;
            carBrandAndModelEnd.Name = "carBrandAndModelEnd";
            carBrandAndModelEnd.ReadOnly = true;
            carBrandAndModelEnd.SortMode = DataGridViewColumnSortMode.NotSortable;
            carBrandAndModelEnd.Width = 250;
            // 
            // numberPlateEnd
            // 
            numberPlateEnd.Frozen = true;
            numberPlateEnd.HeaderText = "Numar inmatriculare";
            numberPlateEnd.MinimumWidth = 6;
            numberPlateEnd.Name = "numberPlateEnd";
            numberPlateEnd.ReadOnly = true;
            numberPlateEnd.SortMode = DataGridViewColumnSortMode.NotSortable;
            numberPlateEnd.Width = 200;
            // 
            // ok
            // 
            ok.Frozen = true;
            ok.HeaderText = "OK";
            ok.MinimumWidth = 6;
            ok.Name = "ok";
            ok.Resizable = DataGridViewTriState.True;
            ok.Width = 73;
            // 
            // hit
            // 
            hit.HeaderText = "Avarie";
            hit.MinimumWidth = 6;
            hit.Name = "hit";
            hit.Width = 74;
            // 
            // PendingContracts_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(endingContractsDGV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startingContractsDGV);
            Margin = new Padding(0);
            Name = "PendingContracts_UC";
            Size = new Size(950, 750);
            VisibleChanged += PendingContracts_UC_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)startingContractsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)endingContractsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView startingContractsDGV;
        private Label label1;
        private Label label2;
        private DataGridView endingContractsDGV;
        private DataGridViewTextBoxColumn clientName;
        private DataGridViewTextBoxColumn carBrandAndModel;
        private DataGridViewTextBoxColumn numberPlate;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private DataGridViewTextBoxColumn clientNameEnd;
        private DataGridViewTextBoxColumn carBrandAndModelEnd;
        private DataGridViewTextBoxColumn numberPlateEnd;
        private DataGridViewButtonColumn ok;
        private DataGridViewButtonColumn hit;
    }
}
