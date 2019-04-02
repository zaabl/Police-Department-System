namespace PoliceDepartmentSystem.UserForms
{
    partial class Assignments
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
            this.assignmentGrid = new System.Windows.Forms.DataGridView();
            this.assignmentViewl11 = new PoliceDepartmentSystem.UserForms.AssignmentViewl1();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentGrid
            // 
            this.assignmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentGrid.Location = new System.Drawing.Point(-3, -3);
            this.assignmentGrid.Name = "assignmentGrid";
            this.assignmentGrid.RowTemplate.Height = 24;
            this.assignmentGrid.Size = new System.Drawing.Size(902, 599);
            this.assignmentGrid.TabIndex = 0;
            this.assignmentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignmentGrid_CellClick);
            // 
            // assignmentViewl11
            // 
            this.assignmentViewl11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.assignmentViewl11.CrimeID = null;
            this.assignmentViewl11.Location = new System.Drawing.Point(192, 15);
            this.assignmentViewl11.Name = "assignmentViewl11";
            this.assignmentViewl11.Size = new System.Drawing.Size(502, 571);
            this.assignmentViewl11.TabIndex = 1;
            // 
            // Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentViewl11);
            this.Controls.Add(this.assignmentGrid);
            this.Name = "Assignments";
            this.Size = new System.Drawing.Size(902, 599);
            this.Load += new System.EventHandler(this.Assignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentGrid;
        private AssignmentViewl1 assignmentViewl11;
    }
}
