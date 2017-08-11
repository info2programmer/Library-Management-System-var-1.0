using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace LibreryManagmentSystem.Authentication
{
    public partial class frmLogin : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        #region This Section For Refarence
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        Main mn = new Main();
        Authentication.cls_Login LoginObj = new cls_Login();
        
        #endregion


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (txtPassword.Text != string.Empty && txtUserName.Text != String.Empty)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblAuthenticatin WHERE UserName='" + txtUserName.Text + "' AND Password='" + txtPassword.Text + "'",con);
                con.Open();
                SqlDataReader dr;
                //cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read()) 
                {
                    count++;
                    mn.lblUser.Text ="Welcome "+dr["UserFullName"].ToString()+" ||";
                    mn.lblUserType.Text= dr["UserType"].ToString();
                    mn.lblLoginAs.Text=dr["UserFullName"].ToString()+"...";
                }
                con.Close();
                if (count == 1)
                {
                    //Save Login Time And Date And Other Details
                    LoginObj.SaveLoginDetails(txtUserName.Text);
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Name And Password Not Match", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = "";
                    txtPassword.Text = string.Empty;
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;

            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowPassword_MouseClick(object sender, MouseEventArgs e)
        {
                
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty)
            {
                if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
                {
                   ShowPassword.BackColor = Color.White;
                }
                else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
                {
                    ShowPassword.BackColor = Color.Black;
                }
                
                ShowPassword.Visible = true;
            }
            else
            {
                ShowPassword.Visible = false;
            }
        }
      
        private void ShowPassword_MouseEnter(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '\0';
        }

        private void ShowPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            ShowPassword.Visible = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty)
            {
                ShowPassword.Visible = true;
            }
        }
    }
}