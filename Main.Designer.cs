namespace LibreryManagmentSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lblUser = new DevComponents.DotNetBar.LabelItem();
            this.lblUserType = new DevComponents.DotNetBar.LabelItem();
            this.lbNoBook = new DevComponents.DotNetBar.LabelItem();
            this.lblTotalMember = new DevComponents.DotNetBar.LabelItem();
            this.lblTotalEmployees = new DevComponents.DotNetBar.LabelItem();
            this.lblNotavelebleBooks = new DevComponents.DotNetBar.LabelItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnMinimize = new DevComponents.DotNetBar.ButtonX();
            this.lblLoginAs = new DevComponents.DotNetBar.LabelX();
            this.btnLogout = new DevComponents.DotNetBar.ButtonX();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.booksSettings = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.addBookSelf = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.memberSettings = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem13 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem8 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.outBooks = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem16 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem9 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem12 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem18 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem19 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem14 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem20 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem21 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnSettings = new DevComponents.DotNetBar.ButtonX();
            this.lblTime = new DevComponents.DotNetBar.LabelItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.metroStatusBar1, "metroStatusBar1");
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.ForeColor = System.Drawing.Color.White;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblUser,
            this.lblUserType,
            this.lbNoBook,
            this.lblTotalMember,
            this.lblTotalEmployees,
            this.lblNotavelebleBooks,
            this.lblTime});
            this.metroStatusBar1.Name = "metroStatusBar1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Symbol = "";
            // 
            // lblUserType
            // 
            this.lblUserType.Name = "lblUserType";
            resources.ApplyResources(this.lblUserType, "lblUserType");
            this.lblUserType.Visible = false;
            // 
            // lbNoBook
            // 
            this.lbNoBook.Name = "lbNoBook";
            resources.ApplyResources(this.lbNoBook, "lbNoBook");
            // 
            // lblTotalMember
            // 
            this.lblTotalMember.Name = "lblTotalMember";
            resources.ApplyResources(this.lblTotalMember, "lblTotalMember");
            // 
            // lblTotalEmployees
            // 
            this.lblTotalEmployees.Name = "lblTotalEmployees";
            resources.ApplyResources(this.lblTotalEmployees, "lblTotalEmployees");
            // 
            // lblNotavelebleBooks
            // 
            this.lblNotavelebleBooks.Name = "lblNotavelebleBooks";
            resources.ApplyResources(this.lblNotavelebleBooks, "lblNotavelebleBooks");
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnExit.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnExit.Name = "btnExit";
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.Symbol = "";
            this.btnExit.SymbolSize = 30F;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnMinimize.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMinimize.Symbol = "";
            this.btnMinimize.SymbolSize = 30F;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.lblLoginAs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.lblLoginAs, "lblLoginAs");
            this.lblLoginAs.ForeColor = System.Drawing.Color.White;
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Symbol = "";
            this.lblLoginAs.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLoginAs.SymbolSize = 50F;
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLogout.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogout.Symbol = "";
            this.btnLogout.SymbolSize = 30F;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.ForeColor = System.Drawing.Color.White;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.itemContainer2,
            this.itemContainer3,
            this.itemContainer6,
            this.itemContainer4});
            resources.ApplyResources(this.metroTilePanel1, "metroTilePanel1");
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1,
            this.booksSettings,
            this.addBookSelf,
            this.metroTileItem3,
            this.metroTileItem4,
            this.memberSettings,
            this.metroTileItem13});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleStyle.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer1.TitleText = "Settings";
            this.itemContainer1.Visible = false;
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.Symbol = "";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.SymbolSize = 50F;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "Organizetion Settings";
            this.metroTileItem1.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem1.Click += new System.EventHandler(this.metroTileItem1_Click);
            // 
            // booksSettings
            // 
            this.booksSettings.Name = "booksSettings";
            this.booksSettings.Symbol = "";
            this.booksSettings.SymbolColor = System.Drawing.Color.Empty;
            this.booksSettings.SymbolSize = 50F;
            this.booksSettings.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.booksSettings.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.booksSettings.TitleText = "Books Settings";
            this.booksSettings.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.booksSettings, "booksSettings");
            this.booksSettings.Click += new System.EventHandler(this.booksSettings_Click);
            // 
            // addBookSelf
            // 
            this.addBookSelf.Name = "addBookSelf";
            this.addBookSelf.Symbol = "";
            this.addBookSelf.SymbolColor = System.Drawing.Color.Empty;
            this.addBookSelf.SymbolSize = 50F;
            resources.ApplyResources(this.addBookSelf, "addBookSelf");
            this.addBookSelf.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.addBookSelf.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.addBookSelf.TitleText = "BookSelf Settings";
            this.addBookSelf.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookSelf.Click += new System.EventHandler(this.addBookSelf_Click);
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.Symbol = "";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.SymbolSize = 50F;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleText = "AccountSettings";
            this.metroTileItem3.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem3.Click += new System.EventHandler(this.metroTileItem3_Click);
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.Symbol = "";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.SymbolSize = 50F;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem4.TitleText = "Employee Settings";
            this.metroTileItem4.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.metroTileItem4, "metroTileItem4");
            this.metroTileItem4.Click += new System.EventHandler(this.metroTileItem4_Click);
            // 
            // memberSettings
            // 
            this.memberSettings.Name = "memberSettings";
            this.memberSettings.Symbol = "";
            this.memberSettings.SymbolColor = System.Drawing.Color.Empty;
            this.memberSettings.SymbolSize = 50F;
            this.memberSettings.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.memberSettings.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.memberSettings.TitleText = "Member Settings";
            this.memberSettings.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.memberSettings, "memberSettings");
            this.memberSettings.Click += new System.EventHandler(this.memberSettings_Click);
            // 
            // metroTileItem13
            // 
            this.metroTileItem13.Name = "metroTileItem13";
            this.metroTileItem13.Symbol = "";
            this.metroTileItem13.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem13.SymbolSize = 50F;
            this.metroTileItem13.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.metroTileItem13.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem13.TitleText = "Paymrnt Settings";
            this.metroTileItem13.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.metroTileItem13, "metroTileItem13");
            this.metroTileItem13.Click += new System.EventHandler(this.metroTileItem13_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.MultiLine = true;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem5,
            this.metroTileItem6,
            this.metroTileItem8,
            this.outBooks,
            this.metroTileItem2,
            this.metroTileItem16});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.TitleStyle.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer2.TitleText = "Books Managment";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.Symbol = "";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.SymbolSize = 50F;
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem5.TitleText = "Add Books";
            this.metroTileItem5.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.metroTileItem5, "metroTileItem5");
            this.metroTileItem5.Click += new System.EventHandler(this.metroTileItem5_Click);
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.Symbol = "";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.SymbolSize = 50F;
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem6.TitleText = "Book List";
            this.metroTileItem6.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem6.Click += new System.EventHandler(this.metroTileItem5_Click);
            // 
            // metroTileItem8
            // 
            this.metroTileItem8.Name = "metroTileItem8";
            this.metroTileItem8.Symbol = "";
            this.metroTileItem8.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem8.SymbolSize = 50F;
            this.metroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.metroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem8.TitleText = "Book List Print";
            this.metroTileItem8.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem8.Click += new System.EventHandler(this.metroTileItem5_Click);
            // 
            // outBooks
            // 
            this.outBooks.Name = "outBooks";
            this.outBooks.Symbol = "";
            this.outBooks.SymbolColor = System.Drawing.Color.Empty;
            this.outBooks.SymbolSize = 50F;
            this.outBooks.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.outBooks.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.outBooks.TitleText = "Search Books";
            this.outBooks.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBooks.Click += new System.EventHandler(this.outBooks_Click);
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.Symbol = "";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.SymbolSize = 50F;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TitleText = "Outgoing Books";
            this.metroTileItem2.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem2.Click += new System.EventHandler(this.metroTileItem2_Click);
            // 
            // metroTileItem16
            // 
            this.metroTileItem16.Name = "metroTileItem16";
            this.metroTileItem16.Symbol = "";
            this.metroTileItem16.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem16.SymbolSize = 50F;
            this.metroTileItem16.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem16.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem16.TileStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem16.TitleText = "Book Reminder";
            resources.ApplyResources(this.metroTileItem16, "metroTileItem16");
            this.metroTileItem16.Click += new System.EventHandler(this.metroTileItem16_Click);
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.MultiLine = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem7,
            this.metroTileItem9,
            this.metroTileItem12});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.TitleStyle.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer3.TitleText = "Employee Managment";
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.Symbol = "";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.SymbolSize = 50F;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem7.TitleText = "Create Employee";
            this.metroTileItem7.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem7.Click += new System.EventHandler(this.metroTileItem7_Click);
            // 
            // metroTileItem9
            // 
            this.metroTileItem9.Name = "metroTileItem9";
            this.metroTileItem9.Symbol = "";
            this.metroTileItem9.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem9.SymbolSize = 50F;
            this.metroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.metroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem9.TitleText = "Employee List";
            this.metroTileItem9.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.metroTileItem9, "metroTileItem9");
            this.metroTileItem9.Click += new System.EventHandler(this.metroTileItem9_Click);
            // 
            // metroTileItem12
            // 
            this.metroTileItem12.Name = "metroTileItem12";
            this.metroTileItem12.Symbol = "";
            this.metroTileItem12.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem12.SymbolSize = 50F;
            this.metroTileItem12.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.metroTileItem12.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem12.TitleText = "Status Editor";
            this.metroTileItem12.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resources.ApplyResources(this.metroTileItem12, "metroTileItem12");
            this.metroTileItem12.Click += new System.EventHandler(this.metroTileItem12_Click);
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.MultiLine = true;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem18,
            this.metroTileItem19});
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.TitleStyle.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer6.TitleText = "Member Managment";
            // 
            // metroTileItem18
            // 
            this.metroTileItem18.Name = "metroTileItem18";
            this.metroTileItem18.Symbol = "";
            this.metroTileItem18.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem18.SymbolSize = 50F;
            this.metroTileItem18.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.metroTileItem18.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem18.TileStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem18.TitleText = "Create Member";
            this.metroTileItem18.Click += new System.EventHandler(this.metroTileItem18_Click);
            // 
            // metroTileItem19
            // 
            this.metroTileItem19.Name = "metroTileItem19";
            this.metroTileItem19.Symbol = "";
            this.metroTileItem19.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem19.SymbolSize = 50F;
            this.metroTileItem19.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem19.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem19.TileStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem19.TitleText = "Show Member List";
            this.metroTileItem19.Click += new System.EventHandler(this.metroTileItem18_Click);
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.MultiLine = true;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem14,
            this.metroTileItem20,
            this.metroTileItem21});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.TitleStyle.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemContainer4.TitleText = "Account Managment";
            this.itemContainer4.Visible = false;
            // 
            // metroTileItem14
            // 
            this.metroTileItem14.Name = "metroTileItem14";
            this.metroTileItem14.Symbol = "";
            this.metroTileItem14.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem14.SymbolSize = 50F;
            this.metroTileItem14.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.metroTileItem14.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem14.TileStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem14.TitleText = "Accounts && Details";
            this.metroTileItem14.Click += new System.EventHandler(this.metroTileItem14_Click);
            // 
            // metroTileItem20
            // 
            this.metroTileItem20.Name = "metroTileItem20";
            this.metroTileItem20.Symbol = "";
            this.metroTileItem20.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem20.SymbolSize = 50F;
            this.metroTileItem20.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.metroTileItem20.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem20.TileStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem20.TitleText = "Membership Collection";
            this.metroTileItem20.Click += new System.EventHandler(this.metroTileItem20_Click);
            // 
            // metroTileItem21
            // 
            this.metroTileItem21.Name = "metroTileItem21";
            this.metroTileItem21.Symbol = "";
            this.metroTileItem21.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem21.SymbolSize = 45F;
            this.metroTileItem21.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem21.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem21.TitleText = "Payment";
            this.metroTileItem21.TitleTextFont = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTileItem21.Click += new System.EventHandler(this.metroTileItem21_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSettings.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSettings.Symbol = "";
            this.btnSettings.SymbolSize = 30F;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            resources.ApplyResources(this.lblTime, "lblTime");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = new DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            this.BorderThickness = new DevComponents.DotNetBar.Metro.Thickness(5D, 5D, 3D, 3D);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.metroTilePanel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLoginAs);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.metroStatusBar1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Main";
            this.Sizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnMinimize;
        private DevComponents.DotNetBar.ButtonX btnLogout;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem addBookSelf;
        private DevComponents.DotNetBar.Metro.MetroTileItem memberSettings;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem8;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem booksSettings;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem outBooks;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem9;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem12;
        private DevComponents.DotNetBar.ButtonX btnSettings;
        public DevComponents.DotNetBar.LabelItem lblUser;
        public DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem14;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem16;
        public DevComponents.DotNetBar.LabelItem lblUserType;
        public DevComponents.DotNetBar.LabelX lblLoginAs;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem18;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem19;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem20;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem21;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem13;
        public DevComponents.DotNetBar.LabelItem lbNoBook;
        private DevComponents.DotNetBar.LabelItem lblTotalMember;
        private DevComponents.DotNetBar.LabelItem lblTotalEmployees;
        private DevComponents.DotNetBar.LabelItem lblNotavelebleBooks;
        private DevComponents.DotNetBar.LabelItem lblTime;
        private System.Windows.Forms.Timer timer1;

    }
}

