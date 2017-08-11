using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem.EmployeeManagment
{
    public partial class frmEmployeeStatusEdit : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmEmployeeStatusEdit()
        {
            InitializeComponent();
            cmboBoxData();
            Data();
        }

        #region  This Section For Refarence

        cls_EmployeeManagnment EmployeeObj = new cls_EmployeeManagnment();

        #endregion

        #region This section For btnExit, btnMinimix=ze etc...

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

        private void frmEmployeeStatusEdit_Load(object sender, EventArgs e)
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

        #region Methords

        private void cmboBoxData()
        {
            cmboEmployeeName.DataSource = EmployeeObj.cmboEmployeeName();
            cmboEmployeeName.DisplayMember = "Employee Name";
            cmboEmployeeName.ValueMember = "Record_Id";
            cmboSearchEmployeeName.DataSource = EmployeeObj.cmboEmployeeName();
            cmboSearchEmployeeName.DisplayMember = "Employee Name";
        }

        private void Data()
        {
            DatagridSearchResult.DataSource = EmployeeObj.showAllEmployeestatus();
        }

        private void cleartxt()
        {
            txtNotes.Text = string.Empty;
            cmboEmployeeName.Text = string.Empty;
            cmboStatus.Text = string.Empty;
            SelectStartDate.Text = string.Empty;
            SelectEndDate.Text = string.Empty;
        }

        #endregion

        #region This Section for btnUpdate


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmboEmployeeName.Text != string.Empty && cmboStatus.Text != string.Empty && SelectStartDate.Text != string.Empty && SelectEndDate.Text != string.Empty)
            {
                EmployeeObj.SaveEmployeeStatus(cmboEmployeeName.Text, cmboStatus.Text, SelectStartDate.Text, SelectEndDate.Text, txtNotes.Text, cmboEmployeeName.SelectedValue.ToString());
                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Data();
                cleartxt();
            }

       
        }
 #endregion

        #region this Section For Search


        private void chkEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployeeName.Checked == true)
            {
                chkByStart.Checked = false;
                chkEEndDate.Checked = false;
                chkEmployeeStaus.Checked = false;
                cmboSearchEmployeeName.Enabled = true;
                cmboSearchEmployeeStatus.Enabled = false;
                SearchDateStartDate.Enabled = false;
                SearchEndDate.Enabled = false;
            }
            else if(chkEmployeeName.Checked == false)
            {
                cmboSearchEmployeeName.Text = string.Empty;
                cmboSearchEmployeeName.Enabled = false;
            }
        }

        private void chkEmployeeStaus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployeeStaus.Checked == true)
            {
                chkByStart.Checked = false;
                chkEEndDate.Checked = false;
                chkEmployeeName.Checked = false;
                cmboSearchEmployeeName.Enabled = false;
                cmboSearchEmployeeStatus.Enabled = true;
                SearchDateStartDate.Enabled = false;
                SearchEndDate.Enabled = false;
            }
            else if (chkEmployeeStaus.Checked == false)
            {
                cmboSearchEmployeeStatus.Text = string.Empty;
                cmboSearchEmployeeStatus.Enabled = false;
            }
        }

        private void chkByStart_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByStart.Checked == true)
            {
                chkEmployeeStaus.Checked = false;
                chkEEndDate.Checked = false;
                chkEmployeeName.Checked = false;
                cmboSearchEmployeeName.Enabled = false;
                cmboSearchEmployeeStatus.Enabled = false;
                SearchDateStartDate.Enabled = true;
                SearchEndDate.Enabled = false;
            }
            else if (chkByStart.Checked == false)
            {
                SearchDateStartDate.Text = string.Empty;
                SearchDateStartDate.Enabled = false;
            }
        }

        private void chkEEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEEndDate.Checked == true)
            {
                chkEmployeeStaus.Checked = false;
                chkByStart.Checked = false;
                chkEmployeeName.Checked = false;
                cmboSearchEmployeeName.Enabled = false;
                cmboSearchEmployeeStatus.Enabled = false;
                SearchDateStartDate.Enabled = false;
                SearchEndDate.Enabled = true;
            }
            else if (chkEEndDate.Checked == false)
            {
                SearchEndDate.Text = string.Empty;
                SearchEndDate.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkEmployeeName.Checked == true)

                DatagridSearchResult.DataSource = EmployeeObj.SearchStatusByEmployeeName(cmboSearchEmployeeName.Text);

            else if (chkEmployeeStaus.Checked == true)
                DatagridSearchResult.DataSource = EmployeeObj.SearchStatusByEmployeeStatus(cmboSearchEmployeeStatus.Text);

            else if (chkByStart.Checked == true)
                DatagridSearchResult.DataSource = EmployeeObj.SearchStatusByStartDate(SearchDateStartDate.Text);

            else if (chkEEndDate.Checked == true)
                DatagridSearchResult.DataSource = EmployeeObj.SearchStatusByEndDate(SearchEndDate.Text);

        }



        #endregion


    }
}