namespace LibreryManagmentSystem
{
    partial class frmDemo
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.CurrentDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblAmount = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblNotes = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnShowDetails = new DevComponents.DotNetBar.ButtonX();
            this.cmboPayment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDate)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnMinimize.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnMinimize.Location = new System.Drawing.Point(601, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 36);
            this.btnMinimize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMinimize.Symbol = "";
            this.btnMinimize.SymbolSize = 30F;
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.Tooltip = "Minimize";
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnExit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnExit.Location = new System.Drawing.Point(645, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 36);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "";
            this.btnExit.SymbolSize = 30F;
            this.btnExit.TabIndex = 5;
            this.btnExit.Tooltip = "Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CurrentDate
            // 
            this.CurrentDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.CurrentDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.CurrentDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CurrentDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.CurrentDate.ButtonDropDown.Visible = true;
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDate.ForeColor = System.Drawing.Color.Black;
            this.CurrentDate.IsPopupCalendarOpen = false;
            this.CurrentDate.Location = new System.Drawing.Point(434, 130);
            // 
            // 
            // 
            this.CurrentDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.CurrentDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CurrentDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.CurrentDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.CurrentDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CurrentDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.CurrentDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.CurrentDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.CurrentDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.CurrentDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.CurrentDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.CurrentDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.CurrentDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CurrentDate.MonthCalendar.TodayButtonVisible = true;
            this.CurrentDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(208, 39);
            this.CurrentDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CurrentDate.TabIndex = 75;
            this.CurrentDate.Visible = false;
            this.CurrentDate.WatermarkText = "Issue Date : Today";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(130, 289);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(423, 36);
            this.lblAmount.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblAmount.TabIndex = 74;
            this.lblAmount.Text = "Notes :";
            this.lblAmount.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(46, 289);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(78, 36);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 73;
            this.labelX3.Text = "Amount :";
            this.labelX3.Visible = false;
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblNotes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(130, 247);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(423, 36);
            this.lblNotes.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblNotes.TabIndex = 72;
            this.lblNotes.Text = "Notes :";
            this.lblNotes.Visible = false;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(60, 247);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 36);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX5.TabIndex = 71;
            this.labelX5.Text = "Notes :";
            this.labelX5.Visible = false;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnShowDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnShowDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowDetails.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnShowDetails.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnShowDetails.Location = new System.Drawing.Point(334, 192);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(38, 36);
            this.btnShowDetails.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowDetails.Symbol = "";
            this.btnShowDetails.SymbolSize = 30F;
            this.btnShowDetails.TabIndex = 70;
            this.btnShowDetails.Tooltip = "Show";
            // 
            // cmboPayment
            // 
            this.cmboPayment.DisplayMember = "Text";
            this.cmboPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboPayment.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboPayment.ForeColor = System.Drawing.Color.Black;
            this.cmboPayment.FormattingEnabled = true;
            this.cmboPayment.ItemHeight = 33;
            this.cmboPayment.Location = new System.Drawing.Point(60, 192);
            this.cmboPayment.Name = "cmboPayment";
            this.cmboPayment.Size = new System.Drawing.Size(268, 39);
            this.cmboPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboPayment.TabIndex = 69;
            this.cmboPayment.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboPayment.WatermarkText = "Select Payment";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(60, 175);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(582, 11);
            this.line1.TabIndex = 68;
            this.line1.Text = "line1";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(60, 129);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(182, 40);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 67;
            this.labelX2.Text = "Give Payments";
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            this.BorderThickness = new DevComponents.DotNetBar.Metro.Thickness(5D, 5D, 3D, 3D);
            this.ClientSize = new System.Drawing.Size(688, 454);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.cmboPayment);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput CurrentDate;
        private DevComponents.DotNetBar.LabelX lblAmount;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lblNotes;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnShowDetails;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboPayment;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX2;

    }
}

