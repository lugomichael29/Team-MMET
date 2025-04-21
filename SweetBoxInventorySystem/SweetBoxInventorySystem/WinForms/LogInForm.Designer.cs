namespace SweetBoxInventorySystem.WinForms
{
    partial class LogInForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.texUserName = new DevExpress.XtraEditors.TextEdit();
            this.texPassword = new DevExpress.XtraEditors.TextEdit();
            this.BtnLogIn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.texUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // texUserName
            // 
            this.texUserName.Location = new System.Drawing.Point(418, 195);
            this.texUserName.Name = "texUserName";
            this.texUserName.Properties.AdvancedModeOptions.Label = "User Name";
            this.texUserName.Properties.AdvancedModeOptions.LabelAppearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUserName.Properties.AdvancedModeOptions.LabelAppearance.Options.UseFont = true;
            this.texUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texUserName.Properties.Appearance.Options.UseFont = true;
            this.texUserName.Properties.AutoHeight = false;
            this.texUserName.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("texUserName.Properties.ContextImageOptions.SvgImage")));
            this.texUserName.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.texUserName.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.texUserName.Size = new System.Drawing.Size(249, 42);
            this.texUserName.TabIndex = 4;
            // 
            // texPassword
            // 
            this.texPassword.Location = new System.Drawing.Point(418, 254);
            this.texPassword.Name = "texPassword";
            this.texPassword.Properties.AdvancedModeOptions.Label = "Password";
            this.texPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texPassword.Properties.Appearance.Options.UseFont = true;
            this.texPassword.Properties.AutoHeight = false;
            this.texPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tePassword.Properties.ContextImageOptions.SvgImage")));
            this.texPassword.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.texPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.texPassword.Properties.UseSystemPasswordChar = true;
            this.texPassword.Size = new System.Drawing.Size(249, 42);
            this.texPassword.TabIndex = 5;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.Appearance.Options.UseFont = true;
            this.BtnLogIn.Location = new System.Drawing.Point(418, 317);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(249, 35);
            this.BtnLogIn.TabIndex = 6;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(412, 375);
            this.panelControl1.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(410, 371);
            this.pictureEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(467, 150);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 30);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "ADMIN LOGIN";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(480, 34);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(120, 110);
            this.pictureEdit2.TabIndex = 9;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 375);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.texPassword);
            this.Controls.Add(this.texUserName);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.texUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit texUserName;
        private DevExpress.XtraEditors.TextEdit texPassword;
        private DevExpress.XtraEditors.SimpleButton BtnLogIn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}