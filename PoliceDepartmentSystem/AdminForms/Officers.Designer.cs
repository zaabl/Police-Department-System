namespace PoliceDepartmentSystem.AdminForms
{
    partial class Officers
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.addOfficer1 = new PoliceDepartmentSystem.AdminForms.AddOfficer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.officerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.police_Depart_SystemDataSet7 = new PoliceDepartmentSystem.Police_Depart_SystemDataSet7();
            this.officerTableAdapter = new PoliceDepartmentSystem.Police_Depart_SystemDataSet7TableAdapters.OfficerTableAdapter();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colOfficer_ID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colRank = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colOfficer_ID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colRank = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colPhoto = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_Depart_SystemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficer_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(345, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 34);
            this.button4.TabIndex = 24;
            this.button4.Text = "Add Officer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addOfficer1
            // 
            this.addOfficer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addOfficer1.Location = new System.Drawing.Point(175, 71);
            this.addOfficer1.Name = "addOfficer1";
            this.addOfficer1.Size = new System.Drawing.Size(571, 399);
            this.addOfficer1.TabIndex = 25;
            this.addOfficer1.Visible = false;
            this.addOfficer1.Load += new System.EventHandler(this.addOfficer1_Load);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.officerBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(40, 6);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(825, 535);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // officerBindingSource
            // 
            this.officerBindingSource.DataMember = "Officer";
            this.officerBindingSource.DataSource = this.police_Depart_SystemDataSet7;
            // 
            // police_Depart_SystemDataSet7
            // 
            this.police_Depart_SystemDataSet7.DataSetName = "Police_Depart_SystemDataSet7";
            this.police_Depart_SystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officerTableAdapter
            // 
            this.officerTableAdapter.ClearBeforeFill = true;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colOfficer_ID,
            this.colRank,
            this.colName,
            this.colPhoto});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colOfficer_ID
            // 
            this.colOfficer_ID.FieldName = "Officer_ID";
            this.colOfficer_ID.LayoutViewField = this.layoutViewField_colOfficer_ID;
            this.colOfficer_ID.MinWidth = 25;
            this.colOfficer_ID.Name = "colOfficer_ID";
            this.colOfficer_ID.Width = 94;
            // 
            // colRank
            // 
            this.colRank.FieldName = "Rank";
            this.colRank.LayoutViewField = this.layoutViewField_colRank;
            this.colRank.MinWidth = 25;
            this.colRank.Name = "colRank";
            this.colRank.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.LayoutViewField = this.layoutViewField_colName;
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Width = 94;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.LayoutViewField = this.layoutViewField_colPhoto;
            this.colPhoto.MinWidth = 25;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Width = 94;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colOfficer_ID,
            this.layoutViewField_colRank,
            this.layoutViewField_colName,
            this.layoutViewField_colPhoto});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // layoutViewField_colOfficer_ID
            // 
            this.layoutViewField_colOfficer_ID.EditorPreferredWidth = 133;
            this.layoutViewField_colOfficer_ID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colOfficer_ID.Name = "layoutViewField_colOfficer_ID";
            this.layoutViewField_colOfficer_ID.Size = new System.Drawing.Size(330, 26);
            this.layoutViewField_colOfficer_ID.TextSize = new System.Drawing.Size(62, 16);
            // 
            // layoutViewField_colRank
            // 
            this.layoutViewField_colRank.EditorPreferredWidth = 133;
            this.layoutViewField_colRank.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colRank.Name = "layoutViewField_colRank";
            this.layoutViewField_colRank.Size = new System.Drawing.Size(330, 26);
            this.layoutViewField_colRank.TextSize = new System.Drawing.Size(62, 16);
            // 
            // layoutViewField_colName
            // 
            this.layoutViewField_colName.EditorPreferredWidth = 133;
            this.layoutViewField_colName.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_colName.Name = "layoutViewField_colName";
            this.layoutViewField_colName.Size = new System.Drawing.Size(330, 26);
            this.layoutViewField_colName.TextSize = new System.Drawing.Size(62, 16);
            // 
            // layoutViewField_colPhoto
            // 
            this.layoutViewField_colPhoto.EditorPreferredWidth = 133;
            this.layoutViewField_colPhoto.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto";
            this.layoutViewField_colPhoto.Size = new System.Drawing.Size(330, 38);
            this.layoutViewField_colPhoto.StartNewLine = true;
            this.layoutViewField_colPhoto.TextSize = new System.Drawing.Size(62, 16);
            // 
            // Officers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addOfficer1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Officers";
            this.Size = new System.Drawing.Size(905, 598);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police_Depart_SystemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colOfficer_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private AddOfficer addOfficer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource officerBindingSource;
        private Police_Depart_SystemDataSet7 police_Depart_SystemDataSet7;
        private Police_Depart_SystemDataSet7TableAdapters.OfficerTableAdapter officerTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colOfficer_ID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colOfficer_ID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colRank;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colRank;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhoto;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhoto;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
