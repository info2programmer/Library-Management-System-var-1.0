using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.Accounts_Managment
{
    class cls_AccountManagment
    {
        #region This Section For Refarence And Variables

        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        private SqlDataAdapter da;
        private DataTable dt;
        SqlCommand cmd;
        Lbry SettingsOBJ = new Lbry();
        DataSet DS;

        #endregion

        #region This Section frmAccount

        public void SaveAccount(string AccountName,string Amount)
        {
            float rs = float.Parse(Amount);
            cmd = new SqlCommand("UPDATE  tbl_Account SET Amount = '" + rs + "' WHERE   ([Account Name] = '"+AccountName+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable SearchByAccountName(string AccountName)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE [Account Name]='"+AccountName+"'",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByAccountType(string AccountType)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE [Account Type]='" + AccountType + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region This Section For Membership Collection


        //this Section For GetMember Details On Dataset

        public System.Data.DataSet getPaymentValues(string Id)
        {
            da = new SqlDataAdapter("SELECT tbl_MemberSettings.[Monthly Pay], tbl_MemberSettings.[Yearly Pay] FROM tbl_MemberSettings INNER JOIN tbl_Member ON tbl_MemberSettings.[Member Type] = tbl_Member.[Member Type] WHERE   (tbl_Member.[Member Id] = '"+Int32.Parse(Id)+"')",con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //this section for collect amount

        public void collectMembership(string Member_Id,string CDate,string StartMonth,string EndMonth,string MonthlyPay,string Month,string TotalMamount,string YearlyPay,string SubTotal,string AccountName,string MemberName,string Account_ID )
        {
            cmd = new SqlCommand("INSERT INTO tbl_Membershipcollection (Member_Id, CurentDate, StartMonth, EndMonth, MonthlyPay, Months, TotalMounthlyPay, MentenensPay, SubTotal, AccountName,MemberName)VALUES ('"+int.Parse(Member_Id)+"','"+CDate+"','"+StartMonth+"','"+EndMonth+"','"+float.Parse(MonthlyPay)+"','"+Int16.Parse(Month)+"','"+float.Parse(TotalMamount)+"','"+float.Parse(YearlyPay)+"','"+float.Parse(SubTotal)+"','"+AccountName+"','"+MemberName+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


              //this section for Get account balence
            da = new SqlDataAdapter("SELECT Amount FROM tbl_Account WHERE [Record_Id]='" + int.Parse(Account_ID) + "'", con);
            DS = new DataSet();
            da.Fill(DS);
            DataRow Drow=DS.Tables[0].Rows[0];
            float Amount = float.Parse(Drow.ItemArray.GetValue(0).ToString()) + float.Parse(SubTotal);

            //this section for Update Account Balence
            cmd = new SqlCommand("UPDATE  tbl_Account SET Amount = '" + Amount + "'WHERE   (Record_Id ='" + int.Parse(Account_ID) + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        /// This Section For Show All Payment
        public System.Data.DataTable ShowAllCollection()
        {
            da = new SqlDataAdapter("SELECT   Record_ID, Member_Id, MemberName, CurentDate, StartMonth, EndMonth, MonthlyPay, Months, TotalMounthlyPay, MentenensPay, SubTotal, AccountName FROM      tbl_Membershipcollection",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

       //Search Collection by Date
        public System.Data.DataTable SearchCollectionByDate(string Date)
        {
            da = new SqlDataAdapter("SELECT   Record_ID, Member_Id, MemberName, CurentDate, StartMonth, EndMonth, MonthlyPay, Months, TotalMounthlyPay, MentenensPay, SubTotal, AccountName FROM      tbl_Membershipcollection WHERE CurentDate='"+Date+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Search Collection by Member Nmber
        public System.Data.DataTable SearchCollectionByID(string Id)
        {
            da = new SqlDataAdapter("SELECT   Record_ID, Member_Id, MemberName, CurentDate, StartMonth, EndMonth, MonthlyPay, Months, TotalMounthlyPay, MentenensPay, SubTotal, AccountName FROM      tbl_Membershipcollection WHERE Member_Id='" + Int16.Parse(Id) + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

#endregion

        #region this section for payment


        //This Section Form Get Data From Payment Settings
        public System.Data.DataSet GetPayment(string ID)
        {
            da = new SqlDataAdapter("SELECT   Record_Id, [Payment Name], [Account Name], Amount, Notes FROM      tbl_PaymentSettings WHERE   (Record_Id = '"+Int32.Parse(ID)+"')",con);
            DS = new DataSet();
            da.Fill(DS);
            return DS;
        }

        //Give Payment
        public void givePayment(string Date,string Payment_Id,string PaymentName,string PaymentFor,string Amount)
        {
            cmd = new SqlCommand("INSERT INTO tbl_Payment (PaymentDate, Payment_ID, PaymentName, PaymentFor, Amount) VALUES ('"+Date+"','"+int.Parse(Payment_Id)+"','"+PaymentName+"','"+PaymentFor+"','"+float.Parse(Amount)+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //getAmount And Account Name
            da = new SqlDataAdapter("SELECT   tbl_Account.Amount, tbl_PaymentSettings.[Account Name], tbl_Account.Record_Id FROM tbl_PaymentSettings INNER JOIN tbl_Account ON tbl_PaymentSettings.[Account Name] = tbl_Account.[Account Name] WHERE   (tbl_PaymentSettings.Record_Id = '" + int.Parse(Payment_Id) + "')", con);
            DS = new DataSet();
            da.Fill(DS);
            DataRow drow = DS.Tables[0].Rows[0];
            float finalAmount = float.Parse(drow.ItemArray.GetValue(0).ToString()) + float.Parse(Amount);

            //Update Balence
            cmd = new SqlCommand("UPDATE  tbl_Account SET Amount = '"+finalAmount+"'WHERE   (Record_Id = '"+int.Parse(drow.ItemArray.GetValue(2).ToString())+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public System.Data.DataTable shoAllPayments()
        {
            da = new SqlDataAdapter("SELECT   tbl_Payment.* FROM      tbl_Payment",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchPaymentByPaymentName(string Name)
        {
            da = new SqlDataAdapter("SELECT   Record_Id, PaymentDate, Payment_ID, PaymentName, PaymentFor, Amount FROM      tbl_Payment WHERE   (PaymentName = '"+Name+"')",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchPaymentByDate(string Date)
        {
            da = new SqlDataAdapter("SELECT   Record_Id, PaymentDate, Payment_ID, PaymentName, PaymentFor, Amount FROM      tbl_Payment WHERE   (PaymentDate = '" + Date + "')", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

    }
}
