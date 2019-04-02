namespace PoliceDepartmentSystem.AdminForms
{
    partial class AddAssignment
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
            this.button4 = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.criminalPhotoLbl = new System.Windows.Forms.PictureBox();
            this.detailsTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crimeIdTxt = new System.Windows.Forms.TextBox();
            this.DateTxt = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.selectedOfficerLbl = new System.Windows.Forms.Label();
            this.officersGrid = new System.Windows.Forms.DataGridView();
            this.officersCross = new System.Windows.Forms.Button();
            this.criminalCross = new System.Windows.Forms.Button();
            this.criminalGrid = new System.Windows.Forms.DataGridView();
            this.selectCriminalLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.criminalPhotoLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::PoliceDepartmentSystem.Properties.Resources.closeIcon;
            this.button4.Location = new System.Drawing.Point(457, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 32);
            this.button4.TabIndex = 54;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(175, 536);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 23);
            this.saveBtn.TabIndex = 52;
            this.saveBtn.Text = "Save Crime";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Criminal";
            // 
            // criminalPhotoLbl
            // 
            this.criminalPhotoLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.criminalPhotoLbl.Location = new System.Drawing.Point(349, 42);
            this.criminalPhotoLbl.Name = "criminalPhotoLbl";
            this.criminalPhotoLbl.Size = new System.Drawing.Size(134, 144);
            this.criminalPhotoLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.criminalPhotoLbl.TabIndex = 43;
            this.criminalPhotoLbl.TabStop = false;
            // 
            // detailsTxt
            // 
            this.detailsTxt.AllowDrop = true;
            this.detailsTxt.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTxt.Location = new System.Drawing.Point(77, 243);
            this.detailsTxt.Multiline = true;
            this.detailsTxt.Name = "detailsTxt";
            this.detailsTxt.Size = new System.Drawing.Size(406, 137);
            this.detailsTxt.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Assigned Officer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Crime ID";
            // 
            // crimeIdTxt
            // 
            this.crimeIdTxt.Location = new System.Drawing.Point(92, 75);
            this.crimeIdTxt.Name = "crimeIdTxt";
            this.crimeIdTxt.Size = new System.Drawing.Size(100, 22);
            this.crimeIdTxt.TabIndex = 55;
            // 
            // DateTxt
            // 
            this.DateTxt.Location = new System.Drawing.Point(92, 103);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.Size = new System.Drawing.Size(100, 22);
            this.DateTxt.TabIndex = 56;
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(92, 131);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(100, 22);
            this.typeTxt.TabIndex = 57;
            // 
            // selectedOfficerLbl
            // 
            this.selectedOfficerLbl.AutoSize = true;
            this.selectedOfficerLbl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedOfficerLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectedOfficerLbl.Location = new System.Drawing.Point(157, 199);
            this.selectedOfficerLbl.Name = "selectedOfficerLbl";
            this.selectedOfficerLbl.Size = new System.Drawing.Size(102, 17);
            this.selectedOfficerLbl.TabIndex = 60;
            this.selectedOfficerLbl.Text = "Click to choose";
            this.selectedOfficerLbl.Click += new System.EventHandler(this.selectedOfficerLbl_Click);
            // 
            // officersGrid
            // 
            this.officersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officersGrid.Location = new System.Drawing.Point(250, 229);
            this.officersGrid.Name = "officersGrid";
            this.officersGrid.RowTemplate.Height = 24;
            this.officersGrid.Size = new System.Drawing.Size(183, 274);
            this.officersGrid.TabIndex = 61;
            this.officersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.officersGrid_CellClick);
            // 
            // officersCross
            // 
            this.officersCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.officersCross.FlatAppearance.BorderSize = 0;
            this.officersCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.officersCross.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officersCross.ForeColor = System.Drawing.Color.White;
            this.officersCross.Image = global::PoliceDepartmentSystem.Properties.Resources.closeIcon;
            this.officersCross.Location = new System.Drawing.Point(410, 199);
            this.officersCross.Name = "officersCross";
            this.officersCross.Size = new System.Drawing.Size(23, 26);
            this.officersCross.TabIndex = 62;
            this.officersCross.UseVisualStyleBackColor = true;
            this.officersCross.Click += new System.EventHandler(this.officersCross_Click);
            // 
            // criminalCross
            // 
            this.criminalCross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.criminalCross.FlatAppearance.BorderSize = 0;
            this.criminalCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.criminalCross.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criminalCross.ForeColor = System.Drawing.Color.White;
            this.criminalCross.Image = global::PoliceDepartmentSystem.Properties.Resources.closeIcon;
            this.criminalCross.Location = new System.Drawing.Point(360, 160);
            this.criminalCross.Name = "criminalCross";
            this.criminalCross.Size = new System.Drawing.Size(23, 26);
            this.criminalCross.TabIndex = 65;
            this.criminalCross.UseVisualStyleBackColor = true;
            this.criminalCross.Click += new System.EventHandler(this.criminalCross_Click);
            // 
            // criminalGrid
            // 
            this.criminalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.criminalGrid.Location = new System.Drawing.Point(190, 182);
            this.criminalGrid.Name = "criminalGrid";
            this.criminalGrid.RowTemplate.Height = 24;
            this.criminalGrid.Size = new System.Drawing.Size(174, 274);
            this.criminalGrid.TabIndex = 64;
            this.criminalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.criminalGrid_CellClick);
            // 
            // selectCriminalLbl
            // 
            this.selectCriminalLbl.AutoSize = true;
            this.selectCriminalLbl.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCriminalLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.selectCriminalLbl.Location = new System.Drawing.Point(106, 162);
            this.selectCriminalLbl.Name = "selectCriminalLbl";
            this.selectCriminalLbl.Size = new System.Drawing.Size(102, 17);
            this.selectCriminalLbl.TabIndex = 63;
            this.selectCriminalLbl.Text = "Click to choose";
            this.selectCriminalLbl.Click += new System.EventHandler(this.selectCriminalLbl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.criminalGrid);
            this.Controls.Add(this.officersCross);
            this.Controls.Add(this.criminalCross);
            this.Controls.Add(this.officersGrid);
            this.Controls.Add(this.selectCriminalLbl);
            this.Controls.Add(this.selectedOfficerLbl);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.crimeIdTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.criminalPhotoLbl);
            this.Controls.Add(this.detailsTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "AddAssignment";
            this.Size = new System.Drawing.Size(502, 571);
            this.Load += new System.EventHandler(this.AddAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.criminalPhotoLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criminalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox criminalPhotoLbl;
        private System.Windows.Forms.TextBox detailsTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox crimeIdTxt;
        private System.Windows.Forms.TextBox DateTxt;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.Label selectedOfficerLbl;
        private System.Windows.Forms.DataGridView officersGrid;
        private System.Windows.Forms.Button officersCross;
        private System.Windows.Forms.Button criminalCross;
        private System.Windows.Forms.DataGridView criminalGrid;
        private System.Windows.Forms.Label selectCriminalLbl;
        private System.Windows.Forms.Button button2;
    }
}
