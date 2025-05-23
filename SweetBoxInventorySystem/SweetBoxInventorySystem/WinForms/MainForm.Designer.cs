﻿namespace SweetBoxInventorySystem.WinForms
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
            this.AcViewItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AcAddItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aCAddIngredients = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AcUpdateItem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AcSearchExpiryDates = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.AcFullInventoryOverview = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.acLogOut = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelControlmainForm = new DevExpress.XtraEditors.PanelControl();
            this.panelControlViewItem = new DevExpress.XtraEditors.PanelControl();
            this.accordionControlOrder = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlmainForm)).BeginInit();
            this.panelControlmainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement11,
            this.accordionControlSeparator3,
            this.acLogOut});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(204, 768);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AcViewItem,
            this.AcAddItem,
            this.aCAddIngredients,
            this.AcUpdateItem});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "INVENTORY MANAGEMENT";
            // 
            // AcViewItem
            // 
            this.AcViewItem.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcViewItem.Appearance.Default.Options.UseFont = true;
            this.AcViewItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AcViewItem.ImageOptions.Image")));
            this.AcViewItem.Name = "AcViewItem";
            this.AcViewItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AcViewItem.Text = "View Item";
            this.AcViewItem.Click += new System.EventHandler(this.AcViewItem_Click);
            // 
            // AcAddItem
            // 
            this.AcAddItem.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcAddItem.Appearance.Default.Options.UseFont = true;
            this.AcAddItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AcAddItem.ImageOptions.Image")));
            this.AcAddItem.Name = "AcAddItem";
            this.AcAddItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AcAddItem.Text = "Add Item";
            this.AcAddItem.Click += new System.EventHandler(this.AcAddItem_Click);
            // 
            // aCAddIngredients
            // 
            this.aCAddIngredients.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aCAddIngredients.Appearance.Default.Options.UseFont = true;
            this.aCAddIngredients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aCAddIngredients.ImageOptions.Image")));
            this.aCAddIngredients.Name = "aCAddIngredients";
            this.aCAddIngredients.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aCAddIngredients.Text = "Add Ingredients";
            this.aCAddIngredients.Click += new System.EventHandler(this.aCAddIngredients_Click_1);
            // 
            // AcUpdateItem
            // 
            this.AcUpdateItem.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcUpdateItem.Appearance.Default.Options.UseFont = true;
            this.AcUpdateItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AcUpdateItem.ImageOptions.Image")));
            this.AcUpdateItem.Name = "AcUpdateItem";
            this.AcUpdateItem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AcUpdateItem.Text = "Update Item";
            this.AcUpdateItem.Click += new System.EventHandler(this.AcUpdateItem_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement2.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AcSearchExpiryDates,
            this.accordionControlSeparator2});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "EXPIRY MANAGEMENT";
            // 
            // AcSearchExpiryDates
            // 
            this.AcSearchExpiryDates.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcSearchExpiryDates.Appearance.Default.Options.UseFont = true;
            this.AcSearchExpiryDates.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AcSearchExpiryDates.ImageOptions.Image")));
            this.AcSearchExpiryDates.Name = "AcSearchExpiryDates";
            this.AcSearchExpiryDates.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AcSearchExpiryDates.Text = "Search Expiry Dates";
            this.AcSearchExpiryDates.Click += new System.EventHandler(this.AcSearchExpiryDates_Click);
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement11.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AcFullInventoryOverview,
            this.accordionControlSeparator1});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Text = "ALL PRODUCT";
            // 
            // AcFullInventoryOverview
            // 
            this.AcFullInventoryOverview.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcFullInventoryOverview.Appearance.Default.Options.UseFont = true;
            this.AcFullInventoryOverview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AcFullInventoryOverview.ImageOptions.Image")));
            this.AcFullInventoryOverview.Name = "AcFullInventoryOverview";
            this.AcFullInventoryOverview.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.AcFullInventoryOverview.Text = "Inventory Overview";
            this.AcFullInventoryOverview.Click += new System.EventHandler(this.AcFullInventoryOverview_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // acLogOut
            // 
            this.acLogOut.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acLogOut.Appearance.Default.Options.UseFont = true;
            this.acLogOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("acLogOut.ImageOptions.SvgImage")));
            this.acLogOut.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.acLogOut.Name = "acLogOut";
            this.acLogOut.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acLogOut.Text = "LOG OUT";
            this.acLogOut.Click += new System.EventHandler(this.acLogOut_Click);
            // 
            // panelControlmainForm
            // 
            this.panelControlmainForm.Controls.Add(this.panelControlViewItem);
            this.panelControlmainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlmainForm.Location = new System.Drawing.Point(204, 0);
            this.panelControlmainForm.Name = "panelControlmainForm";
            this.panelControlmainForm.Size = new System.Drawing.Size(995, 768);
            this.panelControlmainForm.TabIndex = 1;
            // 
            // panelControlViewItem
            // 
            this.panelControlViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlViewItem.Location = new System.Drawing.Point(2, 2);
            this.panelControlViewItem.Name = "panelControlViewItem";
            this.panelControlViewItem.Size = new System.Drawing.Size(991, 764);
            this.panelControlViewItem.TabIndex = 0;
            // 
            // accordionControlOrder
            // 
            this.accordionControlOrder.Appearance.Default.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlOrder.Appearance.Default.Options.UseFont = true;
            this.accordionControlOrder.Name = "accordionControlOrder";
            this.accordionControlOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlOrder.Tag = "";
            this.accordionControlOrder.Text = "Order";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 768);
            this.Controls.Add(this.panelControlmainForm);
            this.Controls.Add(this.accordionControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlmainForm)).EndInit();
            this.panelControlmainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlViewItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraEditors.PanelControl panelControlmainForm;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AcViewItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AcAddItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AcUpdateItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlOrder;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AcSearchExpiryDates;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AcFullInventoryOverview;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraEditors.PanelControl panelControlViewItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aCAddIngredients;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acLogOut;
    }
}