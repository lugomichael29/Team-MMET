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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.texUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // texUserName
            // 
            this.texUserName.Location = new System.Drawing.Point(403, 204);
            this.texUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.texUserName.Size = new System.Drawing.Size(240, 42);
            this.texUserName.TabIndex = 4;
            // 
            // texPassword
            // 
            this.texPassword.Location = new System.Drawing.Point(403, 252);
            this.texPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.texPassword.Name = "texPassword";
            this.texPassword.Properties.AdvancedModeOptions.Label = "Password";
            this.texPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texPassword.Properties.Appearance.Options.UseFont = true;
            this.texPassword.Properties.AutoHeight = false;
            this.texPassword.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("texPassword.Properties.ContextImageOptions.SvgImage")));
            this.texPassword.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.texPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.texPassword.Properties.UseSystemPasswordChar = true;
            this.texPassword.Size = new System.Drawing.Size(240, 47);
            this.texPassword.TabIndex = 5;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.Appearance.Options.UseFont = true;
            this.BtnLogIn.Location = new System.Drawing.Point(403, 333);
            this.BtnLogIn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(240, 39);
            this.BtnLogIn.TabIndex = 6;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(450, 159);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 25);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "ADMIN LOGIN";
            // 
            // LogInForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::SweetBoxInventorySystem.Properties.Resources.Sweet_Box__2_;
            this.ClientSize = new System.Drawing.Size(681, 437);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.texPassword);
            this.Controls.Add(this.texUserName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.texUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit texUserName;
        private DevExpress.XtraEditors.TextEdit texPassword;
        private DevExpress.XtraEditors.SimpleButton BtnLogIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}