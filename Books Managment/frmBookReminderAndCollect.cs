using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace LibreryManagmentSystem.Books_Managment
{
    public partial class frmBookReminderAndCollect : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmBookReminderAndCollect()
        {
            InitializeComponent();
            Testing();
        }

        #region This Section For btn Exit , btn Minimize


        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.SymbolColor = Color.Orange;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.SymbolColor = Color.White;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.SymbolColor = Color.Orange;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.SymbolColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmBookReminderAndCollect_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
                btnExit.SymbolColor = Color.Black;
                btnMinimize.SymbolColor = Color.Black;
            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
                btnExit.SymbolColor = Color.White;
                btnMinimize.SymbolColor = Color.White;
            }
            Testing();
        }

        #endregion  

        #region This Section for Refarence

        cls_BookManegment BookObj = new cls_BookManegment();
        string GetDate = DateTime.Today.ToShortDateString();
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter da;
        DataTable dt;
        Lbry SettingsObj = new Lbry();

        #endregion

        #region This Code for Datagrid View

        private void Testing()
        {
            da = new SqlDataAdapter("SELECT tbl_BookIssu.Record_Id, tbl_BookIssu.Member_Id, tbl_Member.[Member Name], tbl_Member.[Mobile Number], tbl_Member.Address, tbl_Member.Email, tbl_BookIssu.Book_Id, tbl_BookIssu.[Issu Date], tbl_BookIssu.[Return Date],tbl_Books.[Book Name], tbl_Books.[Exsit Self], tbl_BookIssu.Returned FROM tbl_BookIssu INNER JOIN tbl_Member ON tbl_BookIssu.Member_Id = tbl_Member.[Member Id] INNER JOIN tbl_Books ON tbl_BookIssu.Book_Id = tbl_Books.[Book Number]", con);
            dt = new DataTable();
            da.Fill(dt);
            DataGridActionBooks.DataSource = dt;
            for (int i = 0; i < DataGridActionBooks.Rows.Count - 1; i++)
            {
                if ((DateTime.Parse(DataGridActionBooks.Rows[i].Cells[7].Value.ToString()) < DateTime.Parse(GetDate) || DateTime.Parse(DataGridActionBooks.Rows[i].Cells[7].Value.ToString()) == DateTime.Parse(GetDate)) && DataGridActionBooks.Rows[i].Cells[11].Value.ToString() == "No")
                {
                    DataGridActionBooks.Rows[i].Cells[7].Style.BackColor = Color.YellowGreen;
                    DataGridActionBooks.Rows[i].Cells[1].Style.BackColor = Color.Red;
                }
            }
        }

        private void Datagrid(string Member_Id)
        {
            DatagridviewSearch.DataSource = BookObj.ReturnBook(Member_Id);
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Returned";
            chk.Name = "returned";
            DatagridviewSearch.Columns.Add(chk);
        }

        #endregion

        #region This section For BtnSave

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSearchMemberNumber.Text != string.Empty)
            {
                for (int i = 0; i < DatagridviewSearch.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(DatagridviewSearch.Rows[i].Cells[11].Value) == true)
                    {
                        BookObj.CollectBooks(DatagridviewSearch.Rows[i].Cells[6].Value.ToString());

                    }
                }
                txtSearchMemberNumber.Text = string.Empty;
                txtSearchMemberNumber.ReadOnly = false;
                btnSave.Enabled = true;
                Testing();
                MessageBox.Show("Data Saved", "Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region This Section For btnSearch

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.SymbolColor = Color.BlueViolet;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.SymbolColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchMemberNumber.Text != string.Empty)
            {
                if (BookObj.CheckMemberNumber(txtSearchMemberNumber.Text) == true)
                {
                    DatagridviewSearch.Rows.Clear();
                    Datagrid(txtSearchMemberNumber.Text);
                    btnSearch.Enabled = false;
                    txtSearchMemberNumber.ReadOnly = true;
                }
                else
                {
                    DatagridviewSearch.Rows.Clear();
                    txtSearchMemberNumber.Focus();
                    txtSearchMemberNumber.Text = "";
                    MessageBox.Show("Member Number Dose Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearchMemberNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearchMemberNumber.Text == string.Empty)
            {
                DatagridviewSearch.Rows.Clear();
            }
        }


        #endregion
    }
}