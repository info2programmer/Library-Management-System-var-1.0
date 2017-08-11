using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.MemberManagment
{
    class cls_Member
    {

        #region This Section For Variable , sqlconnection And Refarence

        SqlCommand cmd;
        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        SqlDataAdapter Da;
        DataTable dt;

        #endregion

        public void SaveMember(string Number,string Type,string Phno,string address,string Email,string Votar,string Adhar,string MemberName)
        {
            Int32 MemberNumber = Int32.Parse(Number);
            cmd = new SqlCommand("INSERT INTO tbl_Member ([Member Id], [Member Name], [Member Type], [Mobile Number], Address, Email, [Votar Number], [Adhar Number]) VALUES ('" + MemberNumber + "','" + MemberName + "','"+Type+"','"+Phno+"','"+address+"','"+Email+"','"+Votar+"','"+Adhar+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllMember()
        {
            Da = new SqlDataAdapter("SELECT * FROM tbl_Member",con);
            dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }

        public bool MemberNumber(string Number)
        {
            Int32 Mem = Int32.Parse(Number);
            cmd = new SqlCommand("SELECT [Member Id] FROM tbl_Member WHERE [Member Id]='" + Mem + "'", con);
            con.Open();
            Int16 Count = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
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

        public void UpdateMember(string Type, string Phno, string address, string Email, string Votar, string Adhar, string MemberName,Int32 Update_Id)
        {
            //UPDATE  tbl_Member SET [Member Name] =@a, [Member Type] =@b, [Mobile Number] =@c, Address =@d, Email =@e, [Votar Number] =@f, [Adhar Number] =@g WHERE [Record_Id]=@Update_Id
            cmd = new SqlCommand("UPDATE  tbl_Member SET [Member Name] ='" + MemberName + "', [Member Type] ='" + Type + "', [Mobile Number] ='" + Phno + "', Address ='" + address + "', Email ='" + Email + "', [Votar Number] ='" + Votar + "', [Adhar Number] ='" + Adhar + "' WHERE [Record_Id]='"+Update_Id+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public System.Data.DataTable SearchByMemberId(string Id)
        {
            Int32 Member_Id = Int32.Parse(Id);
            Da = new SqlDataAdapter("SELECT * FROM tbl_Member WHERE [Member Id]='"+Member_Id+"'",con);
            dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByMemberType(string Member_Type)
        {

            Da = new SqlDataAdapter("SELECT * FROM tbl_Member WHERE [Member Type]='" + Member_Type + "'", con);
            dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }

        private int totalNoMembr()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_Member",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Int16 count = 0;
            while (dr.Read())
            {
                count++;
            }
            con.Close();
            return count;
        }

        public int TotalMember { get { return totalNoMembr(); } }
      
    }
}
