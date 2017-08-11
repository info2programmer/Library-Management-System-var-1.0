using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.MemberManagment
{
    public partial class frmMember : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmMember()
        {
            InitializeComponent();
            MemberTypes();
            DatagridSearchResult.DataSource = MemberObj.ShowAllMember();
        }

        #region This Section For Refarence And Variabe


        Lbry settingsObj = new Lbry();
        cls_Member MemberObj = new cls_Member();
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

        #region This Section For btnExit,btnMinimize...


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

        private void frmMember_Load(object sender, EventArgs e)
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
            AutoCompliteMemberName();
            AutoCompliteAddress();
            AutoCompliteMoblle(); 
            AutoCompliteEmail();

        }

        #endregion

        #region Methhords


        //This Methords For Show Member Types in Combo Boxes
        private void MemberTypes()
        {
            cmboMemberType.DataSource = settingsObj.ShowAllMemberType();
            cmboMemberType.DisplayMember = "Member Type";

            cmboSearchMemberType.DataSource = settingsObj.ShowAllMemberType();
            cmboSearchMemberType.DisplayMember = "Member Type";
        }

        //This Code for Autocomplite Member Name
        private void AutoCompliteMemberName()
        {
            try
            {
                cmd = new SqlCommand("SELECT [Member Name] FROM tbl_Member", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtMemberName.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Methords For AutoComplite  Memberaddress
        private void AutoCompliteAddress()
        {
            try
            {
                cmd = new SqlCommand("SELECT [Address] FROM tbl_Member", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtAddress.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //This Methords For Mobile NUmber AutoComplite
        private void AutoCompliteMoblle()
        {
           try
            {
                cmd = new SqlCommand("SELECT [Mobile Number] FROM tbl_Member", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtMobileNo.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////This Methords For AutoComplite Email address
        private void AutoCompliteEmail()
        {
            try
            {
                cmd = new SqlCommand("SELECT [Email] FROM tbl_Member", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                MyCollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    MyCollection.Add(dr.GetString(0));
                }
                txtEmail.AutoCompleteCustomSource = MyCollection;
                con.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cleartxt()
        {
            txtAddress.Text = "";
            txtAdharNo.Text = "";
            txtEmail.Text = "";
            txtMemberName.Text = "";
            txtMobileNo.Text = "";
            txtUniqueMemberNumber.Text = "";
            txtVoterCardNumber.Text = "";
            cmboMemberType.Text = "";
        }

        #endregion

        #region this section for btnSave


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != string.Empty && txtAdharNo.Text != string.Empty && txtEmail.Text != string.Empty && txtMemberName.Text != string.Empty && txtMobileNo.Text != string.Empty && txtUniqueMemberNumber.Text != string.Empty && txtVoterCardNumber.Text != string.Empty && cmboMemberType.Text!=string.Empty)
            {
                MemberObj.SaveMember(txtUniqueMemberNumber.Text, cmboMemberType.Text, txtMobileNo.Text, txtAddress.Text, txtEmail.Text, txtVoterCardNumber.Text, txtAdharNo.Text, txtMemberName.Text);
                MessageBox.Show("Data Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = MemberObj.ShowAllMember();
                Cleartxt();

            }
        }

        #endregion

        #region This Section  For check unique Member Number


        private void txtUniqueMemberNumber_Leave(object sender, EventArgs e)
        {
            if (txtUniqueMemberNumber.Text != string.Empty)
            {
                if (MemberObj.MemberNumber(txtUniqueMemberNumber.Text) == false)
                {
                    txtUniqueMemberNumber.Text = string.Empty;
                    txtUniqueMemberNumber.Focus();
                    MessageBox.Show("Number alreadry Exsist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        #region This Section For Update Data

        private void DatagridSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow drow = this.DatagridSearchResult.Rows[e.RowIndex];
                Update_Id = int.Parse(drow.Cells[0].Value.ToString());
                txtUniqueMemberNumber.Text = drow.Cells[1].Value.ToString();
                txtMemberName.Text = drow.Cells[2].Value.ToString();
                cmboMemberType.Text = Text = drow.Cells[3].Value.ToString();
                txtMobileNo.Text = Text = drow.Cells[4].Value.ToString();
                txtAddress.Text = Text = drow.Cells[5].Value.ToString();
                txtEmail.Text = Text = drow.Cells[6].Value.ToString();
                txtVoterCardNumber.Text = drow.Cells[7].Value.ToString();
                txtAdharNo.Text = Text = drow.Cells[8].Value.ToString();
                lblEdit.Visible = true;
                swtchEdit.Visible = true;
                txtAddress.ReadOnly = true;
                txtAdharNo.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtMemberName.ReadOnly = true;
                txtUniqueMemberNumber.Enabled = false;
                txtMobileNo.ReadOnly = true;
                txtVoterCardNumber.ReadOnly = true;
                cmboMemberType.Enabled = false;
                btnSave.Enabled = false;
            }
            catch (SystemException) { };
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtAddress.ReadOnly = false;
                txtAdharNo.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtMemberName.ReadOnly = false;
                txtMobileNo.ReadOnly = false;
                txtVoterCardNumber.ReadOnly = false;
                cmboMemberType.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                Cleartxt();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                Update_Id = 0;
                txtUniqueMemberNumber.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != string.Empty && txtAdharNo.Text != string.Empty && txtEmail.Text != string.Empty && txtMemberName.Text != string.Empty && txtMobileNo.Text != string.Empty && txtUniqueMemberNumber.Text != string.Empty && txtVoterCardNumber.Text != string.Empty && cmboMemberType.Text != string.Empty)
            {
                MemberObj.UpdateMember(cmboMemberType.Text, txtMobileNo.Text, txtAddress.Text, txtEmail.Text, txtVoterCardNumber.Text, txtAdharNo.Text, txtMemberName.Text, Update_Id);
                MessageBox.Show("Data Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DatagridSearchResult.DataSource = MemberObj.ShowAllMember();
                Cleartxt();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                lblEdit.Visible = false;
                swtchEdit.Visible = false;
                Update_Id = 0;
                txtUniqueMemberNumber.Enabled = true;
                swtchEdit.Value = false;

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
                            e.Graphics.DrawString("Member List", new Font(DatagridSearchResult.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Member List", new Font(DatagridSearchResult.Font,
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

        #region This Section for Search

        private void chkUniqueMemberNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUniqueMemberNumber.Checked == true)
            {
                chkUniqueMemberNumber.Checked = true;
                chkMemberType.Checked = false;
                txtSearchMemberNumber.Enabled = true;
                cmboSearchMemberType.Enabled = false;
                txtSearchMemberNumber.Text = string.Empty;
            }
            else
            {
                txtSearchMemberNumber.Enabled = false;
            }

	
         }

        private void chkMemberType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMemberType.Checked == true)
            {
                chkUniqueMemberNumber.Checked = false;
                chkMemberType.Checked = true;
                txtSearchMemberNumber.Enabled = false;
                cmboSearchMemberType.Enabled = true;
                txtSearchMemberNumber.Text = string.Empty;
            }
            else
            {
                cmboSearchMemberType.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (chkUniqueMemberNumber.Checked == true)
            {
                DatagridSearchResult.DataSource = MemberObj.SearchByMemberId(txtSearchMemberNumber.Text);
            }
            else if (chkMemberType.Checked == true)
            {
                DatagridSearchResult.DataSource = MemberObj.SearchByMemberType(cmboSearchMemberType.Text);
            }
        }

        #endregion

    }
}