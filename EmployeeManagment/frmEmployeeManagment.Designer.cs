namespace LibreryManagmentSystem.EmployeeManagment
{
    partial class frmEmployeeManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.BookSelfsettingsPageslider = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pgsliderAddbokkSelf = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.lblEdit = new DevComponents.DotNetBar.LabelX();
            this.swtchEdit = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtPhoneNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBankIFC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAccountNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBankName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmboEmployeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtJoinDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtDOB = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.itemMale = new DevComponents.DotNetBar.RadialMenuItem();
            this.itemFemale = new DevComponents.DotNetBar.RadialMenuItem();
            this.itemOthers = new DevComponents.DotNetBar.RadialMenuItem();
            this.txtEmpoyeeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtGender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.txtSearchEmployeeName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmboSearchEmployeeType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkEmployeeType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkEmployeeName = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.DatagridSearchResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BookSelfsettingsPageslider.SuspendLayout();
            this.pgsliderAddbokkSelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJoinDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).BeginInit();
            this.pageSliderPage2.SuspendLayout();
            this.pageSliderPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
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
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
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
            this.btnExit.TabIndex = 0;
            this.btnExit.Tooltip = "Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // BookSelfsettingsPageslider
            // 
            this.BookSelfsettingsPageslider.AnimationTime = 250;
            this.BookSelfsettingsPageslider.BackColor = System.Drawing.Color.White;
            this.BookSelfsettingsPageslider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BookSelfsettingsPageslider.Controls.Add(this.pgsliderAddbokkSelf);
            this.BookSelfsettingsPageslider.Controls.Add(this.pageSliderPage2);
            this.BookSelfsettingsPageslider.Controls.Add(this.pageSliderPage1);
            this.BookSelfsettingsPageslider.ForeColor = System.Drawing.Color.Black;
            this.BookSelfsettingsPageslider.Location = new System.Drawing.Point(5, 71);
            this.BookSelfsettingsPageslider.Name = "BookSelfsettingsPageslider";
            this.BookSelfsettingsPageslider.SelectedPage = this.pgsliderAddbokkSelf;
            this.BookSelfsettingsPageslider.Size = new System.Drawing.Size(679, 376);
            this.BookSelfsettingsPageslider.TabIndex = 15;
            // 
            // pgsliderAddbokkSelf
            // 
            this.pgsliderAddbokkSelf.BackColor = System.Drawing.Color.White;
            this.pgsliderAddbokkSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgsliderAddbokkSelf.Controls.Add(this.lblEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.swtchEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtPhoneNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnUpdate);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtAddress);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBankIFC);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtAccountNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBankName);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmboEmployeType);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtJoinDate);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtDOB);
            this.pgsliderAddbokkSelf.Controls.Add(this.radialMenu1);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtEmpoyeeName);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnSave);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtGender);
            this.pgsliderAddbokkSelf.Controls.Add(this.line1);
            this.pgsliderAddbokkSelf.Controls.Add(this.labelX2);
            this.pgsliderAddbokkSelf.ForeColor = System.Drawing.Color.Black;
            this.pgsliderAddbokkSelf.Location = new System.Drawing.Point(4, 8);
            this.pgsliderAddbokkSelf.Name = "pgsliderAddbokkSelf";
            this.pgsliderAddbokkSelf.Size = new System.Drawing.Size(573, 364);
            this.pgsliderAddbokkSelf.TabIndex = 3;
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.Black;
            this.lblEdit.Location = new System.Drawing.Point(432, 25);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.TabIndex = 53;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Visible = false;
            // 
            // swtchEdit
            // 
            this.swtchEdit.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.swtchEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swtchEdit.ForeColor = System.Drawing.Color.Black;
            this.swtchEdit.Location = new System.Drawing.Point(477, 24);
            this.swtchEdit.Name = "swtchEdit";
            this.swtchEdit.Size = new System.Drawing.Size(77, 22);
            this.swtchEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtchEdit.TabIndex = 52;
            this.swtchEdit.Visible = false;
            this.swtchEdit.ValueChanged += new System.EventHandler(this.swtchEdit_ValueChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPhoneNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPhoneNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPhoneNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPhoneNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPhoneNumber.Border.Class = "TextBoxBorder";
            this.txtPhoneNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhoneNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(15, 198);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PreventEnterBeep = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(268, 39);
            this.txtPhoneNumber.TabIndex = 8;
            this.txtPhoneNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtPhoneNumber.WatermarkText = "Phone Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnUpdate.Location = new System.Drawing.Point(462, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAddress.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAddress.Border.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAddress.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAddress.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.DisabledBackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(14, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(269, 39);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtAddress.WatermarkText = "Address";
            // 
            // txtBankIFC
            // 
            this.txtBankIFC.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBankIFC.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankIFC.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBankIFC.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankIFC.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankIFC.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankIFC.Border.Class = "TextBoxBorder";
            this.txtBankIFC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBankIFC.DisabledBackColor = System.Drawing.Color.White;
            this.txtBankIFC.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankIFC.ForeColor = System.Drawing.Color.Black;
            this.txtBankIFC.Location = new System.Drawing.Point(286, 241);
            this.txtBankIFC.Name = "txtBankIFC";
            this.txtBankIFC.PreventEnterBeep = true;
            this.txtBankIFC.Size = new System.Drawing.Size(268, 39);
            this.txtBankIFC.TabIndex = 11;
            this.txtBankIFC.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBankIFC.WatermarkText = "IFC..";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAccountNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccountNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccountNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccountNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAccountNumber.Border.Class = "TextBoxBorder";
            this.txtAccountNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAccountNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNumber.Location = new System.Drawing.Point(12, 243);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PreventEnterBeep = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(268, 39);
            this.txtAccountNumber.TabIndex = 10;
            this.txtAccountNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtAccountNumber.WatermarkText = "Account Number...";
            // 
            // txtBankName
            // 
            this.txtBankName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBankName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBankName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBankName.Border.Class = "TextBoxBorder";
            this.txtBankName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBankName.DisabledBackColor = System.Drawing.Color.White;
            this.txtBankName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankName.ForeColor = System.Drawing.Color.Black;
            this.txtBankName.Location = new System.Drawing.Point(286, 196);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.PreventEnterBeep = true;
            this.txtBankName.Size = new System.Drawing.Size(268, 39);
            this.txtBankName.TabIndex = 9;
            this.txtBankName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBankName.WatermarkText = "Bank Name";
            // 
            // cmboEmployeType
            // 
            this.cmboEmployeType.DisplayMember = "Text";
            this.cmboEmployeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboEmployeType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboEmployeType.ForeColor = System.Drawing.Color.Black;
            this.cmboEmployeType.FormattingEnabled = true;
            this.cmboEmployeType.ItemHeight = 33;
            this.cmboEmployeType.Location = new System.Drawing.Point(288, 151);
            this.cmboEmployeType.Name = "cmboEmployeType";
            this.cmboEmployeType.Size = new System.Drawing.Size(268, 39);
            this.cmboEmployeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboEmployeType.TabIndex = 7;
            this.cmboEmployeType.WatermarkText = "Select Employee Type...";
            // 
            // txtJoinDate
            // 
            this.txtJoinDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJoinDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtJoinDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJoinDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtJoinDate.ButtonDropDown.Visible = true;
            this.txtJoinDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoinDate.ForeColor = System.Drawing.Color.Black;
            this.txtJoinDate.IsPopupCalendarOpen = false;
            this.txtJoinDate.Location = new System.Drawing.Point(289, 106);
            // 
            // 
            // 
            this.txtJoinDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtJoinDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJoinDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtJoinDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtJoinDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJoinDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.txtJoinDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.txtJoinDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtJoinDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtJoinDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtJoinDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtJoinDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtJoinDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJoinDate.MonthCalendar.TodayButtonVisible = true;
            this.txtJoinDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtJoinDate.Name = "txtJoinDate";
            this.txtJoinDate.Size = new System.Drawing.Size(268, 39);
            this.txtJoinDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtJoinDate.TabIndex = 5;
            this.txtJoinDate.WatermarkText = "Joinning Date :Today";
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDOB.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDOB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDOB.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtDOB.ButtonDropDown.Visible = true;
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.ForeColor = System.Drawing.Color.Black;
            this.txtDOB.IsPopupCalendarOpen = false;
            this.txtDOB.Location = new System.Drawing.Point(14, 108);
            // 
            // 
            // 
            this.txtDOB.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDOB.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDOB.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtDOB.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtDOB.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDOB.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.txtDOB.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.txtDOB.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtDOB.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtDOB.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtDOB.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtDOB.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtDOB.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDOB.MonthCalendar.TodayButtonVisible = true;
            this.txtDOB.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(268, 39);
            this.txtDOB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtDOB.TabIndex = 4;
            this.txtDOB.WatermarkText = "Select Date Of Birth";
            // 
            // radialMenu1
            // 
            this.radialMenu1.BackColor = System.Drawing.Color.White;
            this.radialMenu1.ForeColor = System.Drawing.Color.Black;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemMale,
            this.itemFemale,
            this.itemOthers});
            this.radialMenu1.Location = new System.Drawing.Point(519, 61);
            this.radialMenu1.MenuType = DevComponents.DotNetBar.eRadialMenuType.Circular;
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(38, 39);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 20F;
            this.radialMenu1.TabIndex = 3;
            this.radialMenu1.Text = "radialMenu1";
            this.radialMenu1.ItemClick += new System.EventHandler(this.radialMenu1_ItemClick);
            // 
            // itemMale
            // 
            this.itemMale.Name = "itemMale";
            this.itemMale.Symbol = "";
            this.itemMale.SymbolSize = 20F;
            this.itemMale.Text = "Male";
            this.itemMale.Tooltip = "Male";
            // 
            // itemFemale
            // 
            this.itemFemale.Name = "itemFemale";
            this.itemFemale.Symbol = "";
            this.itemFemale.SymbolSize = 20F;
            this.itemFemale.Text = "Female";
            this.itemFemale.Tooltip = "Female";
            // 
            // itemOthers
            // 
            this.itemOthers.Name = "itemOthers";
            this.itemOthers.Symbol = "";
            this.itemOthers.SymbolSize = 20F;
            this.itemOthers.Text = "Others";
            this.itemOthers.Tooltip = "Others";
            // 
            // txtEmpoyeeName
            // 
            this.txtEmpoyeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmpoyeeName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmpoyeeName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtEmpoyeeName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmpoyeeName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmpoyeeName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmpoyeeName.Border.Class = "TextBoxBorder";
            this.txtEmpoyeeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpoyeeName.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmpoyeeName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpoyeeName.ForeColor = System.Drawing.Color.Black;
            this.txtEmpoyeeName.Location = new System.Drawing.Point(14, 63);
            this.txtEmpoyeeName.Name = "txtEmpoyeeName";
            this.txtEmpoyeeName.PreventEnterBeep = true;
            this.txtEmpoyeeName.Size = new System.Drawing.Size(268, 39);
            this.txtEmpoyeeName.TabIndex = 1;
            this.txtEmpoyeeName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtEmpoyeeName.WatermarkText = "Employee Name";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSave.Location = new System.Drawing.Point(361, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtGender.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtGender.Border.BorderColor = System.Drawing.Color.Black;
            this.txtGender.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtGender.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtGender.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtGender.Border.Class = "TextBoxBorder";
            this.txtGender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGender.DisabledBackColor = System.Drawing.Color.White;
            this.txtGender.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Black;
            this.txtGender.Location = new System.Drawing.Point(289, 63);
            this.txtGender.Name = "txtGender";
            this.txtGender.PreventEnterBeep = true;
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(224, 39);
            this.txtGender.TabIndex = 2;
            this.txtGender.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtGender.WatermarkText = "Gender";
            this.txtGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGender_KeyPress);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(12, 43);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(545, 23);
            this.line1.TabIndex = 10;
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
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(167, 43);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Add New Employee";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.txtSearchEmployeeName);
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.cmboSearchEmployeeType);
            this.pageSliderPage2.Controls.Add(this.chkEmployeeType);
            this.pageSliderPage2.Controls.Add(this.chkEmployeeName);
            this.pageSliderPage2.Controls.Add(this.line2);
            this.pageSliderPage2.Controls.Add(this.labelX3);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // txtSearchEmployeeName
            // 
            this.txtSearchEmployeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchEmployeeName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchEmployeeName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSearchEmployeeName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchEmployeeName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchEmployeeName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchEmployeeName.Border.Class = "TextBoxBorder";
            this.txtSearchEmployeeName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchEmployeeName.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchEmployeeName.Enabled = false;
            this.txtSearchEmployeeName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchEmployeeName.Location = new System.Drawing.Point(285, 72);
            this.txtSearchEmployeeName.Name = "txtSearchEmployeeName";
            this.txtSearchEmployeeName.PreventEnterBeep = true;
            this.txtSearchEmployeeName.Size = new System.Drawing.Size(268, 39);
            this.txtSearchEmployeeName.TabIndex = 24;
            this.txtSearchEmployeeName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearchEmployeeName.WatermarkText = "Employee Name";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSearch.Location = new System.Drawing.Point(458, 297);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmboSearchEmployeeType
            // 
            this.cmboSearchEmployeeType.DisplayMember = "Text";
            this.cmboSearchEmployeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchEmployeeType.Enabled = false;
            this.cmboSearchEmployeeType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchEmployeeType.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchEmployeeType.FormattingEnabled = true;
            this.cmboSearchEmployeeType.ItemHeight = 33;
            this.cmboSearchEmployeeType.Location = new System.Drawing.Point(285, 117);
            this.cmboSearchEmployeeType.Name = "cmboSearchEmployeeType";
            this.cmboSearchEmployeeType.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchEmployeeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchEmployeeType.TabIndex = 19;
            this.cmboSearchEmployeeType.WatermarkText = "Select Employee Type..";
            // 
            // chkEmployeeType
            // 
            this.chkEmployeeType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkEmployeeType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkEmployeeType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployeeType.ForeColor = System.Drawing.Color.Black;
            this.chkEmployeeType.Location = new System.Drawing.Point(16, 117);
            this.chkEmployeeType.Name = "chkEmployeeType";
            this.chkEmployeeType.Size = new System.Drawing.Size(263, 39);
            this.chkEmployeeType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkEmployeeType.TabIndex = 14;
            this.chkEmployeeType.Text = "By Employee Type";
            this.chkEmployeeType.CheckedChanged += new System.EventHandler(this.chkEmployeeType_CheckedChanged);
            // 
            // chkEmployeeName
            // 
            this.chkEmployeeName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkEmployeeName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkEmployeeName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.chkEmployeeName.Location = new System.Drawing.Point(16, 72);
            this.chkEmployeeName.Name = "chkEmployeeName";
            this.chkEmployeeName.Size = new System.Drawing.Size(226, 39);
            this.chkEmployeeName.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkEmployeeName.TabIndex = 13;
            this.chkEmployeeName.Text = "By Employee Name";
            this.chkEmployeeName.CheckedChanged += new System.EventHandler(this.chkEmployeeName_CheckedChanged);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.ForeColor = System.Drawing.Color.Black;
            this.line2.Location = new System.Drawing.Point(3, 43);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(554, 23);
            this.line2.TabIndex = 12;
            this.line2.Text = "line2";
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
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(221, 43);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Short && Search Employees\r\n";
            // 
            // pageSliderPage1
            // 
            this.pageSliderPage1.BackColor = System.Drawing.Color.White;
            this.pageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage1.Controls.Add(this.btnPrint);
            this.pageSliderPage1.Controls.Add(this.DatagridSearchResult);
            this.pageSliderPage1.Controls.Add(this.line3);
            this.pageSliderPage1.Controls.Add(this.labelX4);
            this.pageSliderPage1.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage1.Location = new System.Drawing.Point(1246, 8);
            this.pageSliderPage1.Name = "pageSliderPage1";
            this.pageSliderPage1.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnPrint.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnPrint.Location = new System.Drawing.Point(530, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(38, 36);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.Symbol = "";
            this.btnPrint.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.SymbolSize = 30F;
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Tooltip = "Print This Document";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DatagridSearchResult
            // 
            this.DatagridSearchResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DatagridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridSearchResult.DefaultCellStyle = dataGridViewCellStyle23;
            this.DatagridSearchResult.EnableHeadersVisualStyles = false;
            this.DatagridSearchResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DatagridSearchResult.Location = new System.Drawing.Point(3, 63);
            this.DatagridSearchResult.Name = "DatagridSearchResult";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DatagridSearchResult.Size = new System.Drawing.Size(554, 267);
            this.DatagridSearchResult.TabIndex = 15;
            this.DatagridSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridSearchResult_CellDoubleClick);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.ForeColor = System.Drawing.Color.Black;
            this.line3.Location = new System.Drawing.Point(3, 43);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(554, 23);
            this.line3.TabIndex = 14;
            this.line3.Text = "line3";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(3, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(116, 43);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "Employee List";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(5, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(266, 43);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Employee Managment";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmEmployeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            this.BorderThickness = new DevComponents.DotNetBar.Metro.Thickness(5D, 5D, 3D, 3D);
            this.ClientSize = new System.Drawing.Size(688, 454);
            this.Controls.Add(this.BookSelfsettingsPageslider);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEmployeeManagment";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Managment";
            this.Load += new System.EventHandler(this.frmEmployeeManagment_Load);
            this.BookSelfsettingsPageslider.ResumeLayout(false);
            this.pgsliderAddbokkSelf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtJoinDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOB)).EndInit();
            this.pageSliderPage2.ResumeLayout(false);
            this.pageSliderPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.PageSlider BookSelfsettingsPageslider;
        private DevComponents.DotNetBar.Controls.PageSliderPage pgsliderAddbokkSelf;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmpoyeeName;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGender;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchEmployeeName;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchEmployeeType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkEmployeeType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkEmployeeName;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.RadialMenuItem itemMale;
        private DevComponents.DotNetBar.RadialMenuItem itemFemale;
        private DevComponents.DotNetBar.RadialMenuItem itemOthers;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtJoinDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput txtDOB;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBankIFC;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAccountNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBankName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboEmployeType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPhoneNumber;
        private DevComponents.DotNetBar.LabelX lblEdit;
        private DevComponents.DotNetBar.Controls.SwitchButton swtchEdit;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

