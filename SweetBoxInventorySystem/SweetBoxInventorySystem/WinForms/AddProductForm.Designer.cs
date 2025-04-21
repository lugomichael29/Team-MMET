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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControlAddingProduct = new DevExpress.XtraEditors.GroupControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.texProductId = new DevExpress.XtraEditors.TextEdit();
            this.texProductName = new DevExpress.XtraEditors.TextEdit();
            this.texPrice = new DevExpress.XtraEditors.TextEdit();
            this.texQuantity = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddingProduct)).BeginInit();
            this.groupControlAddingProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControlAddingProduct);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(796, 189, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(695, 327);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(695, 327);
            this.Root.TextVisible = false;
            // 
            // groupControlAddingProduct
            // 
            this.groupControlAddingProduct.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlAddingProduct.AppearanceCaption.Options.UseFont = true;
            this.groupControlAddingProduct.Controls.Add(this.simpleButton3);
            this.groupControlAddingProduct.Controls.Add(this.simpleButton2);
            this.groupControlAddingProduct.Controls.Add(this.simpleButton1);
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
            this.groupControlAddingProduct.Size = new System.Drawing.Size(671, 303);
            this.groupControlAddingProduct.TabIndex = 4;
            this.groupControlAddingProduct.Text = "PRODUCT ";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControlAddingProduct;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(675, 307);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Product ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Product Name :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(66, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Price :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(42, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Quantity :";
            // 
            // texProductId
            // 
            this.texProductId.Location = new System.Drawing.Point(118, 67);
            this.texProductId.Name = "texProductId";
            this.texProductId.Size = new System.Drawing.Size(231, 20);
            this.texProductId.TabIndex = 4;
            // 
            // texProductName
            // 
            this.texProductName.Location = new System.Drawing.Point(118, 103);
            this.texProductName.Name = "texProductName";
            this.texProductName.Size = new System.Drawing.Size(231, 20);
            this.texProductName.TabIndex = 5;
            // 
            // texPrice
            // 
            this.texPrice.Location = new System.Drawing.Point(118, 147);
            this.texPrice.Name = "texPrice";
            this.texPrice.Size = new System.Drawing.Size(231, 20);
            this.texPrice.TabIndex = 6;
            // 
            // texQuantity
            // 
            this.texQuantity.Location = new System.Drawing.Point(118, 183);
            this.texQuantity.Name = "texQuantity";
            this.texQuantity.Size = new System.Drawing.Size(231, 20);
            this.texQuantity.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(390, 64);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 32);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Insert";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(390, 114);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(183, 32);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Update";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(390, 180);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(183, 32);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Delete";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 327);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddingProduct)).EndInit();
            this.groupControlAddingProduct.ResumeLayout(false);
            this.groupControlAddingProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texQuantity.Properties)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit texQuantity;
        private DevExpress.XtraEditors.TextEdit texPrice;
        private DevExpress.XtraEditors.TextEdit texProductName;
        private DevExpress.XtraEditors.TextEdit texProductId;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}