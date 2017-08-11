namespace LibreryManagmentSystem.Books_Managment
{
    partial class frmOutGoingBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.BookSelfsettingsPageslider = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pgsliderAddbokkSelf = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.lblBookStatus = new DevComponents.DotNetBar.LabelX();
            this.lblBookName = new DevComponents.DotNetBar.LabelX();
            this.lblMemberName = new DevComponents.DotNetBar.LabelX();
            this.txtBookNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMemberNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ReturnDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.IssuDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.SearchReturnDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.SearchIssudate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtSearchMemberNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.chkReturnDate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkIssuDate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkMemberNumber = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.DatagridSearchResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BookSelfsettingsPageslider.SuspendLayout();
            this.pgsliderAddbokkSelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuDate)).BeginInit();
            this.pageSliderPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchReturnDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIssudate)).BeginInit();
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
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(4, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(155, 43);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "Books Issue";
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
            this.BookSelfsettingsPageslider.Location = new System.Drawing.Point(5, 51);
            this.BookSelfsettingsPageslider.Name = "BookSelfsettingsPageslider";
            this.BookSelfsettingsPageslider.SelectedPage = this.pgsliderAddbokkSelf;
            this.BookSelfsettingsPageslider.Size = new System.Drawing.Size(679, 376);
            this.BookSelfsettingsPageslider.TabIndex = 14;
            // 
            // pgsliderAddbokkSelf
            // 
            this.pgsliderAddbokkSelf.BackColor = System.Drawing.Color.White;
            this.pgsliderAddbokkSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgsliderAddbokkSelf.Controls.Add(this.lblBookStatus);
            this.pgsliderAddbokkSelf.Controls.Add(this.lblBookName);
            this.pgsliderAddbokkSelf.Controls.Add(this.lblMemberName);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBookNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtMemberNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.ReturnDate);
            this.pgsliderAddbokkSelf.Controls.Add(this.IssuDate);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnSave);
            this.pgsliderAddbokkSelf.Controls.Add(this.line1);
            this.pgsliderAddbokkSelf.Controls.Add(this.labelX2);
            this.pgsliderAddbokkSelf.ForeColor = System.Drawing.Color.Black;
            this.pgsliderAddbokkSelf.Location = new System.Drawing.Point(4, 8);
            this.pgsliderAddbokkSelf.Name = "pgsliderAddbokkSelf";
            this.pgsliderAddbokkSelf.Size = new System.Drawing.Size(573, 364);
            this.pgsliderAddbokkSelf.TabIndex = 3;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblBookStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookStatus.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookStatus.ForeColor = System.Drawing.Color.Black;
            this.lblBookStatus.Location = new System.Drawing.Point(30, 262);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(527, 29);
            this.lblBookStatus.Symbol = "";
            this.lblBookStatus.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBookStatus.SymbolSize = 20F;
            this.lblBookStatus.TabIndex = 13;
            this.lblBookStatus.Text = " Book Status :";
            this.lblBookStatus.Visible = false;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblBookName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(30, 225);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(527, 29);
            this.lblBookName.Symbol = "";
            this.lblBookName.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBookName.SymbolSize = 20F;
            this.lblBookName.TabIndex = 12;
            this.lblBookName.Text = " Book Name :";
            this.lblBookName.Visible = false;
            // 
            // lblMemberName
            // 
            this.lblMemberName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lblMemberName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMemberName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.Black;
            this.lblMemberName.Location = new System.Drawing.Point(30, 190);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(527, 29);
            this.lblMemberName.Symbol = "";
            this.lblMemberName.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMemberName.SymbolSize = 20F;
            this.lblMemberName.TabIndex = 11;
            this.lblMemberName.Text = " Member Name :";
            this.lblMemberName.Visible = false;
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBookNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBookNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookNumber.Border.Class = "TextBoxBorder";
            this.txtBookNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBookNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtBookNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookNumber.ForeColor = System.Drawing.Color.Black;
            this.txtBookNumber.Location = new System.Drawing.Point(289, 72);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.PreventEnterBeep = true;
            this.txtBookNumber.Size = new System.Drawing.Size(268, 39);
            this.txtBookNumber.TabIndex = 2;
            this.txtBookNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBookNumber.WatermarkText = "Enter Book Number";
            this.txtBookNumber.Leave += new System.EventHandler(this.txtBookNumber_Leave);
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMemberNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtMemberNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberNumber.Border.Class = "TextBoxBorder";
            this.txtMemberNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMemberNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtMemberNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.txtMemberNumber.Location = new System.Drawing.Point(15, 72);
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.PreventEnterBeep = true;
            this.txtMemberNumber.Size = new System.Drawing.Size(268, 39);
            this.txtMemberNumber.TabIndex = 1;
            this.txtMemberNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtMemberNumber.WatermarkText = "Enter Member Number";
            this.txtMemberNumber.Leave += new System.EventHandler(this.txtMemberNumber_Leave);
            // 
            // ReturnDate
            // 
            this.ReturnDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ReturnDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ReturnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReturnDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.ReturnDate.ButtonDropDown.Visible = true;
            this.ReturnDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.ForeColor = System.Drawing.Color.Black;
            this.ReturnDate.IsPopupCalendarOpen = false;
            this.ReturnDate.Location = new System.Drawing.Point(289, 117);
            // 
            // 
            // 
            this.ReturnDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ReturnDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReturnDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.ReturnDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.ReturnDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReturnDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.ReturnDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.ReturnDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ReturnDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.ReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ReturnDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ReturnDate.MonthCalendar.TodayButtonVisible = true;
            this.ReturnDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(268, 39);
            this.ReturnDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ReturnDate.TabIndex = 4;
            this.ReturnDate.WatermarkText = "Return Date";
            // 
            // IssuDate
            // 
            this.IssuDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.IssuDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IssuDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IssuDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.IssuDate.ButtonDropDown.Visible = true;
            this.IssuDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuDate.ForeColor = System.Drawing.Color.Black;
            this.IssuDate.IsPopupCalendarOpen = false;
            this.IssuDate.Location = new System.Drawing.Point(15, 117);
            // 
            // 
            // 
            this.IssuDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.IssuDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IssuDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.IssuDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.IssuDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IssuDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.IssuDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.IssuDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.IssuDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.IssuDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.IssuDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.IssuDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.IssuDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IssuDate.MonthCalendar.TodayButtonVisible = true;
            this.IssuDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.IssuDate.Name = "IssuDate";
            this.IssuDate.Size = new System.Drawing.Size(268, 39);
            this.IssuDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.IssuDate.TabIndex = 3;
            this.IssuDate.WatermarkText = "Issu Date:Today";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSave.Location = new System.Drawing.Point(462, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.ForeColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(3, 43);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(554, 23);
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
            this.labelX2.Size = new System.Drawing.Size(196, 43);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Add Details";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.SearchReturnDate);
            this.pageSliderPage2.Controls.Add(this.SearchIssudate);
            this.pageSliderPage2.Controls.Add(this.txtSearchMemberNumber);
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.chkReturnDate);
            this.pageSliderPage2.Controls.Add(this.chkIssuDate);
            this.pageSliderPage2.Controls.Add(this.chkMemberNumber);
            this.pageSliderPage2.Controls.Add(this.line2);
            this.pageSliderPage2.Controls.Add(this.labelX3);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // SearchReturnDate
            // 
            this.SearchReturnDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SearchReturnDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.SearchReturnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchReturnDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.SearchReturnDate.ButtonDropDown.Visible = true;
            this.SearchReturnDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchReturnDate.ForeColor = System.Drawing.Color.Black;
            this.SearchReturnDate.IsPopupCalendarOpen = false;
            this.SearchReturnDate.Location = new System.Drawing.Point(285, 162);
            // 
            // 
            // 
            this.SearchReturnDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SearchReturnDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchReturnDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.SearchReturnDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.SearchReturnDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchReturnDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.SearchReturnDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.SearchReturnDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.SearchReturnDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SearchReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.SearchReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.SearchReturnDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.SearchReturnDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchReturnDate.MonthCalendar.TodayButtonVisible = true;
            this.SearchReturnDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.SearchReturnDate.Name = "SearchReturnDate";
            this.SearchReturnDate.Size = new System.Drawing.Size(268, 39);
            this.SearchReturnDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SearchReturnDate.TabIndex = 26;
            this.SearchReturnDate.WatermarkText = "Select Return date";
            // 
            // SearchIssudate
            // 
            this.SearchIssudate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SearchIssudate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.SearchIssudate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchIssudate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.SearchIssudate.ButtonDropDown.Visible = true;
            this.SearchIssudate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIssudate.ForeColor = System.Drawing.Color.Black;
            this.SearchIssudate.IsPopupCalendarOpen = false;
            this.SearchIssudate.Location = new System.Drawing.Point(285, 117);
            // 
            // 
            // 
            this.SearchIssudate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SearchIssudate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchIssudate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.SearchIssudate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.SearchIssudate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchIssudate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 10, 1, 0, 0, 0, 0);
            this.SearchIssudate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.SearchIssudate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.SearchIssudate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.SearchIssudate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.SearchIssudate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.SearchIssudate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.SearchIssudate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchIssudate.MonthCalendar.TodayButtonVisible = true;
            this.SearchIssudate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.SearchIssudate.Name = "SearchIssudate";
            this.SearchIssudate.Size = new System.Drawing.Size(268, 39);
            this.SearchIssudate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.SearchIssudate.TabIndex = 25;
            this.SearchIssudate.WatermarkText = "Select Issu date";
            // 
            // txtSearchMemberNumber
            // 
            this.txtSearchMemberNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearchMemberNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchMemberNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSearchMemberNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchMemberNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchMemberNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchMemberNumber.Border.Class = "TextBoxBorder";
            this.txtSearchMemberNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchMemberNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearchMemberNumber.Enabled = false;
            this.txtSearchMemberNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.txtSearchMemberNumber.Location = new System.Drawing.Point(285, 72);
            this.txtSearchMemberNumber.Name = "txtSearchMemberNumber";
            this.txtSearchMemberNumber.PreventEnterBeep = true;
            this.txtSearchMemberNumber.Size = new System.Drawing.Size(268, 39);
            this.txtSearchMemberNumber.TabIndex = 24;
            this.txtSearchMemberNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearchMemberNumber.WatermarkText = "Enter Member Number";
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
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkReturnDate
            // 
            this.chkReturnDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkReturnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkReturnDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReturnDate.ForeColor = System.Drawing.Color.Black;
            this.chkReturnDate.Location = new System.Drawing.Point(16, 162);
            this.chkReturnDate.Name = "chkReturnDate";
            this.chkReturnDate.Size = new System.Drawing.Size(263, 39);
            this.chkReturnDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkReturnDate.TabIndex = 11;
            this.chkReturnDate.Text = "By Return Date";
            this.chkReturnDate.CheckedChanged += new System.EventHandler(this.chkReturnDate_CheckedChanged);
            // 
            // chkIssuDate
            // 
            this.chkIssuDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkIssuDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIssuDate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIssuDate.ForeColor = System.Drawing.Color.Black;
            this.chkIssuDate.Location = new System.Drawing.Point(16, 117);
            this.chkIssuDate.Name = "chkIssuDate";
            this.chkIssuDate.Size = new System.Drawing.Size(233, 39);
            this.chkIssuDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIssuDate.TabIndex = 10;
            this.chkIssuDate.Text = "By Issu Date";
            this.chkIssuDate.CheckedChanged += new System.EventHandler(this.chkIssuDate_CheckedChanged);
            // 
            // chkMemberNumber
            // 
            this.chkMemberNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkMemberNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMemberNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.chkMemberNumber.Location = new System.Drawing.Point(16, 72);
            this.chkMemberNumber.Name = "chkMemberNumber";
            this.chkMemberNumber.Size = new System.Drawing.Size(263, 39);
            this.chkMemberNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkMemberNumber.TabIndex = 9;
            this.chkMemberNumber.Text = "By Member Number";
            this.chkMemberNumber.CheckedChanged += new System.EventHandler(this.chkMemberNumber_CheckedChanged);
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
            this.labelX3.Size = new System.Drawing.Size(167, 43);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Search";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridSearchResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridSearchResult.EnableHeadersVisualStyles = false;
            this.DatagridSearchResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DatagridSearchResult.Location = new System.Drawing.Point(3, 63);
            this.DatagridSearchResult.Name = "DatagridSearchResult";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridSearchResult.Size = new System.Drawing.Size(554, 267);
            this.DatagridSearchResult.TabIndex = 15;
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
            this.labelX4.Text = "Boo Essue List";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmOutGoingBooks
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
            this.Name = "frmOutGoingBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Out Going Books";
            this.Load += new System.EventHandler(this.frmOutGoingBooks_Load);
            this.BookSelfsettingsPageslider.ResumeLayout(false);
            this.pgsliderAddbokkSelf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuDate)).EndInit();
            this.pageSliderPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchReturnDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIssudate)).EndInit();
            this.pageSliderPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.PageSlider BookSelfsettingsPageslider;
        private DevComponents.DotNetBar.Controls.PageSliderPage pgsliderAddbokkSelf;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkReturnDate;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkIssuDate;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMemberNumber;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput ReturnDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput IssuDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMemberNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchMemberNumber;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput SearchIssudate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput SearchReturnDate;
        private DevComponents.DotNetBar.LabelX lblBookName;
        private DevComponents.DotNetBar.LabelX lblMemberName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DevComponents.DotNetBar.LabelX lblBookStatus;

    }
}

