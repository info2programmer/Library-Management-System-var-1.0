namespace LibreryManagmentSystem.Settings
{
    partial class frmBookSettings
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
            this.txtBooktype = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEdit = new DevComponents.DotNetBar.LabelX();
            this.swtchEdit = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.txtNote = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBookCategory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtSubCategory = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmboSearchBooksType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmboSearchBookSubCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmboSearchBooksCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkBooksType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkSubCategory = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkBoosCategory = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.DatagridSearchResult = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.line4 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BookSelfsettingsPageslider.SuspendLayout();
            this.pgsliderAddbokkSelf.SuspendLayout();
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
            this.btnExit.TabIndex = 5;
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
            this.labelX1.Location = new System.Drawing.Point(4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(204, 43);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Books Settings";
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
            this.BookSelfsettingsPageslider.Location = new System.Drawing.Point(5, 64);
            this.BookSelfsettingsPageslider.Name = "BookSelfsettingsPageslider";
            this.BookSelfsettingsPageslider.SelectedPage = this.pgsliderAddbokkSelf;
            this.BookSelfsettingsPageslider.Size = new System.Drawing.Size(679, 376);
            this.BookSelfsettingsPageslider.TabIndex = 14;
            // 
            // pgsliderAddbokkSelf
            // 
            this.pgsliderAddbokkSelf.BackColor = System.Drawing.Color.White;
            this.pgsliderAddbokkSelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBooktype);
            this.pgsliderAddbokkSelf.Controls.Add(this.lblEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.swtchEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnUpdate);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtNote);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtBookCategory);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnSave);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtSubCategory);
            this.pgsliderAddbokkSelf.Controls.Add(this.line2);
            this.pgsliderAddbokkSelf.Controls.Add(this.labelX3);
            this.pgsliderAddbokkSelf.ForeColor = System.Drawing.Color.Black;
            this.pgsliderAddbokkSelf.Location = new System.Drawing.Point(4, 8);
            this.pgsliderAddbokkSelf.Name = "pgsliderAddbokkSelf";
            this.pgsliderAddbokkSelf.Size = new System.Drawing.Size(573, 364);
            this.pgsliderAddbokkSelf.TabIndex = 3;
            // 
            // txtBooktype
            // 
            this.txtBooktype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBooktype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBooktype.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBooktype.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBooktype.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBooktype.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBooktype.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBooktype.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBooktype.Border.Class = "TextBoxBorder";
            this.txtBooktype.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBooktype.DisabledBackColor = System.Drawing.Color.White;
            this.txtBooktype.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBooktype.ForeColor = System.Drawing.Color.Black;
            this.txtBooktype.Location = new System.Drawing.Point(14, 134);
            this.txtBooktype.Name = "txtBooktype";
            this.txtBooktype.PreventEnterBeep = true;
            this.txtBooktype.Size = new System.Drawing.Size(268, 39);
            this.txtBooktype.TabIndex = 4;
            this.txtBooktype.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBooktype.WatermarkText = "Books Type...";
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
            this.lblEdit.Location = new System.Drawing.Point(434, 25);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.TabIndex = 49;
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
            this.swtchEdit.Location = new System.Drawing.Point(479, 24);
            this.swtchEdit.Name = "swtchEdit";
            this.swtchEdit.Size = new System.Drawing.Size(77, 22);
            this.swtchEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtchEdit.TabIndex = 48;
            this.swtchEdit.Visible = false;
            this.swtchEdit.ValueChanged += new System.EventHandler(this.swtchEdit_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnUpdate.Location = new System.Drawing.Point(462, 269);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 49);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNote.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNote.Border.BorderColor = System.Drawing.Color.Black;
            this.txtNote.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNote.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNote.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNote.Border.Class = "TextBoxBorder";
            this.txtNote.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNote.DisabledBackColor = System.Drawing.Color.White;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.Location = new System.Drawing.Point(289, 134);
            this.txtNote.Name = "txtNote";
            this.txtNote.PreventEnterBeep = true;
            this.txtNote.Size = new System.Drawing.Size(268, 39);
            this.txtNote.TabIndex = 5;
            this.txtNote.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtNote.WatermarkText = "Notes";
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBookCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBookCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBookCategory.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookCategory.Border.BorderColor = System.Drawing.Color.Black;
            this.txtBookCategory.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookCategory.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookCategory.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtBookCategory.Border.Class = "TextBoxBorder";
            this.txtBookCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBookCategory.DisabledBackColor = System.Drawing.Color.White;
            this.txtBookCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCategory.ForeColor = System.Drawing.Color.Black;
            this.txtBookCategory.Location = new System.Drawing.Point(14, 89);
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.PreventEnterBeep = true;
            this.txtBookCategory.Size = new System.Drawing.Size(268, 39);
            this.txtBookCategory.TabIndex = 2;
            this.txtBookCategory.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtBookCategory.WatermarkText = "Books Category";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSave.Location = new System.Drawing.Point(361, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 49);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSubCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSubCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSubCategory.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSubCategory.Border.BorderColor = System.Drawing.Color.Black;
            this.txtSubCategory.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSubCategory.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSubCategory.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSubCategory.Border.Class = "TextBoxBorder";
            this.txtSubCategory.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSubCategory.DisabledBackColor = System.Drawing.Color.White;
            this.txtSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCategory.ForeColor = System.Drawing.Color.Black;
            this.txtSubCategory.Location = new System.Drawing.Point(289, 89);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.PreventEnterBeep = true;
            this.txtSubCategory.Size = new System.Drawing.Size(268, 39);
            this.txtSubCategory.TabIndex = 3;
            this.txtSubCategory.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtSubCategory.WatermarkText = "Book SubCategory";
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.ForeColor = System.Drawing.Color.Black;
            this.line2.Location = new System.Drawing.Point(3, 43);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(554, 23);
            this.line2.TabIndex = 10;
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
            this.labelX3.Size = new System.Drawing.Size(218, 43);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Add Your Book Settings";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.cmboSearchBooksType);
            this.pageSliderPage2.Controls.Add(this.cmboSearchBookSubCategory);
            this.pageSliderPage2.Controls.Add(this.cmboSearchBooksCategory);
            this.pageSliderPage2.Controls.Add(this.chkBooksType);
            this.pageSliderPage2.Controls.Add(this.chkSubCategory);
            this.pageSliderPage2.Controls.Add(this.chkBoosCategory);
            this.pageSliderPage2.Controls.Add(this.line3);
            this.pageSliderPage2.Controls.Add(this.labelX4);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Color;
            this.btnSearch.Location = new System.Drawing.Point(458, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 49);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "S&earch";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmboSearchBooksType
            // 
            this.cmboSearchBooksType.DisplayMember = "Text";
            this.cmboSearchBooksType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchBooksType.Enabled = false;
            this.cmboSearchBooksType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchBooksType.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchBooksType.FormattingEnabled = true;
            this.cmboSearchBooksType.ItemHeight = 33;
            this.cmboSearchBooksType.Location = new System.Drawing.Point(285, 162);
            this.cmboSearchBooksType.Name = "cmboSearchBooksType";
            this.cmboSearchBooksType.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchBooksType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchBooksType.TabIndex = 20;
            this.cmboSearchBooksType.WatermarkText = "Books Type";
            // 
            // cmboSearchBookSubCategory
            // 
            this.cmboSearchBookSubCategory.DisplayMember = "Text";
            this.cmboSearchBookSubCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchBookSubCategory.Enabled = false;
            this.cmboSearchBookSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchBookSubCategory.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchBookSubCategory.FormattingEnabled = true;
            this.cmboSearchBookSubCategory.ItemHeight = 33;
            this.cmboSearchBookSubCategory.Location = new System.Drawing.Point(285, 117);
            this.cmboSearchBookSubCategory.Name = "cmboSearchBookSubCategory";
            this.cmboSearchBookSubCategory.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchBookSubCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchBookSubCategory.TabIndex = 19;
            this.cmboSearchBookSubCategory.WatermarkText = "Sub-Category";
            // 
            // cmboSearchBooksCategory
            // 
            this.cmboSearchBooksCategory.DisplayMember = "Text";
            this.cmboSearchBooksCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchBooksCategory.Enabled = false;
            this.cmboSearchBooksCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchBooksCategory.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchBooksCategory.FormattingEnabled = true;
            this.cmboSearchBooksCategory.ItemHeight = 33;
            this.cmboSearchBooksCategory.Location = new System.Drawing.Point(285, 72);
            this.cmboSearchBooksCategory.Name = "cmboSearchBooksCategory";
            this.cmboSearchBooksCategory.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchBooksCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchBooksCategory.TabIndex = 18;
            this.cmboSearchBooksCategory.WatermarkText = "Category";
            // 
            // chkBooksType
            // 
            this.chkBooksType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkBooksType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBooksType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBooksType.ForeColor = System.Drawing.Color.Black;
            this.chkBooksType.Location = new System.Drawing.Point(16, 162);
            this.chkBooksType.Name = "chkBooksType";
            this.chkBooksType.Size = new System.Drawing.Size(263, 39);
            this.chkBooksType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBooksType.TabIndex = 15;
            this.chkBooksType.Text = "By Books Type";
            this.chkBooksType.CheckedChanged += new System.EventHandler(this.chkBooksType_CheckedChanged);
            // 
            // chkSubCategory
            // 
            this.chkSubCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkSubCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkSubCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubCategory.ForeColor = System.Drawing.Color.Black;
            this.chkSubCategory.Location = new System.Drawing.Point(16, 117);
            this.chkSubCategory.Name = "chkSubCategory";
            this.chkSubCategory.Size = new System.Drawing.Size(263, 39);
            this.chkSubCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkSubCategory.TabIndex = 14;
            this.chkSubCategory.Text = "By Books SubCategory";
            this.chkSubCategory.CheckedChanged += new System.EventHandler(this.chkSubCategory_CheckedChanged);
            // 
            // chkBoosCategory
            // 
            this.chkBoosCategory.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkBoosCategory.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkBoosCategory.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoosCategory.ForeColor = System.Drawing.Color.Black;
            this.chkBoosCategory.Location = new System.Drawing.Point(16, 72);
            this.chkBoosCategory.Name = "chkBoosCategory";
            this.chkBoosCategory.Size = new System.Drawing.Size(263, 39);
            this.chkBoosCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkBoosCategory.TabIndex = 13;
            this.chkBoosCategory.Text = "By Books Category";
            this.chkBoosCategory.CheckedChanged += new System.EventHandler(this.chkBoosCategory_CheckedChanged);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.ForeColor = System.Drawing.Color.Black;
            this.line3.Location = new System.Drawing.Point(16, 43);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(541, 10);
            this.line3.TabIndex = 12;
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
            this.labelX4.Location = new System.Drawing.Point(16, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(167, 43);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "Search BookSelf";
            // 
            // pageSliderPage1
            // 
            this.pageSliderPage1.BackColor = System.Drawing.Color.White;
            this.pageSliderPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage1.Controls.Add(this.btnPrint);
            this.pageSliderPage1.Controls.Add(this.DatagridSearchResult);
            this.pageSliderPage1.Controls.Add(this.line4);
            this.pageSliderPage1.Controls.Add(this.labelX5);
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
            this.DatagridSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridSearchResult_CellDoubleClick);
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.ForeColor = System.Drawing.Color.Black;
            this.line4.Location = new System.Drawing.Point(3, 43);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(554, 23);
            this.line4.TabIndex = 14;
            this.line4.Text = "line4";
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
            this.labelX5.Location = new System.Drawing.Point(3, 3);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(116, 43);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "BookSelf List";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmBookSettings
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
            this.Name = "frmBookSettings";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmBookSettings_Load);
            this.BookSelfsettingsPageslider.ResumeLayout(false);
            this.pgsliderAddbokkSelf.ResumeLayout(false);
            this.pageSliderPage2.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Controls.TextBoxX txtNote;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBookCategory;
       // private DevComponents.DotNetBar.Controls.TextBoxX txtBookType;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSubCategory;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchBooksType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchBookSubCategory;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchBooksCategory;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBooksType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkSubCategory;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkBoosCategory;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.Line line4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.LabelX lblEdit;
        private DevComponents.DotNetBar.Controls.SwitchButton swtchEdit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBooktype;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

