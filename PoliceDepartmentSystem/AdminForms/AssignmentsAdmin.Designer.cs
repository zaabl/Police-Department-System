namespace PoliceDepartmentSystem.AdminForms
{
    partial class AssignmentsAdmin
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
            this.assignmentsAGrid = new System.Windows.Forms.DataGridView();
            this.addAssignment = new System.Windows.Forms.Button();
            this.addAssignment1 = new PoliceDepartmentSystem.AdminForms.AddAssignment();
            this.assignmentViewl11 = new PoliceDepartmentSystem.UserForms.AssignmentViewl1();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsAGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentsAGrid
            // 
            this.assignmentsAGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsAGrid.Location = new System.Drawing.Point(0, 0);
            this.assignmentsAGrid.Name = "assignmentsAGrid";
            this.assignmentsAGrid.RowTemplate.Height = 24;
            this.assignmentsAGrid.Size = new System.Drawing.Size(899, 560);
            this.assignmentsAGrid.TabIndex = 0;
            this.assignmentsAGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignmentsAGrid_CellClick);
            // 
            // addAssignment
            // 
            this.addAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.addAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssignment.Location = new System.Drawing.Point(369, 566);
            this.addAssignment.Name = "addAssignment";
            this.addAssignment.Size = new System.Drawing.Size(136, 29);
            this.addAssignment.TabIndex = 1;
            this.addAssignment.Text = "Add Assignment";
            this.addAssignment.UseVisualStyleBackColor = false;
            this.addAssignment.Click += new System.EventHandler(this.addAssignment_Click);
            // 
            // addAssignment1
            // 
            this.addAssignment1.Location = new System.Drawing.Point(201, 3);
            this.addAssignment1.Name = "addAssignment1";
            this.addAssignment1.Size = new System.Drawing.Size(502, 571);
            this.addAssignment1.TabIndex = 2;
            // 
            // assignmentViewl11
            // 
            this.assignmentViewl11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.assignmentViewl11.CrimeID = "5612";
            this.assignmentViewl11.Location = new System.Drawing.Point(201, 14);
            this.assignmentViewl11.Name = "assignmentViewl11";
            this.assignmentViewl11.Size = new System.Drawing.Size(502, 571);
            this.assignmentViewl11.TabIndex = 3;
            // 
            // AssignmentsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.assignmentViewl11);
            this.Controls.Add(this.addAssignment1);
            this.Controls.Add(this.addAssignment);
            this.Controls.Add(this.assignmentsAGrid);
            this.Name = "AssignmentsAdmin";
            this.Size = new System.Drawing.Size(902, 598);
            this.Load += new System.EventHandler(this.AssignmentsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsAGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentsAGrid;
        private System.Windows.Forms.Button addAssignment;
        private AddAssignment addAssignment1;
        private UserForms.AssignmentViewl1 assignmentViewl11;
    }
}
