using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.Settings
{
    public partial class frmEmployeeSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmEmployeeSettings()
        {
            InitializeComponent();

            DatagridSearchResult.DataSource = EmployeeSettingsObj.ShowAllEmployeeSettings();

            getAllEmployeeTypeinCombo(); getAllPaymentinCombo();
        }


        #region This Section For Refarence And Variabe

        Lbry EmployeeSettingsObj = new Lbry();
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        SqlCommand cmd;
        AutoCompleteStringCollection MyCollection;
        int Update_Id = 0;
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height

        #endregion

        #region This Section For btnMinimize,btnClose ...


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

        private void frmEmployeeSettings_Load(object sender, EventArgs e)
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
            EmployeeTypeAutoComplte();
            MounthPayAutocmplt();
        }

        private void textBoxX1_Enter(object sender, EventArgs e)
        {
            timeSelectiorStart.Visible = true;
        }

        private void textBoxX1_Leave(object sender, EventArgs e)
        {
            timeSelectiorStart.Visible = false;
        }

        private void timeSelector1_SelectedTimeChanged(object sender, EventArgs e)
        {
            txtStartTime.Text = timeSelectiorStart.SelectedTime.ToString();
        }

        private void txtEmployeeTypes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndTime_Enter(object sender, EventArgs e)
        {
            timeSelectorEnd.Visible = true;
            btnUpdate.Visible = false;
        }

        private void txtEndTime_Leave(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            timeSelectorEnd.Visible = false;
        }

        private void timeSelectorEnd_SelectedTimeChanged(object sender, EventArgs e)
        {
            txtEndTime.Text = timeSelectorEnd.SelectedTime.ToString();
        }

        private void txtsearchTimeStart_Enter(object sender, EventArgs e)
        {
            searchTimeSelectorStart.Visible = true;
        }

        private void txtsearchTimeStart_Leave(object sender, EventArgs e)
        {
            searchTimeSelectorStart.Visible = false;
        }

        private void txtSearchEndDutyTime_Enter(object sender, EventArgs e)
        {
            SearchTimeSelctorEndTime.Visible = true;
        }

        private void txtSearchEndDutyTime_Leave(object sender, EventArgs e)
        {
            searchTimeSelectorStart.Visible = false;
        }

        private void SearchTimeSelctorEndTime_SelectedTimeChanged(object sender, EventArgs e)
        {
            txtSearchEndDutyTime.Text = SearchTimeSelctorEndTime.SelectedTime.ToString();
        }

        private void searchTimeSelectorStart_SelectedTimeChanged(object sender, EventArgs e)
        {
            txtsearchTimeStart.Text = searchTimeSelectorStart.SelectedTime.ToString();
        }

      
        #endregion

        #region Tis Section For tbnSave


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeTypes.Text != string.Empty && txtEndTime.Text != string.Empty && txtMonthlyPay.Text != string.Empty && txtStartTime.Text != string.Empty)
            {
                EmployeeSettingsObj.SaveEmployeeSettings(txtEmployeeTypes.Text, txtMonthlyPay.Text, txtStartTime.Text, txtEndTime.Text);
                MessageBox.Show("Settings Saved", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = EmployeeSettingsObj.ShowAllEmployeeSettings();
                ClearTxtBox(); getAllEmployeeTypeinCombo(); getAllPaymentinCombo();
            }
        }

        #endregion

        #region Methords

        //AutoCompleteCode
        private void EmployeeTypeAutoComplte()
        {
            try
            {
                cmd = new SqlCommand("SELECT [Employee Type] FROM tbl_EmployeeSettings", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (da.Read())
                {
                    MyCollection.Add(da.GetString(0));
                }
                txtEmployeeTypes.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {
            }
        }

        private void MounthPayAutocmplt()
        {
            try
            {
                cmd = new SqlCommand("SELECT [Monthly Payment] FROM tbl_EmployeeSettings", con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (da.Read())
                {
                    MyCollection.Add(da.GetString(0));
                }
                txtMonthlyPay.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {
            }
        }
        //AutoCompleteCode

        private void ClearTxtBox()
        {
            txtEndTime.Text = "";
            txtEmployeeTypes.Text = "";
            txtMonthlyPay.Text = "";
            txtStartTime.Text = "";
        }

        private void getAllEmployeeTypeinCombo()
        {
            cmboSearchEmployeeTypes.DataSource = EmployeeSettingsObj.ShowAllEmployeeTypes();
            cmboSearchEmployeeTypes.DisplayMember = "Employee Type";
        }

        private void getAllPaymentinCombo()
        {
            cmboSearchPayments.DataSource = EmployeeSettingsObj.ShowAllPayment();
            cmboSearchPayments.DisplayMember = "Monthly Payment";
        }
        #endregion

        #region This Section For btnUpdate

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtEmployeeTypes.Text = drow.Cells[1].Value.ToString();
                txtMonthlyPay.Text = drow.Cells[2].Value.ToString();
                txtStartTime.Text = drow.Cells[3].Value.ToString();
                txtEndTime.Text = drow.Cells[4].Value.ToString();
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
                txtEmployeeTypes.ReadOnly = true;
                txtEndTime.ReadOnly = true;
                txtMonthlyPay.ReadOnly = true;
                txtStartTime.ReadOnly = true;
                btnSave.Enabled = false;
            }
            catch (SystemException)
            {
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtEmployeeTypes.ReadOnly = false;
                txtEndTime.ReadOnly = false;
                txtMonthlyPay.ReadOnly = false;
                txtStartTime.ReadOnly = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                ClearTxtBox();
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmployeeTypes.Text != string.Empty && txtEndTime.Text != string.Empty && txtMonthlyPay.Text != string.Empty && txtStartTime.Text != string.Empty)
            {
                EmployeeSettingsObj.UpdateEmployeeSettings(txtEmployeeTypes.Text, txtMonthlyPay.Text, txtStartTime.Text, txtEndTime.Text, Update_Id);
                MessageBox.Show("Settins Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = EmployeeSettingsObj.ShowAllEmployeeSettings();
                ClearTxtBox();
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
                swtchEdit.Value = false;
                getAllEmployeeTypeinCombo(); getAllPaymentinCombo();
            }
        }

        #endregion

        #region This Section For btnSearch

        private void chkEmployeeTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployeeTypes.Checked == true)
            {
                chkEndDutyTime.Checked = false;
                chkMonthlyPayment.Checked = false;
                chkStartDutyTime.Checked = false;
                cmboSearchEmployeeTypes.Enabled = true;
                cmboSearchPayments.Enabled = false;
                txtSearchEndDutyTime.Enabled = false;
                txtsearchTimeStart.Enabled = false;
            }
            else
            {
                cmboSearchEmployeeTypes.Enabled = false;
            }
        }

        private void chkMonthlyPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonthlyPayment.Checked == true)
            {
                chkEmployeeTypes.Checked = false;
                chkEndDutyTime.Checked = false;
                chkStartDutyTime.Checked = false;
                cmboSearchEmployeeTypes.Enabled = false;
                cmboSearchPayments.Enabled = true;
                txtSearchEndDutyTime.Enabled = false;
                txtsearchTimeStart.Enabled = false;
            }
            else
            {
                cmboSearchPayments.Enabled = false;
            }
        }

        private void chkStartDutyTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartDutyTime.Checked == true)
            {
                chkMonthlyPayment.Checked = false;
                chkEmployeeTypes.Checked = false;
                chkEndDutyTime.Checked = false;
                cmboSearchEmployeeTypes.Enabled = false;
                cmboSearchPayments.Enabled = false;
                txtSearchEndDutyTime.Enabled = false;
                txtsearchTimeStart.Enabled = true;
            }
            else
            {
                txtsearchTimeStart.Enabled = false;
                txtsearchTimeStart.Text = "";
            }
        }

        private void chkEndDutyTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEndDutyTime.Checked == true)
            {
                chkStartDutyTime.Checked = false;
                chkMonthlyPayment.Checked = false;
                chkEmployeeTypes.Checked = false;
                chkStartDutyTime.Checked = false;
                cmboSearchEmployeeTypes.Enabled = false;
                cmboSearchPayments.Enabled = false;
                txtSearchEndDutyTime.Enabled = true;
                txtsearchTimeStart.Enabled = false;
            }
            else
            {
                txtSearchEndDutyTime.Enabled = false;
                txtSearchEndDutyTime.Text="";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkEmployeeTypes.Checked == true)
            {
                DatagridSearchResult.DataSource=EmployeeSettingsObj.SearchByEmployeeType(cmboSearchEmployeeTypes.Text);
            }
            else if (chkMonthlyPayment.Checked == true)
            {
                DatagridSearchResult.DataSource = EmployeeSettingsObj.SearchByMonthlyPayment(cmboSearchPayments.Text);
            }
            else if (chkStartDutyTime.Checked == true)
            {
                DatagridSearchResult.DataSource = EmployeeSettingsObj.searchByStartTime(txtsearchTimeStart.Text);
            }
            else if (chkEndDutyTime.Checked == true)
            {
                DatagridSearchResult.DataSource = EmployeeSettingsObj.searchByEndTime(txtEndTime.Text);
            }
        }

        #endregion

        #region This Section btnPrint

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in DatagridSearchResult.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in DatagridSearchResult.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= DatagridSearchResult.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = DatagridSearchResult.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("Employee Setting List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Payment Sleep", new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Payment Sleep", new Font(new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in DatagridSearchResult.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}