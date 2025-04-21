namespace SweetBoxInventorySystem.WinForms
{
    partial class AddProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControlAddingProduct = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.texQuantity = new DevExpress.XtraEditors.TextEdit();
            this.texPrice = new DevExpress.XtraEditors.TextEdit();
            this.texProductName = new DevExpress.XtraEditors.TextEdit();
            this.texProductId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddingProduct)).BeginInit();
            this.groupControlAddingProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlProduct);
            this.layoutControl1.Controls.Add(this.groupControlAddingProduct);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(796, 189, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(817, 679);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControlAddingProduct
            // 
            this.groupControlAddingProduct.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlAddingProduct.AppearanceCaption.Options.UseFont = true;
            this.groupControlAddingProduct.Controls.Add(this.btnSave);
            this.groupControlAddingProduct.Controls.Add(this.btnDelete);
            this.groupControlAddingProduct.Controls.Add(this.btnUpdate);
            this.groupControlAddingProduct.Controls.Add(this.btnInsert);
            this.groupControlAddingProduct.Controls.Add(this.texQuantity);
            this.groupControlAddingProduct.Controls.Add(this.texPrice);
            this.groupControlAddingProduct.Controls.Add(this.texProductName);
            this.groupControlAddingProduct.Controls.Add(this.texProductId);
            this.groupControlAddingProduct.Controls.Add(this.labelControl4);
            this.groupControlAddingProduct.Controls.Add(this.labelControl3);
            this.groupControlAddingProduct.Controls.Add(this.labelControl2);
            this.groupControlAddingProduct.Controls.Add(this.labelControl1);
            this.groupControlAddingProduct.Location = new System.Drawing.Point(12, 12);
            this.groupControlAddingProduct.Name = "groupControlAddingProduct";
            this.groupControlAddingProduct.Size = new System.Drawing.Size(793, 326);
            this.groupControlAddingProduct.TabIndex = 4;
            this.groupControlAddingProduct.Text = "PRODUCT ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(588, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(588, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(588, 70);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(183, 32);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            // 
            // texQuantity
            // 
            this.texQuantity.Location = new System.Drawing.Point(139, 180);
            this.texQuantity.Name = "texQuantity";
            this.texQuantity.Size = new System.Drawing.Size(356, 20);
            this.texQuantity.TabIndex = 7;
            // 
            // texPrice
            // 
            this.texPrice.Location = new System.Drawing.Point(139, 144);
            this.texPrice.Name = "texPrice";
            this.texPrice.Size = new System.Drawing.Size(356, 20);
            this.texPrice.TabIndex = 6;
            // 
            // texProductName
            // 
            this.texProductName.Location = new System.Drawing.Point(139, 100);
            this.texProductName.Name = "texProductName";
            this.texProductName.Size = new System.Drawing.Size(356, 20);
            this.texProductName.TabIndex = 5;
            // 
            // texProductId
            // 
            this.texProductId.Location = new System.Drawing.Point(139, 64);
            this.texProductId.Name = "texProductId";
            this.texProductId.Size = new System.Drawing.Size(356, 20);
            this.texProductId.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(63, 183);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Quantity :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(87, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Price :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Product Name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Product ID :";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(817, 679);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControlAddingProduct;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(797, 330);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.Location = new System.Drawing.Point(12, 342);
            this.gridControlProduct.MainView = this.gridView1;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.Size = new System.Drawing.Size(793, 325);
            this.gridControlProduct.TabIndex = 5;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlProduct;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlProduct;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 330);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(797, 329);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(588, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 679);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddingProduct)).EndInit();
            this.groupControlAddingProduct.ResumeLayout(false);
            this.groupControlAddingProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControlAddingProduct;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.TextEdit texQuantity;
        private DevExpress.XtraEditors.TextEdit texPrice;
        private DevExpress.XtraEditors.TextEdit texProductName;
        private DevExpress.XtraEditors.TextEdit texProductId;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}