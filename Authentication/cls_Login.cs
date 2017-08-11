using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.Authentication
{
    class cls_Login
    {

        #region This Section For Variable

        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        private SqlDataAdapter da;
        private DataTable dt;
        SqlCommand cmd;

        #endregion

        //check Unique User Name
        public bool CheckUserName(string UserName)
        {
            cmd = new SqlCommand("SELECT   UserName FROM      tblAuthenticatin WHERE   (UserName = '" + UserName + "')", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Int16 Count = 0;
            while (dr.Read())
            {
                Count++;
            }
            con.Close();
            if (Count >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Create User
        public void CreateUser(string UserFullName,string UsreName,string Passord,string UserType)
        {
            cmd = new SqlCommand("INSERT INTO tblAuthenticatin(UserName, Password, UserFullName, UserType, [Create Date]) VALUES ('"+UsreName+"','"+Passord+"','"+UserFullName+"','"+UserType+"','"+DateTime.Now.ToShortDateString()+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //Show All Users()
        public System.Data.DataTable ShowAllUser()
        {
            da = new SqlDataAdapter("SELECT   tblAuthenticatin.UserName, tblAuthenticatin.UserFullName, tblAuthenticatin.UserType, tbl_LoginDetails.[Login Date], tbl_LoginDetails.[Login TIme] FROM      tblAuthenticatin INNER JOIN tbl_LoginDetails ON tblAuthenticatin.UserName = tbl_LoginDetails.UserName",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Save Login Details
        public void SaveLoginDetails(string UserName)
        {
            cmd = new SqlCommand("INSERT INTO tbl_LoginDetails (UserName, [Login Date], [Login TIme]) VALUES   ('"+UserName+"','"+DateTime.Now.ToShortDateString()+"','"+DateTime.Now.ToShortTimeString()+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Search Login Details By User Name
        public System.Data.DataTable SearchLoginbyUserName(string UserName)
        {
            da = new SqlDataAdapter("SELECT   tblAuthenticatin.UserName, tblAuthenticatin.UserFullName, tblAuthenticatin.UserType, tbl_LoginDetails.[Login Date], tbl_LoginDetails.[Login TIme] FROM      tblAuthenticatin INNER JOIN tbl_LoginDetails ON tblAuthenticatin.UserName = tbl_LoginDetails.UserName WHERE tblAuthenticatin.UserName='"+UserName+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Login Details By User Type
        public System.Data.DataTable SearchLoginbyUserType(string UserType)
        {
            da = new SqlDataAdapter("SELECT   tblAuthenticatin.UserName, tblAuthenticatin.UserFullName, tblAuthenticatin.UserType, tbl_LoginDetails.[Login Date], tbl_LoginDetails.[Login TIme] FROM      tblAuthenticatin INNER JOIN tbl_LoginDetails ON tblAuthenticatin.UserName = tbl_LoginDetails.UserName WHERE tblAuthenticatin.UserType='" + UserType + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Login Details By User Type
        public System.Data.DataTable SearchLoginbyDate(string Date)
        {
            da = new SqlDataAdapter("SELECT   tblAuthenticatin.UserName, tblAuthenticatin.UserFullName, tblAuthenticatin.UserType, tbl_LoginDetails.[Login Date], tbl_LoginDetails.[Login TIme] FROM      tblAuthenticatin INNER JOIN tbl_LoginDetails ON tblAuthenticatin.UserName = tbl_LoginDetails.UserName WHERE tbl_LoginDetails.[Login Date]='" + Date + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
