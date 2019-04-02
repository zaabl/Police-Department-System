namespace PoliceDepartmentSystem.AdminForms
{
    partial class AssignmentsAdmincs
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
            this.assignmentsAdminGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsAdminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentsAdminGrid
            // 
            this.assignmentsAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsAdminGrid.Location = new System.Drawing.Point(0, 3);
            this.assignmentsAdminGrid.Name = "assignmentsAdminGrid";
            this.assignmentsAdminGrid.RowTemplate.Height = 24;
            this.assignmentsAdminGrid.Size = new System.Drawing.Size(899, 598);
            this.assignmentsAdminGrid.TabIndex = 0;
            // 
            // AssignmentsAdmincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentsAdminGrid);
            this.Name = "AssignmentsAdmincs";
            this.Size = new System.Drawing.Size(902, 598);
            this.Load += new System.EventHandler(this.AssignmentsAdmincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsAdminGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentsAdminGrid;
    }
}
