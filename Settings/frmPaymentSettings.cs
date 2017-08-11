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
    public partial class frmPaymentSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmPaymentSettings()
        {
            InitializeComponent();
            DatagridSearchResult.DataSource = PaymentSettingsObj.ShowAllPaymentSettings();
            cmboAccuntNameshow(); cmboPaymentNameShow();
        }

        #region This Section For Variables and Refarence


        Lbry PaymentSettingsObj = new Lbry();
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

        #region This Section For btnExit,btnMinimize etc....

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

        private void frmPaymentSettings_Load(object sender, EventArgs e)
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

        #region This Section For btnSave

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != string.Empty && txtNotes.Text != string.Empty && txtPaymentName.Text != string.Empty)
                {
                    PaymentSettingsObj.SavePaymentSettings(txtPaymentName.Text, cmboAccountName.Text, txtAmount.Text, txtNotes.Text);
                    MessageBox.Show("Settings Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatagridSearchResult.DataSource = PaymentSettingsObj.ShowAllPaymentSettings();
                    clrtxtBox(); cmboPaymentNameShow();
                }
            }
            catch (SystemException) { MessageBox.Show("Please FillUp The From Properly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Methords

        private void clrtxtBox()
        {
            txtAmount.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtPaymentName.Text = string.Empty;
            cmboAccountName.Text = string.Empty;
        }

        private void cmboAccuntNameshow()
        {
            cmboAccountName.DataSource = PaymentSettingsObj.ExpandAccount();
            cmboAccountName.DisplayMember = "Account Name";
            cmboSearchAccountName.DataSource = PaymentSettingsObj.ExpandAccount();
            cmboSearchAccountName.DisplayMember = "Account Name";
        }

        private void cmboPaymentNameShow()
        {
            cmboSearchPaymentName.DataSource = PaymentSettingsObj.ShowAllPaymentName();
            cmboSearchPaymentName.DisplayMember = "Payment Name";
        }

        #endregion

        #region This Code For Update

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtAmount.Text = drow.Cells[3].Value.ToString();
                txtPaymentName.Text = drow.Cells[1].Value.ToString();
                txtNotes.Text = drow.Cells[4].Value.ToString();
                cmboAccountName.Text = drow.Cells[2].Value.ToString();
                btnSave.Enabled = false;
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
                txtAmount.ReadOnly = true;
                txtNotes.ReadOnly = true;
                txtPaymentName.ReadOnly = true;
                cmboAccountName.Enabled = false;
            }
            catch (SystemException) { }
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != string.Empty && txtNotes.Text != string.Empty && txtPaymentName.Text != string.Empty)
                {
                    PaymentSettingsObj.UpadtePaymentSettings(Update_Id,txtPaymentName.Text,cmboAccountName.Text,txtAmount.Text,txtNotes.Text);
                    MessageBox.Show("Settings Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatagridSearchResult.DataSource = PaymentSettingsObj.ShowAllPaymentSettings();
                    clrtxtBox(); cmboPaymentNameShow(); btnUpdate.Enabled = false;
                    clrtxtBox();
                    btnSave.Enabled = true;
                    lblEdit.Visible = false;
                    swtchEdit.Visible = false;
                    swtchEdit.Value = false;
                }
            }
            catch (SystemException)
            {
                MessageBox.Show("Please FillUp The From Properly","Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void swtchEdit_ValueChanged_1(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtAmount.ReadOnly = false;
                txtNotes.ReadOnly = false;
                txtPaymentName.ReadOnly = false;
                cmboAccountName.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                clrtxtBox();
                btnSave.Enabled = true;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
            }
        }

        #endregion

        #region This Section For Search

        private void chkPaymentName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaymentName.Checked == true)
            {
                chkPaymentName.Checked = true;
                chkAccountName.Checked = false;
                cmboSearchPaymentName.Enabled = true;
                cmboSearchAccountName.Enabled = false;
            }
            else
            {
                cmboSearchPaymentName.Enabled = false;
            }
        }

        private void chkAccountName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccountName.Checked == true)
            {
                chkPaymentName.Checked = false;
                chkAccountName.Checked = true;
                cmboSearchPaymentName.Enabled = false;
                cmboSearchAccountName.Enabled = true;
            }
            else
            {
                cmboSearchAccountName.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkAccountName.Checked == true)
            {
                DatagridSearchResult.DataSource = PaymentSettingsObj.SearchByAccountName(cmboSearchAccountName.Text);

            }
            else if (chkPaymentName.Checked == true)
            {
                DatagridSearchResult.DataSource = PaymentSettingsObj.SearchByPaymentName(cmboSearchPaymentName.Text);
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
                            e.Graphics.DrawString("Payment Settings List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
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