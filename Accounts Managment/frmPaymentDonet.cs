using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem.Accounts_Managment
{
    public partial class frmPaymentDonet : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmPaymentDonet()
        {
            InitializeComponent();
            GetPaymentNames();
            CurrentDate.Text = DateTime.Now.ToShortDateString();
            DatagridSearchResult.DataSource = AccountOBJ.shoAllPayments();
        }

        #region  this section for varialble and refarnce

        Lbry SettingsObj = new Lbry();
        cls_AccountManagment AccountOBJ = new cls_AccountManagment();

        #endregion

        #region This Section For btnMinimize,brnExit,,,


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

        private void frmPaymentDonet_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                btnExit.SymbolColor = Color.Black;
                btnMinimize.SymbolColor = Color.Black;
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;


            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
                btnExit.SymbolColor = Color.White;
                btnMinimize.SymbolColor = Color.White;
            }
        }

        #endregion

        #region This Section For Methords

        //Get All Payment Namre In CmboBoxes
        private void GetPaymentNames()
        {
            cmboPayment.DataSource = SettingsObj.ShowAllPaymentName();
            cmboPayment.DisplayMember = "Payment Name";
            cmboPayment.ValueMember = "Record_Id";

            //cmbo Sesrch
            cmboSearchPaymentName.DataSource = SettingsObj.ShowAllPaymentName();
            cmboSearchPaymentName.DisplayMember="Payment Name";
            cmboSearchPaymentName.ValueMember="Record_Id";
        }

        private void Visisble()
        {
            labelX2.Visible = true;
            labelX5.Visible = true;
            lblAmount.Visible = true;
            lblNotes.Visible = true;
            lblAmount.Text = string.Empty;
            lblNotes.Text = string.Empty;
            btnCollect.Enabled = true;
            
        }

        private void clearTXT()
        {
            labelX2.Visible = false;
            labelX5.Visible = false;
            lblAmount.Visible = false;
            lblNotes.Visible = false;
            lblAmount.Text = string.Empty;
            lblNotes.Text = string.Empty;
            btnCollect.Enabled = false;
            cmboPayment.Text = string.Empty;
        }

        #endregion

        #region This Code For btnDetails


        //btnShow Details
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (cmboPayment.Text != string.Empty)
            {
                //get Labels Values
                DataRow drow = AccountOBJ.GetPayment(cmboPayment.SelectedValue.ToString()).Tables[0].Rows[0];
                Visisble();
                lblAmount.Text = drow.ItemArray.GetValue(3).ToString();
                lblNotes.Text = drow.ItemArray.GetValue(4).ToString();
            }
        }

        #endregion

        #region THis Code For Payment Donet


        private void btnCollect_Click(object sender, EventArgs e)
        {
            if (lblNotes.Text != string.Empty && lblAmount.Text != string.Empty && cmboPayment.Text != string.Empty && CurrentDate.Text!=string.Empty)
            {
                DialogResult dr = MessageBox.Show("Are You Sure?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    AccountOBJ.givePayment(CurrentDate.Text, cmboPayment.SelectedValue.ToString(), cmboPayment.Text, lblNotes.Text, lblAmount.Text);
                    MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTXT();
                    DatagridSearchResult.DataSource = AccountOBJ.shoAllPayments();
                }
            }
        }

        #endregion

        #region this code for checkboxes

        //the checkbox code goes here
        private void chkPaymentName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaymentName.Checked == true)
            {
                chkDate.Checked = false;
                SearchDate.Enabled = false;
                cmboSearchPaymentName.Enabled = true;
                SearchDate.Text = string.Empty;
            }
            else
            {
                cmboSearchPaymentName.Text = string.Empty;
                cmboSearchPaymentName.Enabled = false;
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
            {
                chkPaymentName.Checked = false;
                SearchDate.Enabled = true;
                cmboSearchPaymentName.Enabled = false;
                cmboSearchPaymentName.Text = string.Empty;
            }
            else
            {
                SearchDate.Text = string.Empty;
                SearchDate.Enabled = false;
            }
        }

        #endregion

        #region THis Code For Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkDate.Checked == true)
                if (cmboSearchPaymentName.Text != string.Empty)
                    DatagridSearchResult.DataSource = AccountOBJ.SearchPaymentByPaymentName(cmboSearchPaymentName.Text);
                else if (chkDate.Checked == true)
                    if (SearchDate.Text != string.Empty)
                        DatagridSearchResult.DataSource = AccountOBJ.SearchPaymentByDate(SearchDate.Text);
        }

        #endregion

    }
}