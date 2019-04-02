namespace PoliceDepartmentSystem.UserForms
{
    partial class AnnouncementUserControl
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRank = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.testDataSet1 = new PoliceDepartmentSystem.testDataSet1();
            this.announcementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.announcementsTableAdapter = new PoliceDepartmentSystem.testDataSet1TableAdapters.AnnouncementsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.announcementsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(695, 493);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colRank,
            this.colPhoto,
            this.colMessage});
            this.tileView1.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 2;
            this.tileView1.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(418, 224);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 47D;
            tableColumnDefinition2.Length.Value = 40D;
            tableColumnDefinition3.Length.Value = 106D;
            tableColumnDefinition4.Length.Value = 225D;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            tableRowDefinition1.Length.Value = 72D;
            tableRowDefinition2.Length.Value = 118D;
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tableSpan1.ColumnIndex = 3;
            tableSpan1.RowSpan = 2;
            tableSpan2.ColumnSpan = 3;
            tableSpan2.RowIndex = 1;
            this.tileView1.TileSpans.Add(tableSpan1);
            this.tileView1.TileSpans.Add(tableSpan2);
            tileViewItemElement1.Column = this.colRank;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colRank";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colName;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "colName";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colPhoto;
            tileViewItemElement3.ColumnIndex = 3;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colPhoto";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.colMessage;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "colMessage";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowIncrementalSearch = false;
            this.colName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.AllowShowHide = false;
            this.colName.OptionsColumn.AllowSize = false;
            this.colName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colName.OptionsColumn.FixedWidth = true;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 94;
            // 
            // colRank
            // 
            this.colRank.FieldName = "Rank";
            this.colRank.MinWidth = 25;
            this.colRank.Name = "colRank";
            this.colRank.OptionsColumn.AllowEdit = false;
            this.colRank.OptionsColumn.AllowFocus = false;
            this.colRank.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRank.OptionsColumn.AllowIncrementalSearch = false;
            this.colRank.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRank.OptionsColumn.AllowMove = false;
            this.colRank.OptionsColumn.AllowShowHide = false;
            this.colRank.OptionsColumn.AllowSize = false;
            this.colRank.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRank.OptionsColumn.FixedWidth = true;
            this.colRank.OptionsColumn.ReadOnly = true;
            this.colRank.Visible = true;
            this.colRank.VisibleIndex = 1;
            this.colRank.Width = 94;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.MinWidth = 25;
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.OptionsColumn.AllowFocus = false;
            this.colPhoto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsColumn.AllowIncrementalSearch = false;
            this.colPhoto.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsColumn.AllowMove = false;
            this.colPhoto.OptionsColumn.AllowShowHide = false;
            this.colPhoto.OptionsColumn.AllowSize = false;
            this.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhoto.OptionsColumn.FixedWidth = true;
            this.colPhoto.OptionsColumn.ReadOnly = true;
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 2;
            this.colPhoto.Width = 94;
            // 
            // colMessage
            // 
            this.colMessage.FieldName = "Message";
            this.colMessage.MinWidth = 25;
            this.colMessage.Name = "colMessage";
            this.colMessage.OptionsColumn.AllowEdit = false;
            this.colMessage.OptionsColumn.AllowFocus = false;
            this.colMessage.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colMessage.OptionsColumn.AllowIncrementalSearch = false;
            this.colMessage.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMessage.OptionsColumn.AllowMove = false;
            this.colMessage.OptionsColumn.AllowShowHide = false;
            this.colMessage.OptionsColumn.AllowSize = false;
            this.colMessage.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMessage.OptionsColumn.FixedWidth = true;
            this.colMessage.OptionsColumn.ReadOnly = true;
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 3;
            this.colMessage.Width = 94;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // announcementsBindingSource
            // 
            this.announcementsBindingSource.DataMember = "Announcements";
            this.announcementsBindingSource.DataSource = this.testDataSet1;
            // 
            // announcementsTableAdapter
            // 
            this.announcementsTableAdapter.ClearBeforeFill = true;
            // 
            // AnnouncementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "AnnouncementUserControl";
            this.Size = new System.Drawing.Size(695, 493);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.announcementsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource announcementsBindingSource;
        private testDataSet1 testDataSet1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colRank;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPhoto;
        private DevExpress.XtraGrid.Columns.TileViewColumn colMessage;
        private testDataSet1TableAdapters.AnnouncementsTableAdapter announcementsTableAdapter;
    }
}
