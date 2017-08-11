using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using LibraryManagmentpro.Properties;

namespace LibreryManagmentSystem.Accounts_Managment
{
    public partial class frmMemberShipCollection : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmMemberShipCollection()
        {
            InitializeComponent();
            InitializeData();
        }

        #region This Section For Refarence And Variabe

        Lbry SettingsObj = new Lbry();
        cls_AccountManagment AccountObj = new cls_AccountManagment();
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter da;
        DataRow drow;
        DataSet ds;
        MemberManagment.cls_Member MemberObj = new MemberManagment.cls_Member();
        float mPay = 0, yPay = 0;

        #endregion

        #region This Section For btnExit,btnMinimize etc...


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

        private void frmMemberShipCollection_Load(object sender, EventArgs e)
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

        #endregion

        #region This Section For Get Member Name From txtMembeName


        private void txtMemberNumber_Leave(object sender, EventArgs e)
        {
            if (txtMemberNumber.Text != string.Empty)
            {
                if (MemberObj.MemberNumber(txtMemberNumber.Text) == false)
                {
                    da = new SqlDataAdapter("SELECT Record_Id, [Member Id], [Member Name], [Member Type], [Mobile Number], Address, Email, [Votar Number], [Adhar Number] FROM tbl_Member WHERE ([Member Id] = '" + Convert.ToInt32(txtMemberNumber.Text) + "')", con);
                    ds = new DataSet();
                    da.Fill(ds);
                    drow = ds.Tables[0].Rows[0];
                    txtMemberName.Text = drow.ItemArray.GetValue(2).ToString();
                }
                else
                {
                    txtMemberNumber.Focus();
                    txtMemberNumber.Text = string.Empty;
                    MessageBox.Show("Member Dose Not Exist", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberName.Text = string.Empty;
                }
            }
        }

        #endregion

        #region This Code For btnSho Details


        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            drow = AccountObj.getPaymentValues(txtMemberNumber.Text).Tables[0].Rows[0];
            lblMPay.Text = drow.ItemArray.GetValue(0).ToString();
            lblYPay.Text= drow.ItemArray.GetValue(1).ToString();
            txtYearlyTotal.Text= drow.ItemArray.GetValue(1).ToString();
            mPay=float.Parse(drow.ItemArray.GetValue(0).ToString());
            yPay = float.Parse(drow.ItemArray.GetValue(1).ToString());

            //visible

            CurrentDate.Visible = true;
            StartMonth.Visible = true;
            EndMonth.Visible = true;
            labelX11.Visible = true;
            lblMPay.Visible = true;
            labelX5.Visible = true;
            labelX6.Visible = true;
            txtMounth.Visible = true;
            labelX7.Visible = true;
            txtMTotalAmount.Visible = true;
            labelX11.Visible = true;
            lblYPay.Visible = true;
            labelX8.Visible = true;
            txtYearlyTotal.Visible = true;
            txtSubtotal.Visible = true;
            btnSave.Visible = true;
            cmboAccountName.Visible = true;
        }

        #endregion

        #region This Code For Calculate Total Amount To Collect Membership

        //This Code for Calculate Total monthly Amount
        private void txtMounth_Leave(object sender, EventArgs e)
        {
            if(txtMounth.Text!=string.Empty)
            txtMTotalAmount.Text =Convert.ToString(mPay * int.Parse(txtMounth.Text));
        }

        //this section for calculate subtotal
        private void txtSubtotal_Enter(object sender, EventArgs e)
        {
            if (txtMTotalAmount.Text != string.Empty)
            txtSubtotal.Text = Convert.ToString(float.Parse(txtMTotalAmount.Text)+float.Parse(txtYearlyTotal.Text));
        }

        #endregion

        #region This Section For Collect MemberShip


        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are You Sure?", "Confurmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (txtMemberNumber.Text != string.Empty && txtSubtotal.Text != string.Empty && txtMTotalAmount.Text != string.Empty && txtMounth.Text != string.Empty && txtMemberName.Text!=string.Empty &&cmboAccountName.Text!=string.Empty)
                {
                    AccountObj.collectMembership(txtMemberNumber.Text, CurrentDate.Text, StartMonth.Text, EndMonth.Text, mPay.ToString(), txtMounth.Text, txtMTotalAmount.Text, yPay.ToString(), txtSubtotal.Text, cmboAccountName.Text,txtMemberName.Text,cmboAccountName.SelectedValue.ToString());
                    MessageBox.Show("Membership Collected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //visible

                    CurrentDate.Visible = false;
                    StartMonth.Visible = false;
                    EndMonth.Visible = false;
                    labelX11.Visible = false;
                    lblMPay.Visible = false;
                    labelX5.Visible = false;
                    labelX6.Visible = false;
                    txtMounth.Visible = false;
                    labelX7.Visible = false;
                    txtMTotalAmount.Visible = false;
                    labelX11.Visible = false;
                    lblYPay.Visible = false;
                    labelX8.Visible = false;
                    txtYearlyTotal.Visible = false;
                    txtSubtotal.Visible = false;
                    btnSave.Visible = false;
                    cmboAccountName.Visible = false ;

                    //Textbox Clears
                    txtMounth.Text = string.Empty;
                    txtMTotalAmount.Text = string.Empty;
                    txtYearlyTotal.Text = string.Empty;
                    txtSubtotal.Text = string.Empty;
                    txtMemberNumber.Text = string.Empty;
                    txtMemberName.Text = string.Empty;

                    //Datagrid Refresh Values

                    DatagridSearchResult.DataSource = AccountObj.ShowAllCollection();
                }
            }
        }


 #endregion

        #region This Section For Methords

        private void InitializeData()
        {
            //Get Account Name Here
            cmboAccountName.DataSource = SettingsObj.IncomeAccount();
            cmboAccountName.DisplayMember = "Account Name";
            cmboAccountName.ValueMember = "Record_Id";

            //getDatagrid Data Here

            DatagridSearchResult.DataSource = AccountObj.ShowAllCollection();

            //getCurrent Date

            CurrentDate.Text = DateTime.Now.ToString();
        }

        #endregion

        #region This Section For Search

        private void chkByCollectDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByCollectDate.Checked == true)
            {
                chkMemberNumber.Checked = false;
                txtSearchMemberNumber.Enabled = false;
                SearchDate.Enabled = true;
            }
            else
            {
                SearchDate.Text = string.Empty;
                SearchDate.Enabled = false;
            }
        }

        private void chkMemberNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMemberNumber.Checked == true)
            {
                chkByCollectDate.Checked = false;
                SearchDate.Enabled = false;
                txtSearchMemberNumber.Enabled = true;
            }
            else
            {
                txtSearchMemberNumber.Text = string.Empty;
                txtSearchMemberNumber.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkByCollectDate.Checked == true)
            {
               DatagridSearchResult.DataSource= AccountObj.SearchCollectionByDate(SearchDate.Text);
            }
            else if (chkMemberNumber.Checked == true)
            {
                DatagridSearchResult.DataSource = AccountObj.SearchCollectionByID(txtSearchMemberNumber.Text);
            }
        }

        #endregion

        private void btnPrint_MouseEnter(object sender, EventArgs e)
        {
            btnPrint.SymbolColor = Color.RosyBrown;
        }

        private void btnPrint_MouseLeave(object sender, EventArgs e)
        {
            btnPrint.SymbolColor = Color.Black;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}