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
    public partial class frmMemberSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmMemberSettings()
        {
            InitializeComponent();
            DatagridSearchResult.DataSource = MemberSettingsObj.ShowAllSettings();
            cmboShowTypes(); cmboShowValue(); cmboDaysOfBookKiping();
        }

        #region This Section For Variables and Refarence


        Lbry MemberSettingsObj = new Lbry();
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
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

        #region This Section For btnexit,btnMinimize...

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

        private void frmMemberSettings_Load(object sender, EventArgs e)
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

        #region This Code For btnSave

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFineValue.Text != string.Empty && txtKeepOfBooks.Text != string.Empty && txtMemberType.Text != string.Empty && txtMonthlyPay.Text != string.Empty && txtYearlyPay.Text!=string.Empty)
            {
                MemberSettingsObj.SaveMemberSettings(txtMemberType.Text, txtMonthlyPay.Text, txtKeepOfBooks.Text, txtFineValue.Text,txtYearlyPay.Text,txtNotes.Text);
                MessageBox.Show("Settings Saveed", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = MemberSettingsObj.ShowAllSettings();
                clrTxtbox(); cmboShowTypes(); cmboShowValue(); cmboDaysOfBookKiping();
            }

        }

        #endregion

        #region This Section For Update

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtMemberType.Text = drow.Cells[1].Value.ToString();
                txtMonthlyPay.Text = drow.Cells[2].Value.ToString();
                txtKeepOfBooks.Text = drow.Cells[3].Value.ToString();
                txtFineValue.Text = drow.Cells[4].Value.ToString();
                txtFineValue.ReadOnly = true;
                txtKeepOfBooks.ReadOnly = true;
                txtMemberType.ReadOnly = true;
                txtMonthlyPay.ReadOnly = true;
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
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
                txtFineValue.ReadOnly = false;
                txtKeepOfBooks.ReadOnly = false;
                txtMemberType.ReadOnly = false;
                txtMonthlyPay.ReadOnly = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
                lblEdit.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFineValue.Text != string.Empty && txtKeepOfBooks.Text != string.Empty && txtMemberType.Text != string.Empty && txtMonthlyPay.Text != string.Empty && txtYearlyPay.Text!=string.Empty)
            {
                MemberSettingsObj.UpdateMemberSettings(txtMemberType.Text, txtMonthlyPay.Text, txtKeepOfBooks.Text, txtFineValue.Text,Update_Id,txtYearlyPay.Text,txtNotes.Text);
                MessageBox.Show("Settings Saveed", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = MemberSettingsObj.ShowAllSettings();
                clrTxtbox(); cmboShowTypes(); cmboShowValue(); cmboDaysOfBookKiping();
                btnUpdate.Enabled = false;
                swtchEdit.Visible = false;
                btnSave.Enabled = true;
                swtchEdit.Value = false;
                lblEdit.Visible = false;
            }
        }

        #endregion

        #region Methords

        private void clrTxtbox()
        {
            txtFineValue.Text = string.Empty;
            txtKeepOfBooks.Text = string.Empty;
            txtMemberType.Text = string.Empty;
            txtMonthlyPay.Text = string.Empty;
            txtYearlyPay.Text = string.Empty;
            txtNotes.Text = string.Empty;
        }

        private void cmboShowTypes()
        {
          cmboSearchMembrTypes.DataSource= MemberSettingsObj.ShowAllMemberType();
          cmboSearchMembrTypes.DisplayMember = "Member Type";
        }

        private void cmboShowValue()
        {
            cmboSearchMonthlyPay.DataSource = MemberSettingsObj.ShowAllMemberMonthlyPay();
            cmboSearchMonthlyPay.DisplayMember = "Monthly Pay";
        }

        private void cmboDaysOfBookKiping()
        {
            cmboSearchDay.DataSource = MemberSettingsObj.ShowAllMemberDaysOfBookKeeping();
            cmboSearchDay.DisplayMember = "Days Of Book Keeping";
        }

        #endregion

        #region This Section For Search

        private void chkMemberType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMemberType.Checked == true)
            {
                chkMemberType.Checked = true;
                chkDaysOfBookKeeping.Checked = false;
                chkMonthlyPay.Checked = false;
                cmboSearchMembrTypes.Enabled = true;
                cmboSearchDay.Enabled = false;
                cmboSearchMonthlyPay.Enabled = false;
            }
            else
            {
                cmboSearchMembrTypes.Enabled = false;
            }
        }

        private void chkMonthlyPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonthlyPay.Checked == true)
            {
                chkMemberType.Checked = false;
                chkDaysOfBookKeeping.Checked = false;
                chkMonthlyPay.Checked = true;
                cmboSearchMembrTypes.Enabled = false;
                cmboSearchDay.Enabled = false;
                cmboSearchMonthlyPay.Enabled = true;
            }
            else
            {
                cmboSearchMonthlyPay.Enabled = false;
            }
        }

        private void chkDaysOfBookKeeping_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDaysOfBookKeeping.Checked == true)
            {
                chkMemberType.Checked = false;
                chkDaysOfBookKeeping.Checked = true;
                chkMonthlyPay.Checked = false;
                cmboSearchMembrTypes.Enabled = false;
                cmboSearchDay.Enabled = true;
                cmboSearchMonthlyPay.Enabled = false;
            }
            else
            {
                cmboSearchDay.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkMemberType.Checked == true)
            {
                DatagridSearchResult.DataSource = MemberSettingsObj.SearchByMemberType(cmboSearchMembrTypes.Text);
            }
            else if (chkMonthlyPay.Checked == true)
            {
                DatagridSearchResult.DataSource = MemberSettingsObj.SearchByMemberMonthlyPayment(cmboSearchMonthlyPay.Text);
            }
            else if (chkDaysOfBookKeeping.Checked == true)
            {
                DatagridSearchResult.DataSource = MemberSettingsObj.SearchByMemberBookKeeping(cmboSearchDay.Text);
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
                            e.Graphics.DrawString("Member Settings List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
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