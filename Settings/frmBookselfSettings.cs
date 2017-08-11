using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace LibreryManagmentSystem.Settings
{
    public partial class frmBookselfSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmBookselfSettings()
        {
            InitializeComponent();
            DatagridSearchResult.DataSource = BookselfSettingsObj.ShowAllBookSelfSettings();
            cmboBooksCategory.DataSource = BookselfSettingsObj.ShowAllBookCategory();
            cmboBooksCategory.DisplayMember = "Book Category";
            cmboSearchBookCategory.DataSource=BookselfSettingsObj.ShowAllBookCategory();
            cmboSearchBookCategory.DisplayMember="Book Category";
            ShowBookSelfName(); ShowAllNumberOfRow(); ShoAllNumberOfcolumn();
        }


        #region this section Refarence and Variable


        Lbry BookselfSettingsObj = new Lbry();
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        SqlCommand cmd;
        AutoCompleteStringCollection MyCollection;
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

        private void frmBookselfSettings_Load(object sender, EventArgs e)
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

            Notes(); getUniqueSelfNumber();  BookSelfName();
        }

        #region This Section For btnSave And Chack Self Number


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookselfName.Text != string.Empty && txtNumberOfRow.Text != string.Empty && txtNumberOfColumn.Text != string.Empty && txtUniqueSelfNumber.Text != string.Empty && cmboBooksCategory.Text!=string.Empty)
            {
                BookselfSettingsObj.SaveBookSelfSettings(txtUniqueSelfNumber.Text, txtBookselfName.Text, txtNumberOfRow.Text, txtNumberOfColumn.Text, cmboBooksCategory.Text, txtNote.Text);
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookselfName.Text = "";
                txtNote.Text = "";
                txtNumberOfColumn.Text = "";
                txtNumberOfRow.Text = "";
                txtUniqueSelfNumber.Text = "";
                cmboBooksCategory.Text = "";
                DatagridSearchResult.DataSource = BookselfSettingsObj.ShowAllBookSelfSettings();
                ShowAllNumberOfRow(); ShoAllNumberOfcolumn(); ShowBookSelfName();
            }
        }


        //Check Self Number
        private void txtUniqueSelfNumber_Leave(object sender, EventArgs e)
        {
            if (txtUniqueSelfNumber.Text != string.Empty)
            {
                bool Result = BookselfSettingsObj.ValidUniqueSelfNumber(txtUniqueSelfNumber.Text);
                if (Result == false)
                {
                    txtUniqueSelfNumber.Focus();
                    txtUniqueSelfNumber.Text = "";
                    MessageBox.Show("Enter Number Alrady Exsist", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region Methords


        private void getUniqueSelfNumber()
        {
            con.Open();
            cmd = new SqlCommand("SELECT [Unique Self Number] FROM tbl_BookSelfSettings", con);
            SqlDataReader reader = cmd.ExecuteReader();
            MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtUniqueSelfNumber.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void BookSelfName()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT [Book Self Name] FROM tbl|_bookSelfSettings", con);
                SqlDataReader redar = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (redar.Read())
                {
                    MyCollection.Add(redar.GetString(0));
                }
                txtBookselfName.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {

            }
        }

        private void Notes()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT Notes FROM tbl_BookSelfSettings", con);
                SqlDataReader dr = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtNote.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {

            }
        }

        private void ShowBookSelfName()
        {
            cmboSearchBookSelfName.DataSource = BookselfSettingsObj.ShowAllBookSelfName();
            cmboSearchBookSelfName.DisplayMember = "Book Self Name";
        }

        private void ShowAllNumberOfRow()
        {
            cmboSearchNumberOfRo.DataSource = BookselfSettingsObj.ShowAllNumberOfRow();
            cmboSearchNumberOfRo.DisplayMember = "Number Of Raw";
        }

        private void ShoAllNumberOfcolumn()
        {
            cmboSearchNumberOfColumn.DataSource = BookselfSettingsObj.ShowAllNumberOfColumn();
            cmboSearchNumberOfColumn.DisplayMember = "Numbar Of Column";
        }

        #endregion

        #region This Section For Update

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                txtUniqueSelfNumber.Text = drow.Cells[0].Value.ToString();
                txtBookselfName.Text = drow.Cells[1].Value.ToString();
                txtNumberOfRow.Text = drow.Cells[4].Value.ToString();
                txtNumberOfColumn.Text = drow.Cells[3].Value.ToString();
                cmboBooksCategory.Text = drow.Cells[2].Value.ToString();
                //UNWRITECODE Error Here
                txtNote.Text = drow.Cells[5].Value.ToString();
                txtBookselfName.Enabled = false;
                txtNote.Enabled = false;
                txtUniqueSelfNumber.Enabled = false;
                txtNumberOfColumn.Enabled = false;
                txtNumberOfRow.Enabled = false;
                cmboBooksCategory.Enabled = false;
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
            txtBookselfName.Enabled = true;
            txtNote.Enabled = true;
            txtNumberOfColumn.Enabled = true;
            txtNumberOfRow.Enabled = true;
            txtUniqueSelfNumber.Enabled = false;
            cmboBooksCategory.Enabled = true;
            if (swtchEdit.Value == true)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                txtBookselfName.Text = "";
                txtNote.Text = "";
                txtNumberOfColumn.Text = "";
                txtNumberOfRow.Text = "";
                txtUniqueSelfNumber.Text = "";
                cmboBooksCategory.Text = "";
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                txtUniqueSelfNumber.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookselfName.Text != string.Empty && txtNumberOfRow.Text != string.Empty && txtNumberOfColumn.Text != string.Empty && txtUniqueSelfNumber.Text != string.Empty && cmboBooksCategory.Text != string.Empty)
            {
                BookselfSettingsObj.UpdateBookselfSettings(txtUniqueSelfNumber.Text, txtBookselfName.Text, txtNumberOfRow.Text, txtNumberOfColumn.Text, cmboBooksCategory.Text, txtNote.Text);
                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookselfName.Text = "";
                txtNote.Text = "";
                txtNumberOfColumn.Text = "";
                txtNumberOfRow.Text = "";
                txtUniqueSelfNumber.Text = "";
                cmboBooksCategory.Text = "";
                txtUniqueSelfNumber.Enabled = true;
                swtchEdit.Value = false;
                swtchEdit.Visible = false;
                DatagridSearchResult.DataSource = BookselfSettingsObj.ShowAllBookSelfSettings();
            }
        }

        #endregion

        #region This Is Search Section

        private void chkUniqueSelfNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUniqueSelfNumber.Checked == true)
            {
                chkBookCategory.Checked = false;
                chkBookSelfName.Checked = false;
                chkNumberOfColumn.Checked = false;
                chkNumberOfRow.Checked = false;
                cmboSearchUniqueNumber.Enabled = true;
                cmboSearchBookCategory.Enabled = false;
                cmboSearchBookSelfName.Enabled = false;
                cmboSearchNumberOfColumn.Enabled = false;
                cmboSearchNumberOfRo.Enabled = false;
            }
            else
            {
                cmboSearchUniqueNumber.Enabled = false;
            }
        }

        private void chkBookSelfName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookSelfName.Checked == true)
            {
                chkUniqueSelfNumber.Checked = false;
                chkBookCategory.Checked = false;
                chkNumberOfColumn.Checked = false;
                chkNumberOfRow.Checked = false;
                cmboSearchUniqueNumber.Enabled = false;
                cmboSearchBookCategory.Enabled = false;
                cmboSearchBookSelfName.Enabled = true;
                cmboSearchNumberOfColumn.Enabled = false;
                cmboSearchNumberOfRo.Enabled = false;
            }
            else
            {
                cmboSearchBookSelfName.Enabled = false;
            }

        }

        private void chkNumberOfRow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumberOfRow.Checked == true)
            {
                chkUniqueSelfNumber.Checked = false;
                chkBookCategory.Checked = false;
                chkNumberOfColumn.Checked = false; 
                chkBookSelfName.Checked = false;
                cmboSearchUniqueNumber.Enabled = false;
                cmboSearchBookCategory.Enabled = false;
                cmboSearchBookSelfName.Enabled = false;
                cmboSearchNumberOfColumn.Enabled = false;
                cmboSearchNumberOfRo.Enabled = true;
            }
            else
            {
                cmboSearchNumberOfRo.Enabled = false;
            }
        }

        private void chkNumberOfColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumberOfColumn.Checked == true)
            {
                chkUniqueSelfNumber.Checked = false;
                chkBookCategory.Checked = false; 
                chkNumberOfRow.Checked = false;
                chkBookSelfName.Checked = false;
                cmboSearchUniqueNumber.Enabled = false;
                cmboSearchBookCategory.Enabled = false;
                cmboSearchBookSelfName.Enabled = false;
                cmboSearchNumberOfColumn.Enabled = true;
                cmboSearchNumberOfRo.Enabled = false;
            }
            else
            {
                cmboSearchNumberOfColumn.Enabled = false;
            }
        }

        private void chkBookCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBookCategory.Checked == true)
            {
                chkUniqueSelfNumber.Checked = false; 
                chkNumberOfColumn.Checked = false;
                chkNumberOfRow.Checked = false;
                chkBookSelfName.Checked = false;
                cmboSearchUniqueNumber.Enabled = false;
                cmboSearchBookCategory.Enabled = true;
                cmboSearchBookSelfName.Enabled = false;
                cmboSearchNumberOfColumn.Enabled = false;
                cmboSearchNumberOfRo.Enabled = false;
            }
            else
            {
                cmboSearchBookCategory.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkBookCategory.Checked == true)
            {
                DatagridSearchResult.DataSource = BookselfSettingsObj.SearchByBookCategory(cmboSearchBookCategory.Text);
            }
            else if (chkBookSelfName.Checked == true)
            {
                //this code for book Self Name Search
                DatagridSearchResult.DataSource = BookselfSettingsObj.SearchByBookSelfName(cmboSearchBookSelfName.Text);
            }
            else if (chkNumberOfColumn.Checked == true)
            {
                //this code for Column Search
                DatagridSearchResult.DataSource = BookselfSettingsObj.SearchByNumberOfColumn(cmboSearchNumberOfColumn.Text);
            }
            else if (chkNumberOfRow.Checked == true)
            {
                ////this code for Row Search
                DatagridSearchResult.DataSource = BookselfSettingsObj.SearchByNumberOfRow(cmboSearchNumberOfRo.Text);
            }
            else if (chkUniqueSelfNumber.Checked==true)
            {
                //this code for book Self Number Search
                DatagridSearchResult.DataSource = BookselfSettingsObj.SearchByUniqueSelfNumber(cmboSearchUniqueNumber.Text);
            }
        }

        #endregion

        #region Code for Print


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
                            e.Graphics.DrawString("Book Category List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
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