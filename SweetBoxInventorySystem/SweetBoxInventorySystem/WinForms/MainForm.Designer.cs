namespace SweetBoxInventorySystem.WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlProduct = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlInventory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSupplier = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(259, 759);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlProduct,
            this.accordionControlCustomer,
            this.accordionControlOrder,
            this.accordionControlInventory,
            this.accordionControlSupplier});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "VIEW RECORDS";
            // 
            // accordionControlProduct
            // 
            this.accordionControlProduct.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlProduct.Appearance.Default.Options.UseFont = true;
            this.accordionControlProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement3.ImageOptions.SvgImage")));
            this.accordionControlProduct.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.accordionControlProduct.Name = "accordionControlProduct";
            this.accordionControlProduct.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlProduct.Text = "Product";
            // 
            // accordionControlCustomer
            // 
            this.accordionControlCustomer.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlCustomer.Appearance.Default.Options.UseFont = true;
            this.accordionControlCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement4.ImageOptions.SvgImage")));
            this.accordionControlCustomer.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.accordionControlCustomer.Name = "accordionControlCustomer";
            this.accordionControlCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomer.Text = "Customer";
            // 
            // accordionControlOrder
            // 
            this.accordionControlOrder.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlOrder.Appearance.Default.Options.UseFont = true;
            this.accordionControlOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
            this.accordionControlOrder.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.accordionControlOrder.Name = "accordionControlOrder";
            this.accordionControlOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlOrder.Text = "Order";
            // 
            // accordionControlInventory
            // 
            this.accordionControlInventory.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlInventory.Appearance.Default.Options.UseFont = true;
            this.accordionControlInventory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement6.ImageOptions.SvgImage")));
            this.accordionControlInventory.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.accordionControlInventory.Name = "accordionControlInventory";
            this.accordionControlInventory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlInventory.Text = "Inventory";
            // 
            // accordionControlSupplier
            // 
            this.accordionControlSupplier.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlSupplier.Appearance.Default.Options.UseFont = true;
            this.accordionControlSupplier.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement7.ImageOptions.SvgImage")));
            this.accordionControlSupplier.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.accordionControlSupplier.Name = "accordionControlSupplier";
            this.accordionControlSupplier.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSupplier.Text = "Supplier";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement2.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.accordionControlElement9,
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "MANAGE";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement8.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Add Product";
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Element9";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(259, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(917, 759);
            this.panelControl1.TabIndex = 1;
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 759);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.accordionControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlProduct;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlInventory;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSupplier;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
    }
}