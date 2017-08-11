using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace LibreryManagmentSystem.Books_Managment
{
    public partial class frmOutGoingBooks : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmOutGoingBooks()
        {
            InitializeComponent();
            Testing();
        }

        #region This Section For Refarence

        cls_BookManegment BookObj = new cls_BookManegment();
        Lbry SettingsObj = new Lbry();
        MemberManagment.cls_Member MembrObj = new MemberManagment.cls_Member();
        SqlDataAdapter Da;
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        string GetDate = DateTime.Today.ToShortDateString();
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        Main mn = new Main();

        #endregion

        #region This Section For frmLoad,btnMinimize,btnExit...

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

        private void frmOutGoingBooks_Load(object sender, EventArgs e)
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
            Testing();
        }

        #endregion

        #region This section For TxtBoxLeave For Get Member Name And Book Name

        private void txtMemberNumber_Leave(object sender, EventArgs e)
        {
            if (txtMemberNumber.Text != string.Empty)
            {
                try
                {
                    lblMemberName.Visible = true;
                    Int32 Member_Id = Int32.Parse(txtMemberNumber.Text);
                    Da = new SqlDataAdapter("SELECT * FROM tbl_Member WHERE [Member Id]='" + Member_Id + "'", con);
                    DataSet ds = new DataSet();
                    Da.Fill(ds);
                    DataRow drow;
                    drow = ds.Tables[0].Rows[0];
                    lblMemberName.Text = " Member Name : " + drow.ItemArray.GetValue(2).ToString();
                }
                catch (SystemException)
                {
                    lblMemberName.Visible = false;
                    txtMemberNumber.Focus();
                    txtMemberNumber.Text = string.Empty;
                    MessageBox.Show("Member Dose Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void txtBookNumber_Leave(object sender, EventArgs e)
        {
            if (txtBookNumber.Text != string.Empty)
            {
                try
                {
                    lblBookName.Visible = true;
                    lblBookStatus.Visible = true;
                    Int32 Book_Id = Int32.Parse(txtBookNumber.Text);
                    Da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Book Number]='" + Book_Id + "' ", con);
                    DataSet ds = new DataSet();
                    Da.Fill(ds);
                    DataRow drow;
                    drow = ds.Tables[0].Rows[0];
                    lblBookName.Text = " Book Name : " + drow.ItemArray.GetValue(2).ToString();
                    lblBookStatus.Text = " Book Status : " + drow.ItemArray.GetValue(11).ToString();
                }
                catch (SystemException)
                {
                    lblBookStatus.Visible = false;
                    lblBookName.Visible = false;
                    txtBookNumber.Focus();
                    txtBookNumber.Text = string.Empty;
                    MessageBox.Show("Book Dose Not Exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (lblBookStatus.Text == " Book Status : Not Avaleble")
                {
                    btnSave.Enabled = false;
                }
            }
        }

        #endregion

        #region This section For btnSave

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookNumber.Text != string.Empty && txtMemberNumber.Text != string.Empty && IssuDate.Text != string.Empty && ReturnDate.Text != string.Empty)
            {
                BookObj.SaveBookIssue(txtMemberNumber.Text, txtBookNumber.Text, IssuDate.Text, ReturnDate.Text);
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); Testing(); txtClear();
            }
        }

        #endregion

        #region This Code For DatagridView

        //|| Convert.ToDateTime(DatagridSearchResult.Rows[i].Cells[4].Value.ToString())< Convert.ToDateTime(DateTime.Today.Date.ToShortDateString())
        private void Testing()
        {
             DatagridSearchResult.DataSource = BookObj.ShowAllBookissue();
            for (int i = 0; i < DatagridSearchResult.Rows.Count-1; i++)
			{
                if ((DateTime.Parse(DatagridSearchResult.Rows[i].Cells[4].Value.ToString()) < DateTime.Parse(GetDate) || DateTime.Parse(DatagridSearchResult.Rows[i].Cells[4].Value.ToString()) == DateTime.Parse(GetDate))&&DatagridSearchResult.Rows[i].Cells[5].Value.ToString()=="No")
                {
                    DatagridSearchResult.Rows[i].Cells[4].Style.BackColor = Color.Red;
                }
			}

        }

        #endregion

        #region Methords

        private void txtClear()
        {
            txtBookNumber.Text = string.Empty;
            txtMemberNumber.Text = string.Empty;
            IssuDate.Text = string.Empty;
            ReturnDate.Text = string.Empty;
            lblBookName.Visible = false;
            lblBookStatus.Visible = false;
            lblMemberName.Visible = false;
        }

        #endregion

        #region This section For btn Search

        private void chkMemberNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMemberNumber.Checked == true)
            {
                chkIssuDate.Checked = false;
                chkReturnDate.Checked = false;
                chkMemberNumber.Checked = true;
                txtSearchMemberNumber.Enabled = true;
                SearchReturnDate.Enabled = false;
                SearchIssudate.Enabled = false;
                txtSearchMemberNumber.Text = string.Empty;
            }
            else
            {
                txtSearchMemberNumber.Text = string.Empty;
                txtSearchMemberNumber.Enabled = false;
            }
        }

        private void chkIssuDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIssuDate.Checked == true)
            {
                chkIssuDate.Checked = true;
                chkReturnDate.Checked = false;
                chkMemberNumber.Checked = false;
                txtSearchMemberNumber.Enabled = false;
                SearchReturnDate.Enabled = false;
                SearchIssudate.Enabled = true;
                SearchIssudate.Text = string.Empty;
            }
            else
            {
                SearchIssudate.Text = string.Empty;
                SearchIssudate.Enabled = false;
            }
        }

        private void chkReturnDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReturnDate.Checked == true)
            {
                chkIssuDate.Checked = false;
                chkReturnDate.Checked = true;
                chkMemberNumber.Checked = false;
                txtSearchMemberNumber.Enabled = false;
                SearchReturnDate.Enabled = true;
                SearchIssudate.Enabled = false;
                SearchReturnDate.Text = string.Empty;
            }
            else
            {
                SearchReturnDate.Text = string.Empty;
                SearchReturnDate.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkMemberNumber.Checked == true)
            {
                DatagridSearchResult.DataSource = BookObj.SearchByMemberNumberIssu(txtSearchMemberNumber.Text);

                for (int i = 0; i < DatagridSearchResult.Rows.Count - 1; i++)
                {
                    if (DatagridSearchResult.Rows[i].Cells[4].Value.ToString() == GetDate && Convert.ToDateTime(DatagridSearchResult.Rows[i].Cells[4].Value.ToString()) < Convert.ToDateTime(DateTime.Today.Date.ToShortDateString()))
                    {
                        DatagridSearchResult.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        DatagridSearchResult.Rows[i].Cells[4].Style.BackColor = Color.YellowGreen;
                    }
                }
            }
            else if(chkIssuDate.Checked==true)
            {
                DatagridSearchResult.DataSource = BookObj.SearchByIssuDateIssu(SearchIssudate.Text);

                for (int i = 0; i < DatagridSearchResult.Rows.Count - 1; i++)
                {
                    if (DatagridSearchResult.Rows[i].Cells[4].Value.ToString() == GetDate && Convert.ToDateTime(DatagridSearchResult.Rows[i].Cells[4].Value.ToString()) < Convert.ToDateTime(DateTime.Today.Date.ToShortDateString()))
                    {
                        DatagridSearchResult.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        DatagridSearchResult.Rows[i].Cells[4].Style.BackColor = Color.YellowGreen;
                    }
                }
            }
            else if (chkReturnDate.Checked == true)
            {
                DatagridSearchResult.DataSource = BookObj.SearchByReturnDateIssu(SearchReturnDate.Text);

                for (int i = 0; i < DatagridSearchResult.Rows.Count - 1; i++)
                {
                    if (DatagridSearchResult.Rows[i].Cells[4].Value.ToString() == GetDate && Convert.ToDateTime(DatagridSearchResult.Rows[i].Cells[4].Value.ToString()) < Convert.ToDateTime(DateTime.Today.Date.ToShortDateString()))
                    {
                        DatagridSearchResult.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        DatagridSearchResult.Rows[i].Cells[4].Style.BackColor = Color.YellowGreen;
                    }
                }
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
                printDocument1.DocumentName = "Out Books";
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
                            e.Graphics.DrawString("Out Books", new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Out Books", new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(DatagridSearchResult.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Out Books", new Font(new Font(DatagridSearchResult.Font,
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