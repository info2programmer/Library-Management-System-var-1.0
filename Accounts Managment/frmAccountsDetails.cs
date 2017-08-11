using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem.Accounts_Managment
{
    public partial class frmAccountsDetails : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmAccountsDetails()
        {
            InitializeComponent();
            Datagrid(); getAccountNameincmboBox();
        }

        #region This Section For Refarence And Variabe

        Lbry SettingsObj = new Lbry();
        cls_AccountManagment AccountObj = new cls_AccountManagment();
        Int16 Zero = 0;

        #endregion

        #region This Section For btnSave,btnExit...


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

        private void frmAccountsDetails_Load(object sender, EventArgs e)
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
        }

        private void cmboAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboAccountName.SelectedValue.ToString() == "Income")
            {
                txtBalence.Enabled = true;
            }
            else
            {
                txtBalence.Enabled = false;
            }
        }

        #endregion

        #region This Section For Methords

        private void getAccountNameincmboBox()
        {
            cmboAccountName.DataSource = SettingsObj.ShowAllAccountName();
            cmboAccountName.DisplayMember = "Account Name";
            cmboAccountName.ValueMember = "Account Type";

            cmboSearchAccountName.DataSource = SettingsObj.ShowAllAccountName();
            cmboSearchAccountName.DisplayMember = "Account Name";

            cmboSearchAccountType.DataSource= SettingsObj.ShowAllAccountName();
            cmboSearchAccountType.DisplayMember = "Account Type";
        }


        private void Datagrid()
        {
            DatagridSearchResult.DataSource = SettingsObj.AccountList();
            DatagridSearchResult.Columns[1].Width = 250;
            DatagridSearchResult.Columns[2].Width = 150;
            float count = 0,count1=0;
            float count2 = 0,count3=0;
            for (int i = 0; i < DatagridSearchResult.RowCount - 1; i++)
            {
                if (DatagridSearchResult.Rows[i].Cells[2].Value.ToString() == "Income")
                {
                    count = float.Parse(DatagridSearchResult.Rows[i].Cells[3].Value.ToString());
                    count1 = count + count1;
                }
                else
                {
                    count2 = float.Parse(DatagridSearchResult.Rows[i].Cells[3].Value.ToString());
                    count3 = count2 + count3;
                }
            }

            if (count1 > count3)
            { 
                lblExpands.Text = count3.ToString();
                count3 = count1 - count3;
                lblBalence.Text = count3.ToString();
                lblTotalIncome.Text = count1.ToString();
            }
            else
            {
                lblBalence.Text = Zero.ToString();
                lblTotalIncome.Text = Zero.ToString();
                lblExpands.Text = Zero.ToString();
            }
        }

        private void clearTxt()
        {
            txtBalence.Text = string.Empty;
            txtNotes.Text = string.Empty;
            cmboAccountName.Text = string.Empty;
            txtBalence.Enabled = false;
        }

        #endregion

        #region This Section For btnSave

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((cmboAccountName.SelectedValue.ToString() == "Income" && txtBalence.Text!=string.Empty && cmboAccountName.Text!=string.Empty))
            {
                AccountObj.SaveAccount(cmboAccountName.Text, txtBalence.Text); 
            }
            else if (cmboAccountName.Text != string.Empty)
            {
                AccountObj.SaveAccount(cmboAccountName.Text, Zero.ToString()); 
            }
            Datagrid();
            MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
        }

        #endregion

        #region This Section For Search

        private void chkAccountName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccountName.Checked == true)
            {
                chkAccountType.Checked = false;
                cmboSearchAccountType.Enabled = false;
                cmboSearchAccountName.Enabled = true;
            }
            else
            {
                cmboSearchAccountName.Enabled = false;
                cmboSearchAccountName.Text = string.Empty;
            }
        }

        private void chkAccountType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccountType.Checked == true)
            {
                chkAccountName.Checked = false;
                cmboSearchAccountType.Enabled = true;
                cmboSearchAccountName.Enabled = false;
            }
            else
            {
                cmboSearchAccountType.Enabled = false;
                cmboSearchAccountType.Text = string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkAccountName.Checked == true)
            {
                DatagridSearchResult.DataSource = AccountObj.SearchByAccountName(cmboSearchAccountName.Text);
            }
            else if (chkAccountType.Checked == true)
            {
                DatagridSearchResult.DataSource = AccountObj.SearchByAccountType(cmboSearchAccountType.Text);
            }
        }


        #endregion


    }
}