namespace PoliceDepartmentSystem.UserForms
{
    partial class Archive
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
            this.archiveGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.archiveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveGrid
            // 
            this.archiveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveGrid.Location = new System.Drawing.Point(3, -3);
            this.archiveGrid.Name = "archiveGrid";
            this.archiveGrid.RowTemplate.Height = 24;
            this.archiveGrid.Size = new System.Drawing.Size(902, 598);
            this.archiveGrid.TabIndex = 0;
            this.archiveGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archiveGrid_CellClick);
            this.archiveGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.archiveGrid_CellContentClick);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.archiveGrid);
            this.Name = "Archive";
            this.Size = new System.Drawing.Size(902, 598);
            this.Load += new System.EventHandler(this.Archive_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.archiveGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView archiveGrid;
    }
}
