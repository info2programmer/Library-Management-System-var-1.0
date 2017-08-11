using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace LibreryManagmentSystem.EmployeeManagment
{
    public partial class frmEmployeeManagment : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmEmployeeManagment()
        {
            InitializeComponent();
            cmboData();
            data();
        }

        #region This SECTION fOR REFARENCE

        Lbry SettingsObj = new Lbry(); cls_EmployeeManagnment EmployeeObj = new cls_EmployeeManagnment();
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

        #region This Section For btnExit,btnminimnze etc


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

        private void frmEmployeeManagment_Load(object sender, EventArgs e)
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
            txtGender.Text = sender.ToString();
        }


        #region This Section for btnSave


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtAccountNumber.Text!=string.Empty && txtAddress.Text!=string.Empty && txtBankIFC.Text!=string.Empty && txtBankName.Text!=string.Empty && txtDOB.Text!=string.Empty && txtEmpoyeeName.Text!=string.Empty && txtGender.Text!=string.Empty && txtJoinDate.Text!=string.Empty && txtPhoneNumber.Text!=string.Empty &&cmboEmployeType.Text !=string.Empty)
            {
                EmployeeObj.SaveEmployee(txtEmpoyeeName.Text,txtGender.Text,txtDOB.Text,txtJoinDate.Text,txtAddress.Text,cmboEmployeType.Text,txtBankName.Text,txtAccountNumber.Text,txtBankIFC.Text,txtPhoneNumber.Text);
                MessageBox.Show("Data Saved","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                data();
                clearTxtBox();
            }
        }

        #endregion

        private void txtGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Plese Select From Redia", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        #region This Code For  Methords

        private void data()
        {
            DatagridSearchResult.DataSource = EmployeeObj.ShowAllEmployee();
        }

        private void cmboData()
        {
            cmboEmployeType.DataSource = EmployeeObj.ShowEmployeeeType();
            cmboEmployeType.DisplayMember = "Employee Type";
            cmboSearchEmployeeType.DataSource = EmployeeObj.ShowEmployeeeType();
            cmboSearchEmployeeType.DisplayMember = "Employee Type";
        }

        private void clearTxtBox()
        {
            txtPhoneNumber.Text = "";
            txtJoinDate.Text = "";
            txtGender.Text = "";
            txtEmpoyeeName.Text = "";
            txtDOB.Text = "";
            txtBankName.Text = "";
            txtBankIFC.Text = "";
            txtAddress.Text = "";
            txtAccountNumber.Text = "";
            cmboEmployeType.Text = "";
        }

        #endregion

        #region This Section For Update

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = Convert.ToInt32(drow.Cells[0].Value.ToString());
                txtEmpoyeeName.Text = drow.Cells[1].Value.ToString();
                txtGender.Text = drow.Cells[2].Value.ToString();
                txtDOB.Text = drow.Cells[3].Value.ToString();
                txtJoinDate.Text = drow.Cells[4].Value.ToString();
                txtAddress.Text = drow.Cells[5].Value.ToString();
                cmboEmployeType.Text = drow.Cells[6].Value.ToString();
                txtPhoneNumber.Text = drow.Cells[7].Value.ToString();
                txtBankName.Text = drow.Cells[11].Value.ToString();
                txtAccountNumber.Text = drow.Cells[12].Value.ToString();
                txtBankIFC.Text = drow.Cells[13].Value.ToString();
                txtEmpoyeeName.ReadOnly = true;
                radialMenu1.Enabled = false;
                txtDOB.Enabled = false;
                txtJoinDate.Enabled = false;
                txtAddress.ReadOnly = true;
                cmboEmployeType.Enabled = false;
                txtPhoneNumber.ReadOnly = true;
                txtAccountNumber.ReadOnly = true;
                txtBankIFC.ReadOnly = true;
                txtBankName.ReadOnly = true;
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            catch (SystemException)
            {
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtEmpoyeeName.ReadOnly = false;
                radialMenu1.Enabled = true;
                txtDOB.Enabled = true;
                txtJoinDate.Enabled = true;
                txtAddress.ReadOnly = false;
                cmboEmployeType.Enabled = true;
                txtPhoneNumber.ReadOnly = false;
                txtAccountNumber.ReadOnly = false;
                txtBankIFC.ReadOnly = false;
                txtBankName.ReadOnly = false;
            }
            else if (swtchEdit.Value == false)
            {
                clearTxtBox();
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Update_Id.ToString() != string.Empty && txtAccountNumber.Text != string.Empty && txtAddress.Text != string.Empty && txtBankIFC.Text != string.Empty && txtBankName.Text != string.Empty && txtDOB.Text != string.Empty && txtEmpoyeeName.Text != string.Empty && txtGender.Text != string.Empty && txtJoinDate.Text != string.Empty && txtPhoneNumber.Text != string.Empty && cmboEmployeType.Text != string.Empty)
            {
                EmployeeObj.UpdateEmployee(Update_Id.ToString(), txtEmpoyeeName.Text, txtGender.Text, txtDOB.Text, txtJoinDate.Text, txtAddress.Text, cmboEmployeType.Text, txtBankName.Text, txtAccountNumber.Text, txtBankIFC.Text, txtPhoneNumber.Text);
                MessageBox.Show("Data Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data(); clearTxtBox();
                swtchEdit.Value = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        #endregion

        #region This section For Saarch 

        private void chkEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployeeName.Checked == true)
            {
                txtSearchEmployeeName.Enabled = true;
                chkEmployeeType.Checked = false;
                cmboSearchEmployeeType.Enabled = false;
            }
            else
            {
                txtSearchEmployeeName.Enabled = false;
                txtSearchEmployeeName.Text = string.Empty;
            }
        }

        private void chkEmployeeType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployeeType.Checked == true)
            {
                cmboSearchEmployeeType.Enabled = true;
                chkEmployeeName.Checked = false;
                txtSearchEmployeeName.Enabled = false;
                txtSearchEmployeeName.Text = string.Empty;
            }
            else
            {
                cmboSearchEmployeeType.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkEmployeeName.Checked == true)
            {
                if(txtSearchEmployeeName.Text!=string.Empty)
                DatagridSearchResult.DataSource = EmployeeObj.SearchByEmployeeName(txtSearchEmployeeName.Text);
            }
            else if (chkEmployeeType.Checked == true)
            {
                DatagridSearchResult.DataSource = EmployeeObj.SearchByEmployeeType(cmboSearchEmployeeType.Text);
            }
        }

        #endregion

        #region This Section btnPrint
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
                            e.Graphics.DrawString("Student List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Student List", new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Student List", new Font(new Font(DatagridSearchResult.Font,
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


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }
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

        #endregion

    }
}