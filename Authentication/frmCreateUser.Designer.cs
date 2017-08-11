namespace LibreryManagmentSystem.Authentication
{
    partial class frmCreateUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnCreate = new DevComponents.DotNetBar.ButtonX();
            this.cmboUserType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.itemSupar = new DevComponents.Editors.ComboItem();
            this.itemNormal = new DevComponents.Editors.ComboItem();
            this.txtRetypePassord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUniqueUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pageSlider1 = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.SarchDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.chkdate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmboSearchUserType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.chkUserType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtSearchUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.chkUserName = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pageSliderPage3 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.DatagridSearchResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pageSliderPage1.SuspendLayout();
            this.pageSlider1.SuspendLayout();
            this.pageSliderPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SarchDate)).BeginInit();
            this.pageSliderPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(2, -2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(187, 43);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Authentication";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(13, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(167, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Search";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.line1.ForeColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(13, 32);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(536, 10);
            this.line1.TabIndex = 16;
            this.line1.Text = "line1";
            // 
            // pageSliderPage1
            // 
            this.pageSliderPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage1.Controls.Add(this.btnCreate);
            this.pageSliderPage1.Controls.Add(this.cmboUserType);
            this.pageSliderPage1.Controls.Add(this.txtRetypePassord);
            this.pageSliderPage1.Controls.Add(this.txtPassord);
            this.pageSliderPage1.Controls.Add(this.txtUniqueUserName);
            this.pageSliderPage1.Controls.Add(this.txtUserFullName);
            this.pageSliderPage1.Controls.Add(this.line2);
            this.pageSliderPage1.Controls.Add(this.labelX3);
            this.pageSliderPage1.ForeColor = System.Drawing.Color.White;
            this.pageSliderPage1.Location = new System.Drawing.Point(4, 8);
            this.pageSliderPage1.Name = "pageSliderPage1";
            this.pageSliderPage1.Size = new System.Drawing.Size(573, 361);
            this.pageSliderPage1.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnCreate.Location = new System.Drawing.Point(457, 284);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 49);
            this.btnCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "&Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmboUserType
            // 
            this.cmboUserType.DisplayMember = "Text";
            this.cmboUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboUserType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboUserType.ForeColor = System.Drawing.Color.White;
            this.cmboUserType.FormattingEnabled = true;
            this.cmboUserType.ItemHeight = 33;
            this.cmboUserType.Items.AddRange(new object[] {
            this.itemSupar,
            this.itemNormal});
            this.cmboUserType.Location = new System.Drawing.Point(16, 149);
            this.cmboUserType.Name = "cmboUserType";
            this.cmboUserType.Size = new System.Drawing.Size(262, 39);
            this.cmboUserType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboUserType.TabIndex = 31;
            this.cmboUserType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboUserType.WatermarkText = "Select User Type";
            // 
            // itemSupar
            // 
            this.itemSupar.Text = "Super";
            // 
            // itemNormal
            // 
            this.itemNormal.Text = "Normal";
            // 
            // txtRetypePassord
            // 
            this.txtRetypePassord.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtRetypePassord.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtRetypePassord.Border.BorderColor = System.Drawing.Color.Black;
            this.txtRetypePassord.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtRetypePassord.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtRetypePassord.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtRetypePassord.Border.Class = "TextBoxBorder";
            this.txtRetypePassord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRetypePassord.DisabledBackColor = System.Drawing.Color.Black;
            this.txtRetypePassord.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassord.ForeColor = System.Drawing.Color.White;
            this.txtRetypePassord.Location = new System.Drawing.Point(284, 104);
            this.txtRetypePassord.Name = "txtRetypePassord";
            this.txtRetypePassord.PasswordChar = '*';
            this.txtRetypePassord.PreventEnterBeep = true;
            this.txtRetypePassord.Size = new System.Drawing.Size(268, 39);
            this.txtRetypePassord.TabIndex = 30;
            this.txtRetypePassord.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtRetypePassord.WatermarkText = "Re Type Passord";
            this.txtRetypePassord.Leave += new System.EventHandler(this.txtRetypePassord_Leave);
            // 
            // txtPassord
            // 
            this.txtPassord.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtPassord.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassord.Border.BorderColor = System.Drawing.Color.Black;
            this.txtPassord.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassord.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassord.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPassord.Border.Class = "TextBoxBorder";
            this.txtPassord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassord.DisabledBackColor = System.Drawing.Color.Black;
            this.txtPassord.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassord.ForeColor = System.Drawing.Color.White;
            this.txtPassord.Location = new System.Drawing.Point(16, 104);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.PasswordChar = '*';
            this.txtPassord.PreventEnterBeep = true;
            this.txtPassord.Size = new System.Drawing.Size(262, 39);
            this.txtPassord.TabIndex = 29;
            this.txtPassord.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPassord.WatermarkText = "Password";
            // 
            // txtUniqueUserName
            // 
            this.txtUniqueUserName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtUniqueUserName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueUserName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtUniqueUserName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueUserName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueUserName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueUserName.Border.Class = "TextBoxBorder";
            this.txtUniqueUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUniqueUserName.DisabledBackColor = System.Drawing.Color.Black;
            this.txtUniqueUserName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueUserName.ForeColor = System.Drawing.Color.White;
            this.txtUniqueUserName.Location = new System.Drawing.Point(284, 59);
            this.txtUniqueUserName.Name = "txtUniqueUserName";
            this.txtUniqueUserName.PreventEnterBeep = true;
            this.txtUniqueUserName.Size = new System.Drawing.Size(268, 39);
            this.txtUniqueUserName.TabIndex = 28;
            this.txtUniqueUserName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUniqueUserName.WatermarkText = "Enter Unique User Name";
            this.txtUniqueUserName.Leave += new System.EventHandler(this.txtUniqueUserName_Leave);
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtUserFullName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUserFullName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtUserFullName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUserFullName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUserFullName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUserFullName.Border.Class = "TextBoxBorder";
            this.txtUserFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserFullName.DisabledBackColor = System.Drawing.Color.Black;
            this.txtUserFullName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFullName.ForeColor = System.Drawing.Color.White;
            this.txtUserFullName.Location = new System.Drawing.Point(16, 59);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.PreventEnterBeep = true;
            this.txtUserFullName.Size = new System.Drawing.Size(262, 39);
            this.txtUserFullName.TabIndex = 27;
            this.txtUserFullName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUserFullName.WatermarkText = "User Full Name";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.line2.ForeColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(16, 43);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(536, 10);
            this.line2.TabIndex = 14;
            this.line2.Text = "line2";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(16, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(167, 40);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Create User";
            // 
            // pageSlider1
            // 
            this.pageSlider1.AnimationTime = 250;
            this.pageSlider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pageSlider1.Controls.Add(this.pageSliderPage1);
            this.pageSlider1.Controls.Add(this.pageSliderPage2);
            this.pageSlider1.Controls.Add(this.pageSliderPage3);
            this.pageSlider1.ForeColor = System.Drawing.Color.White;
            this.pageSlider1.Location = new System.Drawing.Point(2, 47);
            this.pageSlider1.Name = "pageSlider1";
            this.pageSlider1.SelectedPage = this.pageSliderPage1;
            this.pageSlider1.Size = new System.Drawing.Size(679, 373);
            this.pageSlider1.TabIndex = 10;
            this.pageSlider1.Text = "pageSlider1";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.SarchDate);
            this.pageSliderPage2.Controls.Add(this.chkdate);
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.cmboSearchUserType);
            this.pageSliderPage2.Controls.Add(this.chkUserType);
            this.pageSliderPage2.Controls.Add(this.txtSearchUserName);
            this.pageSliderPage2.Controls.Add(this.chkUserName);
            this.pageSliderPage2.Controls.Add(this.line1);
            this.pageSliderPage2.Controls.Add(this.labelX2);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.White;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 361);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // SarchDate
            // 
            this.SarchDate.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.SarchDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.SarchDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SarchDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.SarchDate.ButtonDropDown.Visible = true;
            this.SarchDate.Enabled = false;
            this.SarchDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SarchDate.ForeColor = System.Drawing.Color.White;
            this.SarchDate.IsPopupCalendarOpen = false;
            this.SarchDate.Location = new System.Drawing.Point(281, 138);
            // 
            // 
            // 
            this.SarchDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SarchDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SarchDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.SarchDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.SarchDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SarchDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.SarchDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.SarchDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.SarchDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SarchDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.SarchDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.SarchDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.SarchDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SarchDate.MonthCalendar.TodayButtonVisible = true;
            this.SarchDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.SarchDate.Name = "SarchDate";
            this.SarchDate.Size = new System.Drawing.Size(268, 39);
            this.SarchDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SarchDate.TabIndex = 35;
            this.SarchDate.WatermarkText = "Select Date";
            // 
            // chkdate
            // 
            this.chkdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkdate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkdate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdate.ForeColor = System.Drawing.Color.White;
            this.chkdate.Location = new System.Drawing.Point(22, 138);
            this.chkdate.Name = "chkdate";
            this.chkdate.Size = new System.Drawing.Size(260, 39);
            this.chkdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkdate.TabIndex = 34;
            this.chkdate.Text = "By Date";
            this.chkdate.CheckedChanged += new System.EventHandler(this.chkdate_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSearch.Location = new System.Drawing.Point(454, 284);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmboSearchUserType
            // 
            this.cmboSearchUserType.DisplayMember = "Text";
            this.cmboSearchUserType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchUserType.Enabled = false;
            this.cmboSearchUserType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchUserType.ForeColor = System.Drawing.Color.White;
            this.cmboSearchUserType.FormattingEnabled = true;
            this.cmboSearchUserType.ItemHeight = 33;
            this.cmboSearchUserType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cmboSearchUserType.Location = new System.Drawing.Point(281, 93);
            this.cmboSearchUserType.Name = "cmboSearchUserType";
            this.cmboSearchUserType.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchUserType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchUserType.TabIndex = 32;
            this.cmboSearchUserType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboSearchUserType.WatermarkText = "Select User Type";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Super";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Normal";
            // 
            // chkUserType
            // 
            this.chkUserType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkUserType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUserType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserType.ForeColor = System.Drawing.Color.White;
            this.chkUserType.Location = new System.Drawing.Point(22, 93);
            this.chkUserType.Name = "chkUserType";
            this.chkUserType.Size = new System.Drawing.Size(260, 39);
            this.chkUserType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkUserType.TabIndex = 30;
            this.chkUserType.Text = "By User Type";
            this.chkUserType.CheckedChanged += new System.EventHandler(this.chkUserType_CheckedChanged);
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtSearchUserName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchUserName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSearchUserName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchUserName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchUserName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchUserName.Border.Class = "TextBoxBorder";
            this.txtSearchUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchUserName.DisabledBackColor = System.Drawing.Color.Black;
            this.txtSearchUserName.Enabled = false;
            this.txtSearchUserName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUserName.ForeColor = System.Drawing.Color.White;
            this.txtSearchUserName.Location = new System.Drawing.Point(281, 48);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.PreventEnterBeep = true;
            this.txtSearchUserName.Size = new System.Drawing.Size(268, 39);
            this.txtSearchUserName.TabIndex = 29;
            this.txtSearchUserName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearchUserName.WatermarkText = "Enter Unique User Name";
            // 
            // chkUserName
            // 
            this.chkUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUserName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUserName.ForeColor = System.Drawing.Color.White;
            this.chkUserName.Location = new System.Drawing.Point(22, 48);
            this.chkUserName.Name = "chkUserName";
            this.chkUserName.Size = new System.Drawing.Size(253, 39);
            this.chkUserName.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkUserName.TabIndex = 17;
            this.chkUserName.Text = "By User Name";
            this.chkUserName.CheckedChanged += new System.EventHandler(this.chkUserName_CheckedChanged);
            // 
            // pageSliderPage3
            // 
            this.pageSliderPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pageSliderPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage3.Controls.Add(this.DatagridSearchResult);
            this.pageSliderPage3.Controls.Add(this.line3);
            this.pageSliderPage3.Controls.Add(this.labelX4);
            this.pageSliderPage3.ForeColor = System.Drawing.Color.White;
            this.pageSliderPage3.Location = new System.Drawing.Point(1246, 8);
            this.pageSliderPage3.Name = "pageSliderPage3";
            this.pageSliderPage3.Size = new System.Drawing.Size(573, 361);
            this.pageSliderPage3.TabIndex = 5;
            // 
            // DatagridSearchResult
            // 
            this.DatagridSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridSearchResult.DefaultCellStyle = dataGridViewCellStyle5;
            this.DatagridSearchResult.EnableHeadersVisualStyles = false;
            this.DatagridSearchResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.DatagridSearchResult.Location = new System.Drawing.Point(15, 56);
            this.DatagridSearchResult.Name = "DatagridSearchResult";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DatagridSearchResult.Size = new System.Drawing.Size(536, 291);
            this.DatagridSearchResult.TabIndex = 19;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.line3.ForeColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(15, 40);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(536, 10);
            this.line3.TabIndex = 18;
            this.line3.Text = "line3";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(15, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(167, 23);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Searched Element";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 430);
            this.Controls.Add(this.pageSlider1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCreateUser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.pageSliderPage1.ResumeLayout(false);
            this.pageSlider1.ResumeLayout(false);
            this.pageSliderPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SarchDate)).EndInit();
            this.pageSliderPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboUserType;
        private DevComponents.Editors.ComboItem itemSupar;
        private DevComponents.Editors.ComboItem itemNormal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRetypePassord;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassord;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUniqueUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserFullName;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSlider pageSlider1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchUserType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUserType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchUserName;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUserName;
        private DevComponents.DotNetBar.ButtonX btnCreate;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage3;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkdate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput SarchDate;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}