namespace LibreryManagmentSystem.MemberManagment
{
    partial class frmMember
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
            this.BookSelfsettingsPageslider = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pgsliderAddbokkSelf = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.txtAdharNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEdit = new DevComponents.DotNetBar.LabelX();
            this.swtchEdit = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtMobileNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtVoterCardNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUniqueMemberNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmboMemberType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtMemberName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.txtSearchMemberNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cmboSearchMemberType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.chkMemberType = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkUniqueMemberNumber = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.btnMinimize.Text = " ";
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
            this.pgsliderAddbokkSelf.Controls.Add(this.txtAdharNo);
            this.pgsliderAddbokkSelf.Controls.Add(this.lblEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.swtchEdit);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtMobileNo);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnUpdate);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtAddress);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtVoterCardNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtUniqueMemberNumber);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtEmail);
            this.pgsliderAddbokkSelf.Controls.Add(this.cmboMemberType);
            this.pgsliderAddbokkSelf.Controls.Add(this.btnSave);
            this.pgsliderAddbokkSelf.Controls.Add(this.txtMemberName);
            this.pgsliderAddbokkSelf.Controls.Add(this.line1);
            this.pgsliderAddbokkSelf.Controls.Add(this.labelX2);
            this.pgsliderAddbokkSelf.ForeColor = System.Drawing.Color.Black;
            this.pgsliderAddbokkSelf.Location = new System.Drawing.Point(4, 8);
            this.pgsliderAddbokkSelf.Name = "pgsliderAddbokkSelf";
            this.pgsliderAddbokkSelf.Size = new System.Drawing.Size(573, 364);
            this.pgsliderAddbokkSelf.TabIndex = 3;
            // 
            // txtAdharNo
            // 
            this.txtAdharNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAdharNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAdharNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtAdharNo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAdharNo.Border.BorderColor = System.Drawing.Color.Black;
            this.txtAdharNo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAdharNo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAdharNo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtAdharNo.Border.Class = "TextBoxBorder";
            this.txtAdharNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAdharNo.DisabledBackColor = System.Drawing.Color.White;
            this.txtAdharNo.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdharNo.ForeColor = System.Drawing.Color.Black;
            this.txtAdharNo.Location = new System.Drawing.Point(289, 198);
            this.txtAdharNo.Name = "txtAdharNo";
            this.txtAdharNo.PreventEnterBeep = true;
            this.txtAdharNo.Size = new System.Drawing.Size(268, 39);
            this.txtAdharNo.TabIndex = 8;
            this.txtAdharNo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtAdharNo.WatermarkText = "Addhar Number";
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
            this.lblEdit.Location = new System.Drawing.Point(435, 25);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(39, 21);
            this.lblEdit.TabIndex = 51;
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
            this.swtchEdit.Location = new System.Drawing.Point(480, 24);
            this.swtchEdit.Name = "swtchEdit";
            this.swtchEdit.Size = new System.Drawing.Size(77, 22);
            this.swtchEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swtchEdit.TabIndex = 50;
            this.swtchEdit.Visible = false;
            this.swtchEdit.ValueChanged += new System.EventHandler(this.swtchEdit_ValueChanged);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMobileNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMobileNo.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMobileNo.Border.BorderColor = System.Drawing.Color.Black;
            this.txtMobileNo.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMobileNo.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMobileNo.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMobileNo.Border.Class = "TextBoxBorder";
            this.txtMobileNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMobileNo.DisabledBackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.ForeColor = System.Drawing.Color.Black;
            this.txtMobileNo.Location = new System.Drawing.Point(289, 108);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.PreventEnterBeep = true;
            this.txtMobileNo.Size = new System.Drawing.Size(268, 39);
            this.txtMobileNo.TabIndex = 4;
            this.txtMobileNo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtMobileNo.WatermarkText = "Mobile Number";
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
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.txtAddress.Location = new System.Drawing.Point(15, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PreventEnterBeep = true;
            this.txtAddress.Size = new System.Drawing.Size(268, 39);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtAddress.WatermarkText = "Address";
            // 
            // txtVoterCardNumber
            // 
            this.txtVoterCardNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVoterCardNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVoterCardNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVoterCardNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtVoterCardNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtVoterCardNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtVoterCardNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtVoterCardNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtVoterCardNumber.Border.Class = "TextBoxBorder";
            this.txtVoterCardNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVoterCardNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtVoterCardNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoterCardNumber.ForeColor = System.Drawing.Color.Black;
            this.txtVoterCardNumber.Location = new System.Drawing.Point(15, 198);
            this.txtVoterCardNumber.Name = "txtVoterCardNumber";
            this.txtVoterCardNumber.PreventEnterBeep = true;
            this.txtVoterCardNumber.Size = new System.Drawing.Size(268, 39);
            this.txtVoterCardNumber.TabIndex = 7;
            this.txtVoterCardNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtVoterCardNumber.WatermarkText = "Votar card Number";
            // 
            // txtUniqueMemberNumber
            // 
            this.txtUniqueMemberNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUniqueMemberNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUniqueMemberNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUniqueMemberNumber.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueMemberNumber.Border.BorderColor = System.Drawing.Color.Black;
            this.txtUniqueMemberNumber.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueMemberNumber.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueMemberNumber.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtUniqueMemberNumber.Border.Class = "TextBoxBorder";
            this.txtUniqueMemberNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUniqueMemberNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtUniqueMemberNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUniqueMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.txtUniqueMemberNumber.Location = new System.Drawing.Point(14, 63);
            this.txtUniqueMemberNumber.Name = "txtUniqueMemberNumber";
            this.txtUniqueMemberNumber.PreventEnterBeep = true;
            this.txtUniqueMemberNumber.Size = new System.Drawing.Size(268, 39);
            this.txtUniqueMemberNumber.TabIndex = 1;
            this.txtUniqueMemberNumber.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtUniqueMemberNumber.WatermarkText = "Unique Member Number";
            this.txtUniqueMemberNumber.Leave += new System.EventHandler(this.txtUniqueMemberNumber_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtEmail.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmail.Border.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmail.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmail.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.DisabledBackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(289, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PreventEnterBeep = true;
            this.txtEmail.Size = new System.Drawing.Size(268, 39);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtEmail.WatermarkText = "Email";
            // 
            // cmboMemberType
            // 
            this.cmboMemberType.DisplayMember = "Text";
            this.cmboMemberType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboMemberType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboMemberType.ForeColor = System.Drawing.Color.Black;
            this.cmboMemberType.FormattingEnabled = true;
            this.cmboMemberType.ItemHeight = 33;
            this.cmboMemberType.Location = new System.Drawing.Point(15, 108);
            this.cmboMemberType.Name = "cmboMemberType";
            this.cmboMemberType.Size = new System.Drawing.Size(268, 39);
            this.cmboMemberType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboMemberType.TabIndex = 3;
            this.cmboMemberType.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.cmboMemberType.WatermarkText = "Select Member Type";
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
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMemberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMemberName.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberName.Border.BorderColor = System.Drawing.Color.Black;
            this.txtMemberName.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberName.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberName.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtMemberName.Border.Class = "TextBoxBorder";
            this.txtMemberName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMemberName.DisabledBackColor = System.Drawing.Color.White;
            this.txtMemberName.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberName.ForeColor = System.Drawing.Color.Black;
            this.txtMemberName.Location = new System.Drawing.Point(289, 63);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PreventEnterBeep = true;
            this.txtMemberName.Size = new System.Drawing.Size(268, 39);
            this.txtMemberName.TabIndex = 2;
            this.txtMemberName.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtMemberName.WatermarkText = "Member Name";
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
            this.labelX2.Size = new System.Drawing.Size(167, 43);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Add New Member";
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageSliderPage2.Controls.Add(this.txtSearchMemberNumber);
            this.pageSliderPage2.Controls.Add(this.btnSearch);
            this.pageSliderPage2.Controls.Add(this.cmboSearchMemberType);
            this.pageSliderPage2.Controls.Add(this.chkMemberType);
            this.pageSliderPage2.Controls.Add(this.chkUniqueMemberNumber);
            this.pageSliderPage2.Controls.Add(this.line2);
            this.pageSliderPage2.Controls.Add(this.labelX3);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(625, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(573, 364);
            this.pageSliderPage2.TabIndex = 4;
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
            this.txtSearchMemberNumber.WatermarkText = "Unique Member Number";
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
            // cmboSearchMemberType
            // 
            this.cmboSearchMemberType.DisplayMember = "Text";
            this.cmboSearchMemberType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmboSearchMemberType.Enabled = false;
            this.cmboSearchMemberType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboSearchMemberType.ForeColor = System.Drawing.Color.Black;
            this.cmboSearchMemberType.FormattingEnabled = true;
            this.cmboSearchMemberType.ItemHeight = 33;
            this.cmboSearchMemberType.Location = new System.Drawing.Point(285, 117);
            this.cmboSearchMemberType.Name = "cmboSearchMemberType";
            this.cmboSearchMemberType.Size = new System.Drawing.Size(268, 39);
            this.cmboSearchMemberType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmboSearchMemberType.TabIndex = 20;
            this.cmboSearchMemberType.WatermarkText = "Member Type";
            // 
            // chkMemberType
            // 
            this.chkMemberType.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkMemberType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkMemberType.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMemberType.ForeColor = System.Drawing.Color.Black;
            this.chkMemberType.Location = new System.Drawing.Point(16, 117);
            this.chkMemberType.Name = "chkMemberType";
            this.chkMemberType.Size = new System.Drawing.Size(263, 39);
            this.chkMemberType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkMemberType.TabIndex = 15;
            this.chkMemberType.Text = "By Member Type";
            this.chkMemberType.CheckedChanged += new System.EventHandler(this.chkMemberType_CheckedChanged);
            // 
            // chkUniqueMemberNumber
            // 
            this.chkUniqueMemberNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.chkUniqueMemberNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkUniqueMemberNumber.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUniqueMemberNumber.ForeColor = System.Drawing.Color.Black;
            this.chkUniqueMemberNumber.Location = new System.Drawing.Point(16, 72);
            this.chkUniqueMemberNumber.Name = "chkUniqueMemberNumber";
            this.chkUniqueMemberNumber.Size = new System.Drawing.Size(272, 39);
            this.chkUniqueMemberNumber.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.chkUniqueMemberNumber.TabIndex = 13;
            this.chkUniqueMemberNumber.Text = "By Member Number";
            this.chkUniqueMemberNumber.CheckedChanged += new System.EventHandler(this.chkUniqueMemberNumber_CheckedChanged);
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
            this.labelX3.Size = new System.Drawing.Size(185, 43);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Short && Search Books";
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
            this.labelX4.Text = "BookSelf List";
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
            this.labelX1.Text = "Member Managment";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmMember
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
            this.Name = "frmMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmMember_Load);
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
        private DevComponents.DotNetBar.Controls.PageSlider BookSelfsettingsPageslider;
        private DevComponents.DotNetBar.Controls.PageSliderPage pgsliderAddbokkSelf;
        private DevComponents.DotNetBar.LabelX lblEdit;
        private DevComponents.DotNetBar.Controls.SwitchButton swtchEdit;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobileNo;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVoterCardNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUniqueMemberNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboMemberType;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMemberName;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchMemberNumber;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmboSearchMemberType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMemberType;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkUniqueMemberNumber;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.DataGridViewX DatagridSearchResult;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAdharNo;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}

