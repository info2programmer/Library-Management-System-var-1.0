using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;

namespace LibraryManagmentPRO
{
    public partial class frmLicence : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public frmLicence()
        {
            InitializeComponent();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (txtLicence.Text != string.Empty)
            {
                string licence = LibraryManagmentpro.Properties.Settings.Default.Licence;
                if (licence == txtLicence.Text)
                {
                    RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\info2programmer");
                    key.SetValue("Date", DateTime.Now.ToShortDateString());
                    key.Close();
                    this.Hide();
                    LibreryManagmentSystem.Authentication.frmLogin fr = new LibreryManagmentSystem.Authentication.frmLogin();
                    fr.Show();
                }
                else
                {
                    txtLicence.Text = "";
                    MessageBox.Show("Enter A Valid Product Key", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txtLicence.BackColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult dr= MessageBox.Show("Are You Sure?", "Confarmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr==DialogResult.Yes)
            Application.Exit();
        }

        private void txtLicence_Enter(object sender, EventArgs e)
        {
            txtLicence.BackColor = Color.White;
        }
    }
}