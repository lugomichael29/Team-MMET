namespace SweetBoxInventorySystem.UserControl
{
    partial class ViewItemUC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Lc_FilterViewItem = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lcViewItem = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControlViewItem = new DevExpress.XtraEditors.GroupControl();
            this.gridControlViewItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lc_FilterViewItem)).BeginInit();
            this.Lc_FilterViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlViewItem)).BeginInit();
            this.groupControlViewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlViewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.Lc_FilterViewItem);
            this.layoutControl1.Controls.Add(this.groupControlViewItem);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1192, 891);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Lc_FilterViewItem
            // 
            this.Lc_FilterViewItem.Controls.Add(this.panelControl1);
            this.Lc_FilterViewItem.Location = new System.Drawing.Point(12, 12);
            this.Lc_FilterViewItem.Name = "Lc_FilterViewItem";
            this.Lc_FilterViewItem.Root = this.layoutControlGroup1;
            this.Lc_FilterViewItem.Size = new System.Drawing.Size(1168, 95);
            this.Lc_FilterViewItem.TabIndex = 5;
            this.Lc_FilterViewItem.Text = "layoutControl2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lcViewItem);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1144, 69);
            this.panelControl1.TabIndex = 4;
            // 
            // lcViewItem
            // 
            this.lcViewItem.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcViewItem.Appearance.Options.UseFont = true;
            this.lcViewItem.Appearance.Options.UseTextOptions = true;
            this.lcViewItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lcViewItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lcViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcViewItem.Location = new System.Drawing.Point(2, 2);
            this.lcViewItem.Name = "lcViewItem";
            this.lcViewItem.Size = new System.Drawing.Size(1140, 65);
            this.lcViewItem.TabIndex = 1;
            this.lcViewItem.Text = "VIEW ITEM";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1168, 95);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.panelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1148, 75);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // groupControlViewItem
            // 
            this.groupControlViewItem.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlViewItem.AppearanceCaption.Options.UseFont = true;
            this.groupControlViewItem.Controls.Add(this.gridControlViewItem);
            this.groupControlViewItem.Location = new System.Drawing.Point(12, 111);
            this.groupControlViewItem.Name = "groupControlViewItem";
            this.groupControlViewItem.Size = new System.Drawing.Size(1168, 768);
            this.groupControlViewItem.TabIndex = 4;
            this.groupControlViewItem.Text = "View Item";
            // 
            // gridControlViewItem
            // 
            this.gridControlViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlViewItem.Location = new System.Drawing.Point(2, 24);
            this.gridControlViewItem.MainView = this.gridView1;
            this.gridControlViewItem.Name = "gridControlViewItem";
            this.gridControlViewItem.Size = new System.Drawing.Size(1164, 742);
            this.gridControlViewItem.TabIndex = 0;
            this.gridControlViewItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlViewItem.Load += new System.EventHandler(this.gridControlViewItem_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProductID,
            this.gcProductName,
            this.gcQuantity,
            this.gcDate});
            this.gridView1.GridControl = this.gridControlViewItem;
            this.gridView1.Name = "gridView1";
            // 
            // gcProductID
            // 
            this.gcProductID.Caption = "Product ID";
            this.gcProductID.FieldName = "ProductId";
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.Visible = true;
            this.gcProductID.VisibleIndex = 0;
            this.gcProductID.Width = 62;
            // 
            // gcProductName
            // 
            this.gcProductName.Caption = "Product Name";
            this.gcProductName.FieldName = "ProductName";
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Visible = true;
            this.gcProductName.VisibleIndex = 1;
            this.gcProductName.Width = 360;
            // 
            // gcQuantity
            // 
            this.gcQuantity.Caption = "Quantity";
            this.gcQuantity.Name = "gcQuantity";
            this.gcQuantity.Visible = true;
            this.gcQuantity.VisibleIndex = 2;
            this.gcQuantity.Width = 360;
            // 
            // gcDate
            // 
            this.gcDate.Caption = "Date";
            this.gcDate.Name = "gcDate";
            this.gcDate.Visible = true;
            this.gcDate.VisibleIndex = 3;
            this.gcDate.Width = 365;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1192, 891);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControlViewItem;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 99);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1172, 772);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Lc_FilterViewItem;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1172, 99);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ViewItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ViewItemUC";
            this.Size = new System.Drawing.Size(1192, 891);
            this.Load += new System.EventHandler(this.ViewItemUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lc_FilterViewItem)).EndInit();
            this.Lc_FilterViewItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlViewItem)).EndInit();
            this.groupControlViewItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlViewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl Lc_FilterViewItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lcViewItem;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControlViewItem;
        private DevExpress.XtraGrid.GridControl gridControlViewItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductID;
        private DevExpress.XtraGrid.Columns.GridColumn gcProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gcQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
    }
}
