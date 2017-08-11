using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem
{
    public partial class Main : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Main()
        {
            InitializeComponent();
        }

        #region This Section For Refarence

        Books_Managment.cls_BookManegment BooksObj = new Books_Managment.cls_BookManegment();
        MemberManagment.cls_Member MemberObj = new MemberManagment.cls_Member();
        EmployeeManagment.cls_EmployeeManagnment EmpoyeeObj = new EmployeeManagment.cls_EmployeeManagnment();

        #endregion


        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.SymbolColor = Color.Orange;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnExit.SymbolColor = Color.Black;
            }
            else
            {
                btnExit.SymbolColor = Color.White;
            }
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.SymbolColor = Color.Orange;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnMinimize.SymbolColor = Color.Black;
            }
            else
            {
                btnMinimize.SymbolColor = Color.White;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            //maashagshaj
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.SymbolColor = Color.Orange;

        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnLogout.SymbolColor = Color.Black;
            }
            else
            {
                btnLogout.SymbolColor = Color.White;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Authentication.frmLogin lgfrm = new Authentication.frmLogin();
            Settings.frmOrgSettings frmOrg = new Settings.frmOrgSettings();
            this.Hide();
            lgfrm.Show();
         }

        private void Main_Load(object sender, EventArgs e)
        { 
            Authentication.frmLogin lgfrm = new Authentication.frmLogin();
            lgfrm.Close();

            //Check Background
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnExit.SymbolColor = Color.Black;
                btnLogout.SymbolColor = Color.Black;
                btnMinimize.SymbolColor = Color.Black;
                btnSettings.SymbolColor = Color.Black;
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;

            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
                btnExit.SymbolColor = Color.White;
                btnLogout.SymbolColor = Color.White;
                btnMinimize.SymbolColor = Color.White;
                btnSettings.SymbolColor = Color.White;
            }

            //Chack User Type
            if (lblUserType.Text == "Super")
            {
                itemContainer1.Visible = true;
                itemContainer4.Visible = true;
                LibraryManagmentpro.Properties.Settings.Default.UserType = "Super";
                LibraryManagmentpro.Properties.Settings.Default.Save();
            }
            else
            {
                itemContainer1.Visible = false;
                itemContainer4.Visible = false;
                LibraryManagmentpro.Properties.Settings.Default.UserType = "Normal";
                LibraryManagmentpro.Properties.Settings.Default.Save();
            }

            // Number Of Books
            lbNoBook.Text = " Total Books : " + BooksObj.TotalBooks.ToString()+" || ";
            lblTotalMember.Text = " Total Member : " + MemberObj.TotalMember.ToString()+" || ";
            lblTotalEmployees.Text = " Total Employees : " + EmpoyeeObj.TotalEmployees + " || ";
            lblNotavelebleBooks.Text = " Not Avelable Books : " + BooksObj.TotalIssueBook + " || ";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings fs = new frmSettings();
            fs.Show();
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.SymbolColor = Color.Orange;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnSettings.SymbolColor = Color.Black;
            }
            else
            {
                btnSettings.SymbolColor = Color.White;
            }
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Settings.frmOrgSettings OR = new Settings.frmOrgSettings();
            OR.Show();
        }

        private void booksSettings_Click(object sender, EventArgs e)
        {
            Settings.frmBookSettings bs = new Settings.frmBookSettings();
            bs.Show();
        }

        private void addBookSelf_Click(object sender, EventArgs e)
        {
            Settings.frmBookselfSettings bslf = new Settings.frmBookselfSettings();
            bslf.Show();
        }

        private void memberSettings_Click(object sender, EventArgs e)
        {
            Settings.frmMemberSettings ms = new Settings.frmMemberSettings();
            ms.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            Settings.frmEmployeeSettings frm = new Settings.frmEmployeeSettings();
            frm.Show();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            Settings.frmAccountSettings set = new Settings.frmAccountSettings();
            set.Show();
        }

        private void metroTileItem5_Click(object sender, EventArgs e)
        {
            Books_Managment.frmBooksManagment bk = new Books_Managment.frmBooksManagment();
            bk.Show();
        }

        private void metroTileItem7_Click(object sender, EventArgs e)
        {
            EmployeeManagment.frmEmployeeManagment ferm = new EmployeeManagment.frmEmployeeManagment();
            ferm.Show();
        }

        private void outBooks_Click(object sender, EventArgs e)
        {
            Books_Managment.frmOneClickSearch ne = new Books_Managment.frmOneClickSearch();
            ne.Show();
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            Books_Managment.frmOutGoingBooks frm = new Books_Managment.frmOutGoingBooks();
            frm.Show();
        }

        private void metroTileItem16_Click(object sender, EventArgs e)
        {
            Books_Managment.frmBookReminderAndCollect coll = new Books_Managment.frmBookReminderAndCollect();
            coll.Show();
        }

        private void metroTileItem18_Click(object sender, EventArgs e)
        {
            MemberManagment.frmMember Member = new MemberManagment.frmMember();
            Member.Show();
        }

        private void metroTileItem12_Click(object sender, EventArgs e)
        {
            EmployeeManagment.frmEmployeeStatusEdit frm = new EmployeeManagment.frmEmployeeStatusEdit();
            frm.Show();
        }

        private void metroTileItem14_Click(object sender, EventArgs e)
        {
            Accounts_Managment.frmAccountsDetails frm = new Accounts_Managment.frmAccountsDetails();
            frm.Show();
        }

        private void metroTileItem20_Click(object sender, EventArgs e)
        {
            Accounts_Managment.frmMemberShipCollection frm = new Accounts_Managment.frmMemberShipCollection();
            frm.Show();
        }

        private void metroTileItem13_Click(object sender, EventArgs e)
        {
            Settings.frmPaymentSettings frm = new Settings.frmPaymentSettings();
            frm.Show();
        }

        private void metroTileItem21_Click(object sender, EventArgs e)
        {
            Accounts_Managment.frmPaymentDonet frm = new Accounts_Managment.frmPaymentDonet();
            frm.Show();
        }

        private void metroTileItem9_Click(object sender, EventArgs e)
        {
            EmployeeManagment.frmEmployeeManagment frm = new EmployeeManagment.frmEmployeeManagment();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time : " + DateTime.Now.ToString("hh:mm:ss");
        }
    }
}