using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace LibreryManagmentSystem.Authentication
{
    public partial class frmCreateUser : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmCreateUser()
        {
            InitializeComponent();
            DatagridDatas();
        }

        #region THis Section For Refarence

        cls_Login LoginObj = new cls_Login();

        #endregion

        //This Code Form Load
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
               
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;


            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            }
        }

        //btnCreate Click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassord.Text != string.Empty && txtRetypePassord.Text != string.Empty && txtUniqueUserName.Text != string.Empty && txtUserFullName.Text != string.Empty && cmboUserType.Text != string.Empty)
            {
                LoginObj.CreateUser(txtUserFullName.Text, txtUniqueUserName.Text, txtPassord.Text, cmboUserType.Text);
                MessageBox.Show("User Created", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTxt();
                DatagridDatas();
            }
        }

        #region This Code For Methords

        private void clearTxt()
        {
            txtPassord.Text = string.Empty;
            txtRetypePassord.Text = string.Empty;
            txtUniqueUserName.Text = string.Empty;
            txtUserFullName.Text = string.Empty;
            cmboUserType.Text = string.Empty;
        }

        private void DatagridDatas()
        {
            DatagridSearchResult.DataSource = LoginObj.ShowAllUser();
        }

        #endregion

        //check User Name Alrady Exist OR Not
        private void txtUniqueUserName_Leave(object sender, EventArgs e)
        {
            if (txtUniqueUserName.Text != string.Empty)
            {
                if (LoginObj.CheckUserName(txtUniqueUserName.Text) == false)
                {
                    txtUniqueUserName.Focus();
                    txtUniqueUserName.Text = string.Empty;
                    MessageBox.Show("User Name Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Passord Match Or Not Match
        private void txtRetypePassord_Leave(object sender, EventArgs e)
        {
            if (txtPassord.Text != txtRetypePassord.Text)
            {
                txtPassord.Text = string.Empty;
                txtRetypePassord.Text = string.Empty;
                txtPassord.Focus();
                MessageBox.Show("Passoword Not Match", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DatagridDatas();
            }
        }

        #region Thus Section For CheckBox Click

        private void chkUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUserName.Checked == true)
            {
                txtSearchUserName.Enabled = true;
                chkdate.Checked = false;
                chkUserType.Checked = false;
                cmboSearchUserType.Enabled = false;
                SarchDate.Enabled = false;
                cmboSearchUserType.Text = string.Empty;
                SarchDate.Text = string.Empty;
            }
            else
            {
                txtSearchUserName.Enabled = false;
                txtSearchUserName.Text = string.Empty;
            }
        }

        private void chkUserType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUserType.Checked == true)
            {
                txtSearchUserName.Enabled = false;
                chkdate.Checked = false;
                chkUserName.Checked = false;
                cmboSearchUserType.Enabled = true;
                SarchDate.Enabled = false;
                cmboSearchUserType.Text = string.Empty;
                SarchDate.Text = string.Empty;
            }
            else
            {
                cmboSearchUserType.Enabled = false;
                cmboSearchUserType.Text = string.Empty;
            }
        }

        private void chkdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdate.Checked == true)
            {
                txtSearchUserName.Enabled = false;
                chkUserType.Checked = false;
                chkUserName.Checked = false;
                cmboSearchUserType.Enabled = false;
                SarchDate.Enabled = true;
                cmboSearchUserType.Text = string.Empty;
                SarchDate.Text = string.Empty;
            }
            else
            {
                SarchDate.Enabled = false;
                SarchDate.Text = string.Empty;
            }
        }

        #endregion

        #region This Section For btnSearch


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkUserName.Checked == true)
            {
                if(txtSearchUserName.Text!=string.Empty)
                DatagridSearchResult.DataSource = LoginObj.SearchLoginbyUserName(txtSearchUserName.Text);
            }
            else if (chkUserType.Checked == true)
            {
                if (cmboSearchUserType.Text != string.Empty)
                    DatagridSearchResult.DataSource = LoginObj.SearchLoginbyUserType(cmboSearchUserType.Text);
            }
            else if (chkdate.Checked == true)
            {
                if (SarchDate.Text != string.Empty)
                    DatagridSearchResult.DataSource = LoginObj.SearchLoginbyDate(SarchDate.Text);
            }
        }

        #endregion

    }
}