namespace LibreryManagmentSystem.Books_Managment
{
    partial class frmBooksManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.DatagridSearchResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.cmboSearchBookTypes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkBookTypes = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtSearchBookNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmboSearchBookSelfNumber = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmboSearchSubCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmboSearchCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkBookSelfNumber = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBookSubCategory = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBookCategory = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkUniqueBookNumber = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pgsliderAddbokkSelf = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.lblEdit = new DevComponents.DotNetBar.LabelX();
            this.swtchEdit = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtUniqueBookSelfNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.txtNumberOfColomn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmboBookSelfName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmboBooksType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbobookSubCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtSerialNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUniqueBookNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNumberOfRow = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmboBooksCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtBookName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.BookSelfsettingsPageslider = new DevComponents.DotNetBar.Controls.PageSlider();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSliderPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).BeginInit();
            this.pageSliderPage2.SuspendLayout();
            this.pgsliderAddbokkSelf.SuspendLayout();
            this.BookSelfsettingsPageslider.SuspendLayout();
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
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
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
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
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
            this.labelX1.Location = new System.Drawing.Point(5, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(266, 43);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Books Managment";
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
            this.DatagridSearchResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.DatagridSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridSearchResult.DefaultCellStyle = dataGridViewCellStyle32;
            this.DatagridSearchResult.EnableHeadersVisualStyles = false;
            this.DatagridSearchResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.DatagridSearchResult.Location = new System.Drawing.Point(3, 63);
            this.DatagridSearchResult.Name = "DatagridSearchResult";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridSearchResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
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
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.White;
            this.labelX4.Location = new System.Drawing.Point(3, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(116, 43);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "BookSelf List";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.cmboSearchBookTypes);
            this.pageSliderPage2.Controls.Add(this.chkBookTypes);
            this.pageSliderPage2.Controls.Add(this.txtSearchBookNumber);
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.cmboSearchBookSelfNumber);
            this.pageSliderPage2.Controls.Add(this.cmboSearchSubCategory);
            this.pageSliderPage2.Controls.Add(this.cmboSearchCategory);
            this.pageSliderPage2.Controls.Add(this.chkBookSelfNumber);
            this.pageSliderPage2.Controls.Add(this.chkBookSubCategory);
            this.pageSliderPage2.Controls.Add(this.chkBookCategory);
            this.pageSliderPage2.Controls.Add(this.chkUniqueBookNumber);
            this.pageSliderPage2.Controls.Add(this.line2);
            this.pageSliderPage2.Controls.Add(this.labelX3);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // cmboSearchBookTypes
            // 
            this.cmboSearchBookTypes.DisplayMember = "Text";
            this.cmboSearchBookTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchBookTypes.Enabled = false;
            this.cmboSearchBookTypes.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchBookTypes.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchBookTypes.FormattingEnabled = true;
            this.cmboSearchBookTypes.ItemHeight = 33;
            this.cmboSearchBookTypes.Location = new System.Drawing.Point(285, 207);
            this.cmboSearchBookTypes.Name = "cmboSearchBookTypes";
            this.cmboSearchBookTypes.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchBookTypes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchBookTypes.TabIndex = 26;
            this.cmboSearchBookTypes.WatermarkText = "Bookis Types..";
            // 
            // chkBookTypes
            // 
            this.chkBookTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkBookTypes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBookTypes.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBookTypes.ForeColor = System.Drawing.Color.White;
            this.chkBookTypes.Location = new System.Drawing.Point(16, 207);
            this.chkBookTypes.Name = "chkBookTypes";
            this.chkBookTypes.Size = new System.Drawing.Size(263, 39);
            this.chkBookTypes.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBookTypes.TabIndex = 25;
            this.chkBookTypes.Text = "By Books Type";
            this.chkBookTypes.CheckedChanged += new System.EventHandler(this.chkBookTypes_CheckedChanged);
            // 
            // txtSearchBookNumber
            // 
            this.txtSearchBookNumber.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtSearchBookNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchBookNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSearchBookNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchBookNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchBookNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSearchBookNumber.Border.Class = "TextBoxBorder";
            this.txtSearchBookNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearchBookNumber.DisabledBackColor = System.Drawing.Color.Black;
            this.txtSearchBookNumber.Enabled = false;
            this.txtSearchBookNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBookNumber.ForeColor = System.Drawing.Color.White;
            this.txtSearchBookNumber.Location = new System.Drawing.Point(285, 72);
            this.txtSearchBookNumber.Name = "txtSearchBookNumber";
            this.txtSearchBookNumber.PreventEnterBeep = true;
            this.txtSearchBookNumber.Size = new System.Drawing.Size(268, 39);
            this.txtSearchBookNumber.TabIndex = 24;
            this.txtSearchBookNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSearchBookNumber.WatermarkText = "Unique Book Number";
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
            // cmboSearchBookSelfNumber
            // 
            this.cmboSearchBookSelfNumber.DisplayMember = "Text";
            this.cmboSearchBookSelfNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchBookSelfNumber.Enabled = false;
            this.cmboSearchBookSelfNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchBookSelfNumber.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchBookSelfNumber.FormattingEnabled = true;
            this.cmboSearchBookSelfNumber.ItemHeight = 33;
            this.cmboSearchBookSelfNumber.Location = new System.Drawing.Point(285, 252);
            this.cmboSearchBookSelfNumber.Name = "cmboSearchBookSelfNumber";
            this.cmboSearchBookSelfNumber.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchBookSelfNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchBookSelfNumber.TabIndex = 22;
            this.cmboSearchBookSelfNumber.WatermarkText = "Book Self Name";
            // 
            // cmboSearchSubCategory
            // 
            this.cmboSearchSubCategory.DisplayMember = "Text";
            this.cmboSearchSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchSubCategory.Enabled = false;
            this.cmboSearchSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchSubCategory.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchSubCategory.FormattingEnabled = true;
            this.cmboSearchSubCategory.ItemHeight = 33;
            this.cmboSearchSubCategory.Location = new System.Drawing.Point(285, 162);
            this.cmboSearchSubCategory.Name = "cmboSearchSubCategory";
            this.cmboSearchSubCategory.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchSubCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchSubCategory.TabIndex = 21;
            this.cmboSearchSubCategory.WatermarkText = "Select SubCategory";
            // 
            // cmboSearchCategory
            // 
            this.cmboSearchCategory.DisplayMember = "Text";
            this.cmboSearchCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchCategory.Enabled = false;
            this.cmboSearchCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchCategory.FormattingEnabled = true;
            this.cmboSearchCategory.ItemHeight = 33;
            this.cmboSearchCategory.Location = new System.Drawing.Point(285, 117);
            this.cmboSearchCategory.Name = "cmboSearchCategory";
            this.cmboSearchCategory.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchCategory.TabIndex = 20;
            this.cmboSearchCategory.WatermarkText = "Book Category";
            // 
            // chkBookSelfNumber
            // 
            this.chkBookSelfNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkBookSelfNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBookSelfNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBookSelfNumber.ForeColor = System.Drawing.Color.White;
            this.chkBookSelfNumber.Location = new System.Drawing.Point(16, 252);
            this.chkBookSelfNumber.Name = "chkBookSelfNumber";
            this.chkBookSelfNumber.Size = new System.Drawing.Size(263, 39);
            this.chkBookSelfNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBookSelfNumber.TabIndex = 17;
            this.chkBookSelfNumber.Text = "By Book Self";
            this.chkBookSelfNumber.CheckedChanged += new System.EventHandler(this.chkBookSelfNumber_CheckedChanged);
            // 
            // chkBookSubCategory
            // 
            this.chkBookSubCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkBookSubCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBookSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBookSubCategory.ForeColor = System.Drawing.Color.White;
            this.chkBookSubCategory.Location = new System.Drawing.Point(16, 162);
            this.chkBookSubCategory.Name = "chkBookSubCategory";
            this.chkBookSubCategory.Size = new System.Drawing.Size(263, 39);
            this.chkBookSubCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBookSubCategory.TabIndex = 16;
            this.chkBookSubCategory.Text = "By Book SubCategory";
            this.chkBookSubCategory.CheckedChanged += new System.EventHandler(this.chkBookSubCategory_CheckedChanged);
            // 
            // chkBookCategory
            // 
            this.chkBookCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkBookCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBookCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBookCategory.ForeColor = System.Drawing.Color.White;
            this.chkBookCategory.Location = new System.Drawing.Point(16, 117);
            this.chkBookCategory.Name = "chkBookCategory";
            this.chkBookCategory.Size = new System.Drawing.Size(263, 39);
            this.chkBookCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBookCategory.TabIndex = 15;
            this.chkBookCategory.Text = "By Book Category";
            this.chkBookCategory.CheckedChanged += new System.EventHandler(this.chkBookCategory_CheckedChanged);
            // 
            // chkUniqueBookNumber
            // 
            this.chkUniqueBookNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.chkUniqueBookNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUniqueBookNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUniqueBookNumber.ForeColor = System.Drawing.Color.White;
            this.chkUniqueBookNumber.Location = new System.Drawing.Point(16, 72);
            this.chkUniqueBookNumber.Name = "chkUniqueBookNumber";
            this.chkUniqueBookNumber.Size = new System.Drawing.Size(272, 39);
            this.chkUniqueBookNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkUniqueBookNumber.TabIndex = 13;
            this.chkUniqueBookNumber.Text = "By Unique Book Number";
            this.chkUniqueBookNumber.CheckedChanged += new System.EventHandler(this.chkUniqueBookNumber_CheckedChanged);
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
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(3, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(185, 43);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Short && Search Books";
            // 
            // pgsliderAddbokkSelf
            // 
            this.pgsliderAddbokkSelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pgsliderAddbokkSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgsliderAddbokkSelf.Controls.Add(this.lblEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.swtchEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtUniqueBookSelfNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnUpdate);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtNumberOfColomn);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmboBookSelfName);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmboBooksType);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmbobookSubCategory);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtSerialNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtUniqueBookNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtNumberOfRow);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmboBooksCategory);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnSave);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBookName);
            this.pgsliderAddbokkSelf.Controls.Add(this.line1);
            this.pgsliderAddbokkSelf.Controls.Add(this.labelX2);
            this.pgsliderAddbokkSelf.ForeColor = System.Drawing.Color.White;
            this.pgsliderAddbokkSelf.Location = new System.Drawing.Point(4, 8);
            this.pgsliderAddbokkSelf.Name = "pgsliderAddbokkSelf";
            this.pgsliderAddbokkSelf.Size = new System.Drawing.Size(573, 364);
            this.pgsliderAddbokkSelf.TabIndex = 3;
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.lblEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(435, 25);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.TabIndex = 51;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Visible = false;
            // 
            // swtchEdit
            // 
            this.swtchEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.swtchEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swtchEdit.ForeColor = System.Drawing.Color.White;
            this.swtchEdit.Location = new System.Drawing.Point(480, 24);
            this.swtchEdit.Name = "swtchEdit";
            this.swtchEdit.Size = new System.Drawing.Size(77, 22);
            this.swtchEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtchEdit.TabIndex = 50;
            this.swtchEdit.Visible = false;
            this.swtchEdit.ValueChanged += new System.EventHandler(this.swtchEdit_ValueChanged);
            // 
            // txtUniqueBookSelfNumber
            // 
            this.txtUniqueBookSelfNumber.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtUniqueBookSelfNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookSelfNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtUniqueBookSelfNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookSelfNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookSelfNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookSelfNumber.Border.Class = "TextBoxBorder";
            this.txtUniqueBookSelfNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUniqueBookSelfNumber.DisabledBackColor = System.Drawing.Color.Black;
            this.txtUniqueBookSelfNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueBookSelfNumber.ForeColor = System.Drawing.Color.White;
            this.txtUniqueBookSelfNumber.Location = new System.Drawing.Point(289, 153);
            this.txtUniqueBookSelfNumber.Name = "txtUniqueBookSelfNumber";
            this.txtUniqueBookSelfNumber.PreventEnterBeep = true;
            this.txtUniqueBookSelfNumber.Size = new System.Drawing.Size(268, 39);
            this.txtUniqueBookSelfNumber.TabIndex = 7;
            this.txtUniqueBookSelfNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUniqueBookSelfNumber.WatermarkText = "Book Self Number";
            this.txtUniqueBookSelfNumber.Leave += new System.EventHandler(this.txtUniqueBookSelfNumber_Leave);
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
            // txtNumberOfColomn
            // 
            this.txtNumberOfColomn.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtNumberOfColomn.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfColomn.Border.BorderColor = System.Drawing.Color.Black;
            this.txtNumberOfColomn.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfColomn.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfColomn.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfColomn.Border.Class = "TextBoxBorder";
            this.txtNumberOfColomn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumberOfColomn.DisabledBackColor = System.Drawing.Color.Black;
            this.txtNumberOfColomn.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfColomn.ForeColor = System.Drawing.Color.White;
            this.txtNumberOfColomn.Location = new System.Drawing.Point(15, 243);
            this.txtNumberOfColomn.Name = "txtNumberOfColomn";
            this.txtNumberOfColomn.PreventEnterBeep = true;
            this.txtNumberOfColomn.Size = new System.Drawing.Size(268, 39);
            this.txtNumberOfColomn.TabIndex = 10;
            this.txtNumberOfColomn.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtNumberOfColomn.WatermarkText = "Number Of Colomn";
            this.txtNumberOfColomn.Leave += new System.EventHandler(this.txtNumberOfColomn_Leave);
            // 
            // cmboBookSelfName
            // 
            this.cmboBookSelfName.DisplayMember = "Text";
            this.cmboBookSelfName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBookSelfName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBookSelfName.ForeColor = System.Drawing.Color.Black;
            this.cmboBookSelfName.FormattingEnabled = true;
            this.cmboBookSelfName.ItemHeight = 33;
            this.cmboBookSelfName.Location = new System.Drawing.Point(15, 198);
            this.cmboBookSelfName.Name = "cmboBookSelfName";
            this.cmboBookSelfName.Size = new System.Drawing.Size(268, 39);
            this.cmboBookSelfName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboBookSelfName.TabIndex = 8;
            this.cmboBookSelfName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboBookSelfName.WatermarkText = "Select Book Self Name";
            // 
            // cmboBooksType
            // 
            this.cmboBooksType.DisplayMember = "Text";
            this.cmboBooksType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBooksType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBooksType.ForeColor = System.Drawing.Color.Black;
            this.cmboBooksType.FormattingEnabled = true;
            this.cmboBooksType.ItemHeight = 33;
            this.cmboBooksType.Location = new System.Drawing.Point(14, 153);
            this.cmboBooksType.Name = "cmboBooksType";
            this.cmboBooksType.Size = new System.Drawing.Size(268, 39);
            this.cmboBooksType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboBooksType.TabIndex = 6;
            this.cmboBooksType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboBooksType.WatermarkText = "Select Book Type";
            // 
            // cmbobookSubCategory
            // 
            this.cmbobookSubCategory.DisplayMember = "Text";
            this.cmbobookSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbobookSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbobookSubCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbobookSubCategory.FormattingEnabled = true;
            this.cmbobookSubCategory.ItemHeight = 33;
            this.cmbobookSubCategory.Location = new System.Drawing.Point(289, 108);
            this.cmbobookSubCategory.Name = "cmbobookSubCategory";
            this.cmbobookSubCategory.Size = new System.Drawing.Size(268, 39);
            this.cmbobookSubCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbobookSubCategory.TabIndex = 5;
            this.cmbobookSubCategory.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmbobookSubCategory.WatermarkText = "Select Book Sub Category";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtSerialNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSerialNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSerialNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSerialNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSerialNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSerialNumber.Border.Class = "TextBoxBorder";
            this.txtSerialNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSerialNumber.DisabledBackColor = System.Drawing.Color.Black;
            this.txtSerialNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.ForeColor = System.Drawing.Color.White;
            this.txtSerialNumber.Location = new System.Drawing.Point(289, 243);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.PreventEnterBeep = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(268, 39);
            this.txtSerialNumber.TabIndex = 11;
            this.txtSerialNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSerialNumber.WatermarkText = "Serial Number";
            // 
            // txtUniqueBookNumber
            // 
            this.txtUniqueBookNumber.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtUniqueBookNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtUniqueBookNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueBookNumber.Border.Class = "TextBoxBorder";
            this.txtUniqueBookNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUniqueBookNumber.DisabledBackColor = System.Drawing.Color.Black;
            this.txtUniqueBookNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueBookNumber.ForeColor = System.Drawing.Color.White;
            this.txtUniqueBookNumber.Location = new System.Drawing.Point(14, 63);
            this.txtUniqueBookNumber.Name = "txtUniqueBookNumber";
            this.txtUniqueBookNumber.PreventEnterBeep = true;
            this.txtUniqueBookNumber.Size = new System.Drawing.Size(268, 39);
            this.txtUniqueBookNumber.TabIndex = 2;
            this.txtUniqueBookNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUniqueBookNumber.WatermarkText = "Unique Book Number";
            this.txtUniqueBookNumber.Leave += new System.EventHandler(this.txtUniqueBookNumber_Leave);
            // 
            // txtNumberOfRow
            // 
            this.txtNumberOfRow.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtNumberOfRow.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfRow.Border.BorderColor = System.Drawing.Color.Black;
            this.txtNumberOfRow.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfRow.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfRow.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNumberOfRow.Border.Class = "TextBoxBorder";
            this.txtNumberOfRow.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNumberOfRow.DisabledBackColor = System.Drawing.Color.Black;
            this.txtNumberOfRow.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRow.ForeColor = System.Drawing.Color.White;
            this.txtNumberOfRow.Location = new System.Drawing.Point(289, 198);
            this.txtNumberOfRow.Name = "txtNumberOfRow";
            this.txtNumberOfRow.PreventEnterBeep = true;
            this.txtNumberOfRow.Size = new System.Drawing.Size(268, 39);
            this.txtNumberOfRow.TabIndex = 9;
            this.txtNumberOfRow.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtNumberOfRow.WatermarkText = "Number Of Row";
            this.txtNumberOfRow.Leave += new System.EventHandler(this.txtNumberOfRow_Leave);
            // 
            // cmboBooksCategory
            // 
            this.cmboBooksCategory.DisplayMember = "Text";
            this.cmboBooksCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboBooksCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBooksCategory.ForeColor = System.Drawing.Color.Black;
            this.cmboBooksCategory.FormattingEnabled = true;
            this.cmboBooksCategory.ItemHeight = 33;
            this.cmboBooksCategory.Location = new System.Drawing.Point(15, 108);
            this.cmboBooksCategory.Name = "cmboBooksCategory";
            this.cmboBooksCategory.Size = new System.Drawing.Size(268, 39);
            this.cmboBooksCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboBooksCategory.TabIndex = 4;
            this.cmboBooksCategory.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboBooksCategory.WatermarkText = "Select Book Category";
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
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtBookName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBookName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookName.Border.Class = "TextBoxBorder";
            this.txtBookName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBookName.DisabledBackColor = System.Drawing.Color.Black;
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.White;
            this.txtBookName.Location = new System.Drawing.Point(289, 63);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PreventEnterBeep = true;
            this.txtBookName.Size = new System.Drawing.Size(268, 39);
            this.txtBookName.TabIndex = 3;
            this.txtBookName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBookName.WatermarkText = "Book Name";
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
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(3, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(167, 43);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Add New Books";
            // 
            // BookSelfsettingsPageslider
            // 
            this.BookSelfsettingsPageslider.AnimationTime = 250;
            this.BookSelfsettingsPageslider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BookSelfsettingsPageslider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BookSelfsettingsPageslider.Controls.Add(this.pgsliderAddbokkSelf);
            this.BookSelfsettingsPageslider.Controls.Add(this.pageSliderPage2);
            this.BookSelfsettingsPageslider.Controls.Add(this.pageSliderPage1);
            this.BookSelfsettingsPageslider.ForeColor = System.Drawing.Color.White;
            this.BookSelfsettingsPageslider.Location = new System.Drawing.Point(5, 71);
            this.BookSelfsettingsPageslider.Name = "BookSelfsettingsPageslider";
            this.BookSelfsettingsPageslider.SelectedPage = this.pgsliderAddbokkSelf;
            this.BookSelfsettingsPageslider.Size = new System.Drawing.Size(679, 376);
            this.BookSelfsettingsPageslider.TabIndex = 13;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmBooksManagment
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
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmBooksManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmBooksManagment_Load);
            this.pageSliderPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridSearchResult)).EndInit();
            this.pageSliderPage2.ResumeLayout(false);
            this.pgsliderAddbokkSelf.ResumeLayout(false);
            this.BookSelfsettingsPageslider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchBookNumber;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchBookSelfNumber;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchCategory;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBookSelfNumber;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBookCategory;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUniqueBookNumber;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSliderPage pgsliderAddbokkSelf;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUniqueBookSelfNumber;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNumberOfColomn;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboBookSelfName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboBooksType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbobookSubCategory;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSerialNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUniqueBookNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNumberOfRow;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboBooksCategory;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookName;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.PageSlider BookSelfsettingsPageslider;
        private DevComponents.DotNetBar.LabelX lblEdit;
        private DevComponents.DotNetBar.Controls.SwitchButton swtchEdit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchSubCategory;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBookSubCategory;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchBookTypes;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBookTypes;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

