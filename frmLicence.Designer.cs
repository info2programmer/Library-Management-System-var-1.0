namespace LibraryManagmentPRO
{
    partial class frmLicence
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtLicence = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnActive = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(17, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(192, 43);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "License Key";
            // 
            // txtLicence
            // 
            this.txtLicence.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtLicence.Border.Class = "TextBoxBorder";
            this.txtLicence.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLicence.DisabledBackColor = System.Drawing.Color.White;
            this.txtLicence.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicence.ForeColor = System.Drawing.Color.Black;
            this.txtLicence.Location = new System.Drawing.Point(17, 52);
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.PreventEnterBeep = true;
            this.txtLicence.Size = new System.Drawing.Size(363, 43);
            this.txtLicence.TabIndex = 1;
            this.txtLicence.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtLicence.WatermarkText = "Enter Licence Keys Here";
            this.txtLicence.Enter += new System.EventHandler(this.txtLicence_Enter);
            // 
            // btnActive
            // 
            this.btnActive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnActive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnActive.Location = new System.Drawing.Point(177, 101);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(95, 49);
            this.btnActive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnActive.TabIndex = 19;
            this.btnActive.Text = "&Active";
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnExit.Location = new System.Drawing.Point(285, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 49);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLicence
            // 
            this.ClientSize = new System.Drawing.Size(397, 173);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.txtLicence);
            this.Controls.Add(this.labelX1);
            this.Name = "frmLicence";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLicence";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLicence;
        private DevComponents.DotNetBar.ButtonX btnActive;
        private DevComponents.DotNetBar.ButtonX btnExit;
    }
}