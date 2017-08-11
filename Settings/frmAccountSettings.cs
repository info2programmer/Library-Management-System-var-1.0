using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem.Settings
{
    public partial class frmAccountSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmAccountSettings()
        {
            InitializeComponent();


            listExistAccount.DataSource = Account.AccountList();
            listExistAccount.Columns[1].Width = 250;
            listExistAccount.Columns[2].Width = 150;


        }

        #region Refarence
        Lbry Account = new Lbry();
        DataGridViewRow datarow;
        int Update_ID;
        #endregion  


        #region This Section For BtnExit , btn Minimize


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

        private void frmAccountSettings_Load(object sender, EventArgs e)
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

        private void radialMenu1_ItemClick(object sender, EventArgs e)
        {
            txtAccountType.Text = sender.ToString();
        }

        private void radialMenu1_ItemClick_1(object sender, EventArgs e)
        {
            txtAccountType.Text = sender.ToString();
        }


        #endregion

        #region This Section For Insert
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text != string.Empty && txtAccountType.Text != string.Empty)
            {
                Account.CreateAccount(txtAccountName.Text, txtAccountType.Text);
                MessageBox.Show("Account Created","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listExistAccount.DataSource = Account.AccountList();
                txtAccountName.Text = "";
                txtAccountType.Text = "";
                
            }
        }
        #endregion

        #region This Section For Search

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text != string.Empty)
                listExistAccount.DataSource = Account.SearchAccountList(txtSearch.Text);
            else if (txtSearch.Text == string.Empty)
                listExistAccount.DataSource = Account.AccountList();
        }

        #endregion

        #region This Section Update 


        private void listExistAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                datarow = this.listExistAccount.Rows[e.RowIndex];
                txtAccountType.Text = datarow.Cells[2].Value.ToString();
                Update_ID=int.Parse(datarow.Cells[0].Value.ToString());
                txtAccountName.Text = datarow.Cells[1].Value.ToString();
                txtAccountName.Enabled = false;
                txtAccountType.Enabled = false;
                radialMenu1.Enabled = false;
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
                btnCreate.Enabled = false;
            }
            catch(SystemException)
            {
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {

            if (swtchEdit.Value == true)
            {
                txtAccountName.Enabled = true;
                txtAccountType.Enabled = true;
                btnUpdate.Enabled = true;
                radialMenu1.Enabled = true;
            }
            else if (swtchEdit.Value == false)
            {
                txtAccountName.Enabled = true;
                txtAccountType.Enabled = true;
                btnUpdate.Enabled = false;
                btnCreate.Enabled = true;
                txtAccountName.Text = "";
                txtAccountType.Text = "";
                txtAccountName.WatermarkText = "Account Name";
                txtAccountType.WatermarkText = "Account Type";
                radialMenu1.Enabled = true;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text != string.Empty && txtAccountType.Text != string.Empty && Update_ID.ToString()!=string.Empty)
            Account.AccountNameAndTypeUpdate(Update_ID, txtAccountName.Text, txtAccountType.Text);
            MessageBox.Show("Data Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listExistAccount.DataSource = Account.AccountList();
            txtAccountName.Text = "";
            txtAccountType.Text = "";
            lblEdit.Visible = false;
            swtchEdit.Visible = false;
            btnUpdate.Enabled = false;
            btnCreate.Enabled = true;
            swtchEdit.Value = false;
        }

 #endregion

    }
}