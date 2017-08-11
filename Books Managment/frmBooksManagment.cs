using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.Books_Managment
{
    public partial class frmBooksManagment : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmBooksManagment()
        {
            InitializeComponent();
            DatagridSearchResult.DataSource=BookManegmentObj.ShowAllBooks();
            CmboboxData();
        }

        #region this section Refarence and Variable


        Lbry SettingsObj = new Lbry();
        cls_BookManegment BookManegmentObj = new cls_BookManegment();
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
        Int16 Row, Column;
        Main mn = new Main();

        #endregion

        #region This Section btnExit,btnMinimize etc....

        private void frmBooksManagment_Load(object sender, EventArgs e)
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

        #endregion

        #region Methords

        public void CmboboxData()
        {
            cmboBooksCategory.DataSource = SettingsObj.ShowAllBookCategory();
            cmboBooksCategory.DisplayMember = "Book Category";

            cmboBookSelfName.DataSource = SettingsObj.ShowAllBookSelfName();
            cmboBookSelfName.DisplayMember = "Book Self Name";

            cmboBooksType.DataSource = SettingsObj.ShowAllBooksType();
            cmboBooksType.DisplayMember = "Books Type";

            cmbobookSubCategory.DataSource = SettingsObj.ShowAllBookSubCategory();
            cmbobookSubCategory.DisplayMember = "Book SubCategory";

            cmboSearchBookSelfNumber.DataSource = SettingsObj.ShowAllBookSelfName();
            cmboSearchBookSelfNumber.DisplayMember = "Book Self Name";

            cmboSearchCategory.DataSource = SettingsObj.ShowAllBookCategory();
            cmboSearchCategory.DisplayMember = "Book Category";

            cmboSearchSubCategory.DataSource = SettingsObj.ShowAllBookSubCategory();
            cmboSearchSubCategory.DisplayMember = "Book SubCategory";

            cmboSearchBookTypes.DataSource = SettingsObj.ShowAllBooksType();
            cmboSearchBookTypes.DisplayMember = "Books Type";
        }

        private void clearTxt()
        {
            txtUniqueBookNumber.Text = "";
            txtBookName.Text = "";
            cmboBooksCategory.Text = "";
            cmbobookSubCategory.Text = "";
            cmboBooksType.Text = "";
            txtUniqueBookSelfNumber.Text = "";
            cmboBookSelfName.Text = "";
            txtNumberOfRow.Text = "";
            txtNumberOfColomn.Text = "";
            txtSerialNumber.Text = "";
        }

        #endregion


        #region This Code For btnSave


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookName.Text != string.Empty && txtNumberOfColomn.Text != string.Empty && txtNumberOfRow.Text != string.Empty && txtSerialNumber.Text != string.Empty && txtUniqueBookNumber.Text != string.Empty && txtUniqueBookSelfNumber.Text != string.Empty)
                {
                    BookManegmentObj.SaveBooks(txtUniqueBookNumber.Text, txtBookName.Text, cmboBooksCategory.Text, cmbobookSubCategory.Text, cmboBooksType.Text, txtUniqueBookSelfNumber.Text, cmboBookSelfName.Text, txtNumberOfRow.Text, txtNumberOfColomn.Text, txtSerialNumber.Text);
                    MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatagridSearchResult.DataSource = BookManegmentObj.ShowAllBooks();
                    clearTxt();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion


        #region This Section for Update


        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtUniqueBookNumber.Text = drow.Cells[1].Value.ToString();
                txtBookName.Text = drow.Cells[2].Value.ToString();
                cmboBooksCategory.Text = drow.Cells[3].Value.ToString();
                cmbobookSubCategory.Text = drow.Cells[4].Value.ToString();
                cmboBooksType.Text = drow.Cells[5].Value.ToString();
                txtUniqueBookSelfNumber.Text = drow.Cells[6].Value.ToString();
                cmboBookSelfName.Text = drow.Cells[7].Value.ToString();
                txtNumberOfRow.Text = drow.Cells[8].Value.ToString();
                txtNumberOfColomn.Text = drow.Cells[9].Value.ToString();
                txtSerialNumber.Text = drow.Cells[10].Value.ToString();
                txtUniqueBookNumber.ReadOnly = true;
                txtBookName.ReadOnly = true;
                cmboBooksCategory.Enabled = false;
                cmbobookSubCategory.Enabled = false;
                cmboBooksType.Enabled = false;
                txtUniqueBookSelfNumber.ReadOnly = true;
                cmboBookSelfName.Enabled = false;
                txtNumberOfRow.ReadOnly = true;
                txtNumberOfColomn.ReadOnly = true;
                txtSerialNumber.ReadOnly = true;
                btnSave.Enabled = false;
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
            }
            catch (SystemException)
            {
                
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtUniqueBookNumber.ReadOnly = false;
                txtBookName.ReadOnly = false;
                cmboBooksCategory.Enabled = true;
                cmbobookSubCategory.Enabled = true;
                cmboBooksType.Enabled = true;
                txtUniqueBookSelfNumber.ReadOnly = false;
                cmboBookSelfName.Enabled = true;
                txtNumberOfRow.ReadOnly = false;
                txtNumberOfColomn.ReadOnly = false;
                txtSerialNumber.ReadOnly = false;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                clearTxt();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtBookName.Text != string.Empty && txtNumberOfColomn.Text != string.Empty && txtNumberOfRow.Text != string.Empty && txtSerialNumber.Text != string.Empty && txtUniqueBookNumber.Text != string.Empty && txtUniqueBookSelfNumber.Text != string.Empty)
                {
                    BookManegmentObj.UpdateBooks(txtUniqueBookNumber.Text, txtBookName.Text, cmboBooksCategory.Text, cmbobookSubCategory.Text, cmboBooksType.Text, txtUniqueBookSelfNumber.Text, cmboBookSelfName.Text, txtNumberOfRow.Text, txtNumberOfColomn.Text, txtSerialNumber.Text,Update_Id);
                    MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatagridSearchResult.DataSource = BookManegmentObj.ShowAllBooks();
                    clearTxt();
                    clearTxt();
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = false;
                    lblEdit.Visible = false;
                    swtchEdit.Visible = false;
                }
            }
             catch (SystemException ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        #endregion


        #region This Section for Search

        private void chkUniqueBookNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUniqueBookNumber.Checked == true)
            {
                chkUniqueBookNumber.Checked = true;
                chkBookSubCategory.Checked = false;
                chkBookSelfNumber.Checked = false;
                chkBookCategory.Checked = false;
                chkBookTypes.Checked = false;
                cmboSearchBookSelfNumber.Enabled = false;
                cmboSearchCategory.Enabled = false;
                cmboSearchSubCategory.Enabled = false;
                cmboSearchBookTypes.Enabled = false;
                txtSearchBookNumber.Enabled = true;
            }
            else
            {
               txtSearchBookNumber.Enabled = false;
            }
        }

        private void chkBookCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookCategory.Checked == true)
            {
                chkUniqueBookNumber.Checked = false;
                chkBookSubCategory.Checked = false;
                chkBookSelfNumber.Checked = false;
                chkBookCategory.Checked = true;
                chkBookTypes.Checked = false;
                cmboSearchBookSelfNumber.Enabled = false;
                cmboSearchCategory.Enabled = true;
                cmboSearchSubCategory.Enabled = false;
                cmboSearchBookTypes.Enabled = false;
                txtSearchBookNumber.Enabled = false;
            }
            else
            {
                cmboSearchCategory.Enabled = false;
            }
        }

        private void chkBookSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookSubCategory.Checked == true)
            {
                chkUniqueBookNumber.Checked = false;
                chkBookSubCategory.Checked = true;
                chkBookSelfNumber.Checked = false;
                chkBookCategory.Checked = false;
                chkBookTypes.Checked = false;
                cmboSearchBookSelfNumber.Enabled = false;
                cmboSearchCategory.Enabled = false;
                cmboSearchSubCategory.Enabled = true;
                cmboSearchBookTypes.Enabled = false;
                txtSearchBookNumber.Enabled = false;
            }
            else
            {
                cmboSearchSubCategory.Enabled = false;
            }
        }

        private void chkBookTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookTypes.Checked == true)
            {
                chkUniqueBookNumber.Checked = false;
                chkBookSubCategory.Checked = false;
                chkBookSelfNumber.Checked = false;
                chkBookCategory.Checked = false;
                chkBookTypes.Checked = true;
                cmboSearchBookSelfNumber.Enabled = false;
                cmboSearchCategory.Enabled = false;
                cmboSearchSubCategory.Enabled = false;
                cmboSearchBookTypes.Enabled = true;
                txtSearchBookNumber.Enabled = false;
            }
            else
            {
                cmboSearchBookTypes.Enabled = false;
            }
        }

        private void chkBookSelfNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookSelfNumber.Checked == true)
            {
                chkUniqueBookNumber.Checked = false;
                chkBookSubCategory.Checked = false;
                chkBookSelfNumber.Checked = true;
                chkBookCategory.Checked = false;
                chkBookTypes.Checked = false;
                cmboSearchBookSelfNumber.Enabled = true;
                cmboSearchCategory.Enabled = false;
                cmboSearchSubCategory.Enabled = false;
                cmboSearchBookTypes.Enabled = false;
                txtSearchBookNumber.Enabled = false;
            }
            else
            {
                cmboSearchBookSelfNumber.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkUniqueBookNumber.Checked == true)
            {
               DatagridSearchResult.DataSource= BookManegmentObj.SearchByUniqueBookNumber(txtSearchBookNumber.Text);
            }
            else if (chkBookCategory.Checked == true)
            {
                DatagridSearchResult.DataSource = BookManegmentObj.SearchByBookCategory(cmboBooksCategory.Text);
            }
            else if (chkBookSelfNumber.Checked==true)
            {
                DatagridSearchResult.DataSource = BookManegmentObj.SearchByBookSelf(cmboBookSelfName.Text);
            }
            else if (chkBookSubCategory.Checked==true)
            {
                DatagridSearchResult.DataSource = BookManegmentObj.SearchByBookSubCategory(cmboSearchSubCategory.Text);
            }
            else if (chkBookTypes.Checked==true)
            {
                DatagridSearchResult.DataSource = BookManegmentObj.SearchByBooksType(cmboSearchBookTypes.Text);
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
                            e.Graphics.DrawString("Book List Print", new Font(DatagridSearchResult.Font, FontStyle.Bold),
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


        #region THis Section For Check Unique Number,Chk Number Of Column And Row And Get Book Self Name


        private void txtUniqueBookNumber_Leave(object sender, EventArgs e)
        {
            if (txtUniqueBookNumber.Text != string.Empty)
            {
                if (BookManegmentObj.CheckUniqueBookNumber(txtUniqueBookNumber.Text) == true)
                {
                    txtUniqueBookNumber.Focus();
                    txtUniqueBookNumber.Text = string.Empty;
                    MessageBox.Show("Number AllReady Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void txtUniqueBookSelfNumber_Leave(object sender, EventArgs e)
        {
            if (txtUniqueBookSelfNumber.Text != string.Empty)
            {
                if (SettingsObj.ValidUniqueSelfNumber(txtUniqueBookSelfNumber.Text) == false)
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_BookSelfSettings", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow draw;
                    draw = ds.Tables[0].Rows[0];
                    cmboBookSelfName.Text = draw.ItemArray.GetValue(2).ToString();
                    Row = Int16.Parse(draw.ItemArray.GetValue(3).ToString());
                    Column = Int16.Parse(draw.ItemArray.GetValue(4).ToString());
                    mn.lbNoBook.Visible = false;
                }
                else
                {
                    txtUniqueBookSelfNumber.Focus();
                    txtUniqueBookSelfNumber.Text = string.Empty;
                    MessageBox.Show("tabel dose note exsist", "error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            

        }

        private void txtNumberOfRow_Leave(object sender, EventArgs e)
        {
            if (txtNumberOfRow.Text != string.Empty)
            {
                try //Check Int Value Or Not
                {
                    if (Row < Int16.Parse(txtNumberOfRow.Text))
                    {
                        MessageBox.Show("Maximum Number Of Row Is " + Row.ToString() + "", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtNumberOfRow.Focus();
                        txtNumberOfRow.Text = string.Empty;
                    }
                }
                catch (SystemException)
                {
                    MessageBox.Show("Maximum Number Of Row Is " + Row.ToString() + "", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtNumberOfRow.Focus();
                    txtNumberOfRow.Text = string.Empty;
                }
            }
        }

        private void txtNumberOfColomn_Leave(object sender, EventArgs e)
        {
            if (txtNumberOfColomn.Text != string.Empty)
            {
                try//Check Int Value Or Not
                {
                    if (Column < Int16.Parse(txtNumberOfColomn.Text))
                    {
                        MessageBox.Show("Maximum Number Of Column Is " + Column.ToString() + "", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtNumberOfColomn.Focus();
                        txtNumberOfColomn.Text = string.Empty;
                    }
                }
                catch (SystemException)
                {
                    MessageBox.Show("Maximum Number Of Column Is " + Column.ToString() + "", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtNumberOfColomn.Focus();
                    txtNumberOfColomn.Text = string.Empty;
                }
            }
        }

        #endregion


    }
}