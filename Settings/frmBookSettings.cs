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
    public partial class frmBookSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmBookSettings()
        {
            InitializeComponent();
            DatagridSearchResult.DataSource = BookSettings.ShowAllBookSettings();
            cmboshowBookcategory();
            cmboshowBookSubcategory();
            cmboShowbooksType();
        }


        #region This Section For Refarence And Variabe

        Lbry BookSettings = new Lbry();
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

        #region This Section For btnMinimize, btnExit Etc...


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

        private void frmBookSettings_Load(object sender, EventArgs e)
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

            txtBoxCategory();
            txtBoxSubCategory();
            txtBooksType();
          
        }


        #endregion

        #region code For btnSave


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookCategory.Text != string.Empty && txtBooktype.Text != string.Empty && txtNote.Text != string.Empty && txtSubCategory.Text != string.Empty)
            {
                BookSettings.AddBookSettings(txtBookCategory.Text, txtSubCategory.Text, txtBooktype.Text, txtNote.Text);
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookCategory.Text = "";
                txtBooktype.Text = "";
                txtNote.Text = "";
                txtSubCategory.Text = "";
                DatagridSearchResult.DataSource = BookSettings.ShowAllBookSettings();
            }
            cmboshowBookcategory();
            cmboshowBookSubcategory();
            cmboShowbooksType();
        }

        #endregion

        #region Methords


        private void txtBoxCategory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Book Category] FROM tbl_BookSettings", con);
            SqlDataReader reader = cmd.ExecuteReader();
            MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            txtBookCategory.AutoCompleteCustomSource = MyCollection;
            con.Close();
        }

        private void txtBoxSubCategory()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT [Book SubCategory] FROM tbl_BookSettings", con);
                SqlDataReader reader = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txtSubCategory.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {
                con.Close();
            }
        }

        private void txtBooksType()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT [Books Type] FROM tbl_BookSettings", con);
                SqlDataReader reader = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (reader.Read())
                {
                    MyCollection.Add(reader.GetString(0));
                }
                txtBooktype.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException)
            {
                con.Close();
            }
        }

        private void cmboshowBookcategory()
        {
            cmboSearchBooksCategory.DataSource = BookSettings.ShowAllBookCategory();
            cmboSearchBooksCategory.DisplayMember = "Book Category";
            //cmboSearchBooksCategory.ValueMember = "[Book Category]";
        }

        private void cmboshowBookSubcategory()
        {
            cmboSearchBookSubCategory.DataSource = BookSettings.ShowAllBookSubCategory();
            cmboSearchBookSubCategory.DisplayMember = "Book SubCategory";
            //cmboSearchBooksCategory.ValueMember = "[Book Category]";
        }

        private void cmboShowbooksType()
        {
            cmboSearchBooksType.DataSource = BookSettings.ShowAllBooksType();
            cmboSearchBooksType.DisplayMember = "Books Type";
            //cmboSearchBooksCategory.ValueMember = "[Book Category]";
        }
        #endregion

        #region This Section For Update

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                txtBookCategory.Text = drow.Cells[1].Value.ToString();
                txtBooktype.Text = drow.Cells[3].Value.ToString();
                txtNote.Text = drow.Cells[4].Value.ToString();
                txtSubCategory.Text = drow.Cells[2].Value.ToString();
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtBookCategory.Enabled = false;
                txtBooktype.Enabled = false;
                txtNote.Enabled = false;
                txtSubCategory.Enabled = false;
                swtchEdit.Visible = true;
                lblEdit.Visible = true;
                btnSave.Enabled = false;
            }
           catch(SyntaxErrorException)
            {
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtBookCategory.Enabled = true;
                txtBooktype.Enabled = true;
                txtNote.Enabled = true;
                txtSubCategory.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                txtBookCategory.Enabled = true;
                txtBooktype.Enabled = true;
                txtNote.Enabled = true;
                txtSubCategory.Enabled = true;
                txtBookCategory.Text = "";
                txtBooktype.Text = "";
                txtNote.Text = "";
                txtSubCategory.Text = "";
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBooktype.Text != string.Empty && txtBookCategory.Text != string.Empty && txtNote.Text != string.Empty && txtSubCategory.Text != string.Empty && Update_Id.ToString()!=string.Empty)
            {
                BookSettings.UpdateBookSettings(Update_Id, txtBookCategory.Text, txtSubCategory.Text, txtBooktype.Text, txtNote.Text);
                MessageBox.Show("Data Update", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookCategory.Text = "";
                txtBooktype.Text = "";
                txtNote.Text = "";
                txtSubCategory.Text = "";
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                swtchEdit.Value = false;
                BookSettings.ShowAllBookSettings();
                cmboshowBookcategory();
                cmboshowBookSubcategory();
                cmboShowbooksType();
                DatagridSearchResult.DataSource = BookSettings.ShowAllBookSettings();
            }
        }

        #endregion

        #region Code btnPrint

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

        #region This Section For Search

        private void chkBoosCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoosCategory.Checked == true)
            {
                chkBooksType.Checked = false;
                chkSubCategory.Checked = false;
                cmboSearchBookSubCategory.Enabled = false;
                cmboSearchBooksType.Enabled = false;
                cmboSearchBooksCategory.Enabled = true;
            }
            else
            {
                cmboSearchBooksCategory.Enabled = false;
            }
        }

        private void chkSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSubCategory.Checked == true)
            {
                chkBoosCategory.Checked = false;
                chkBooksType.Checked = false;
                cmboSearchBookSubCategory.Enabled = true;
                cmboSearchBooksType.Enabled = false;
                cmboSearchBooksCategory.Enabled = false;
            }
            else
            {
                cmboSearchBookSubCategory.Enabled = false;
            }
        }

        private void chkBooksType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBooksType.Checked == true)
            {
                chkSubCategory.Checked = false;
                chkBoosCategory.Checked = false;
                cmboSearchBookSubCategory.Enabled = false; ;
                cmboSearchBooksType.Enabled = true;
                cmboSearchBooksCategory.Enabled = false;
            }
            else
            {
                cmboSearchBooksType.Enabled = false;
            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkBoosCategory.Checked == true)
                DatagridSearchResult.DataSource = BookSettings.SearchByBookCategory(cmboSearchBooksCategory.Text);
            else if (chkSubCategory.Checked == true)
               DatagridSearchResult.DataSource = BookSettings.SearchByBookSubCategory(cmboSearchBookSubCategory.Text);
            else if(chkBooksType.Checked==true)
             DatagridSearchResult.DataSource = BookSettings.SearchByBooksType(cmboSearchBooksType.Text);

        }

        #endregion
    }
}