using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.Settings
{
    public partial class frmOrgSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmOrgSettings()
        {
            InitializeComponent();
        }

        #region This Section for Refarence
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        Main mn = new Main();
        DataSet dt = new DataSet();
        SqlDataAdapter da;
        DataRow draw ;
        string updateId = "";
        #endregion


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
        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.SymbolColor = Color.Orange;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.SymbolColor = Color.White;
        }

        private void frmOrgSettings_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;

            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            }
            try
            {
                bind();
            }
            catch (SystemException)
            {
            }
        }
        

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddress.Text != String.Empty && txtEmail.Text != String.Empty && txtOrgName.Text != String.Empty && txtPhNumber.Text != String.Empty && txtRegNumber.Text != String.Empty && txtZipCode.Text != String.Empty)
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Org (OrgName, RegNumber, PhoneNumber, Address, ZipCode, EmailId) VALUES ('" + txtOrgName.Text + "','" + txtRegNumber.Text + "','" + txtPhNumber.Text + "','" + txtAddress.Text + "','" + txtZipCode.Text + "','" + txtEmail.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Saved", "sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    //this methord for text box data....

                    bind();
                }
            }
            catch (SystemException message)
            {
                MessageBox.Show("Opps, Its Some Error !! "+message.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bind()
        {
            da= new SqlDataAdapter("SELECT tbl_Org.* FROM tbl_Org",con);
            da.Fill(dt);
            draw = dt.Tables[0].Rows[0];
            updateId = draw.ItemArray.GetValue(0).ToString();
            txtOrgName.Text = draw.ItemArray.GetValue(1).ToString();
            txtAddress.Text = draw.ItemArray.GetValue(4).ToString();
            txtEmail.Text = draw.ItemArray.GetValue(6).ToString();
            txtPhNumber.Text = draw.ItemArray.GetValue(3).ToString();
            txtRegNumber.Text = draw.ItemArray.GetValue(2).ToString(); 
            txtZipCode.Text = draw.ItemArray.GetValue(5).ToString();
            txtOrgName.ReadOnly = true;
            txtZipCode.ReadOnly = true;
            txtRegNumber.ReadOnly = true;
            txtPhNumber.ReadOnly = true;
            txtEmail.ReadOnly = true; ;
            txtAddress.ReadOnly = true;
            btnSave.Enabled = false;
            lblEdit.Visible = true;
            swtchEdit.Visible = true;
            swtchEdit.Enabled = true;
            //swtchEdit.Enabled
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            if (updateId !=string.Empty)
            {
                if (txtAddress.Text != String.Empty && txtEmail.Text != String.Empty && txtOrgName.Text != String.Empty && txtPhNumber.Text != String.Empty && txtRegNumber.Text != String.Empty && txtZipCode.Text != String.Empty)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Org SET OrgName ='" + txtOrgName.Text + "', RegNumber ='" + txtRegNumber.Text + "', PhoneNumber ='" + txtPhNumber.Text + "', Address ='" + txtAddress.Text + "', ZipCode ='" + txtZipCode.Text + "', EmailId ='" + txtEmail.Text + "' WHERE RecordId='" + updateId + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    //bind();
                    
                }
            }
        }

        private void swtchEdit_ValueChanged(object sender, EventArgs e)
        {
            if (swtchEdit.Value == true)
            {
                txtOrgName.ReadOnly = false;
                txtZipCode.ReadOnly = false;
                txtRegNumber.ReadOnly = false;
                txtPhNumber.ReadOnly = false;
                txtEmail.ReadOnly = false; ;
                txtAddress.ReadOnly = false;
                btnEdit.Enabled = true;
            }
            else
            {
                txtOrgName.ReadOnly = true;
                txtZipCode.ReadOnly = true;
                txtRegNumber.ReadOnly = true;
                txtPhNumber.ReadOnly = true;
                txtEmail.ReadOnly = true; ;
                txtAddress.ReadOnly = true;
                btnEdit.Enabled = false;
            }
        }
    }
}