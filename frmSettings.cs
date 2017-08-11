using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryManagmentSystem
{
    public partial class frmSettings : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        #region This Section For Refarncer

        Main Obj = new Main();

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (LibraryManagmentpro.Properties.Settings.Default.Background == "Light")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;

            }
            else if (LibraryManagmentpro.Properties.Settings.Default.Background == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            }
            if (LibraryManagmentpro.Properties.Settings.Default.UserType == "Super")
            {
                lblAuthentiocation.Visible = true;
            }
            else
            {
                lblAuthentiocation.Visible = false;
            }
            
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            frmAbout abt = new frmAbout();
            abt.Show();
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

        private void radialMenu1_ItemClick(object sender, EventArgs e)
        {
            string Result = sender.ToString();
            if (Result == "Dark")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
                LibraryManagmentpro.Properties.Settings.Default.Background = "Dark";
            }
            else if (Result == "Light")
            {
                styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
                LibraryManagmentpro.Properties.Settings.Default.Background = "Light";
            }
            LibraryManagmentpro.Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentication.frmCreateUser frm = new Authentication.frmCreateUser();
            frm.Show();
        }
    }
}