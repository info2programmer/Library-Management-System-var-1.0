using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using LibraryManagmentpro.Properties;

namespace LibreryManagmentSystem
{
    class Lbry
    {
        #region This section For Refarence

        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        private SqlDataAdapter da;
        private DataTable dt;
        SqlCommand cmd;
        float Payment;

        #endregion

        #region This Section For Account

        public void CreateAccount(string account_name,string account_type)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Account ([Account Name], [Account Type],Amount) VALUES ('" + account_name + "','" + account_type + "',0)", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public System.Data.DataTable AccountList()
        {
            da = new SqlDataAdapter("SELECT * FROM  tbl_Account", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchAccountList(string SearchItem)
        {
            da = new SqlDataAdapter("SELECT Record_Id, [Account Name], [Account Type] FROM  tbl_Account WHERE  ([Account Name] LIKE '%'+'" + SearchItem + "'+'%')", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AccountNameAndTypeUpdate(int Update_Id, string AccountcName,string Accounttype)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Account SET  [Account Name] = '" + AccountcName + "', [Account Type] ='" + Accounttype + "' WHERE ([Record_Id] = '" +Update_Id+ "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllAccountName()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Account", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Get All Income Account
        public System.Data.DataTable IncomeAccount()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE [Account Type]='Income' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //get all Expend Account
        public System.Data.DataTable ExpandAccount()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Account WHERE [Account Type]='Expend' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region This Section Book Settings

        public void AddBookSettings(string BookCategory,string BookSubCategory,string BooksType,string Notes)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_BookSettings ([Book Category], [Book SubCategory], [Books Type], Notes) VALUES ('" + BookCategory + "','" + BookCategory + "','" + BooksType + "','" + Notes + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllBookSettings()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateBookSettings(int UpdateId, string BookCategory, string BookSubCategory, string BooksType, string Notes)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_BookSettings SET [Book Category] = '" + BookCategory + "', [Book SubCategory] = '" + BookSubCategory + "', [Books Type] ='" + BooksType + "', Notes = '" + Notes + "'  WHERE (Record_ID = '"+UpdateId+"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public System.Data.DataTable ShowAllBookCategory()
        {
            da = new SqlDataAdapter("SELECT [Book Category] FROM tbl_BookSettings",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public System.Data.DataTable ShowAllBookSubCategory()
        {
            da = new SqlDataAdapter("SELECT [Book SubCategory] FROM tbl_BookSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllBooksType()
        {
            da = new SqlDataAdapter("SELECT [Books Type] FROM tbl_BookSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByBookCategory(string category)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSettings WHERE [Book Category]='"+category+"' ",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByBookSubCategory(string subcategory)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSettings WHERE [Book SubCategory]='" + subcategory + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByBooksType(string type)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSettings WHERE [Books Type]='" + type + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region This Section Book Self Settings

        //Save Book Self
        public void SaveBookSelfSettings(string BookselfNumber,string BookSelfName,string numOfRa,string numOfColomn,string BookCategory,string Notes)
        {

            con.Open();
            cmd = new SqlCommand("INSERT INTO tbl_BookSelfSettings ([Unique Self Number], [Book Self Name], [Number Of Raw], [Numbar Of Column], [Book Category], Notes) VALUES ('"+BookselfNumber+"','"+BookSelfName+"','"+numOfRa+"','"+numOfColomn+"','"+BookCategory+"','"+Notes+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //check unique Books Self
        public bool ValidUniqueSelfNumber(string Number)
        {
            cmd = new SqlCommand("SELECT [Unique Self Number] FROM tbl_BookSelfSettings WHERE ([Unique Self Number] = '"+Number+"')",con);
            con.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            Int32 count = 0;
            while (dr.Read())
            {
                count++;
            }
            con.Close();
            if (count == 1 || count > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Show All Books Self
        public System.Data.DataTable ShowAllBookSelfSettings()
        {
            da = new SqlDataAdapter("SELECT [Unique Self Number], [Book Self Name], [Book Category], [Numbar Of Column], [Number Of Raw], Notes FROM  tbl_BookSelfSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Update Books Self
        public void UpdateBookselfSettings(string BookselfNumber, string BookSelfName, string numOfRa, string numOfColomn, string BookCategory, string Notes)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE tbl_BookSelfSettings SET [Book Self Name] = '" + BookSelfName + "', [Number Of Raw] = '" + numOfRa + "', [Numbar Of Column] = '" + numOfColomn + "', [Book Category] = '" + BookCategory + "', Notes = '" + Notes + "' WHERE ([Unique Self Number]  = " +BookselfNumber + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable SearchByBookSelfName(string BookSelfName)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSelfSettings WHERE [Book Self Name]='"+BookSelfName+"'",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public System.Data.DataTable SearchByUniqueSelfNumber(string Number)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSelfSettings WHERE [Unique Self Number]='" + Number + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByNumberOfRow(string Row)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSelfSettings WHERE [Number Of Raw]='" + Row + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByNumberOfColumn(string Column)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_BookSelfSettings WHERE [Namber Of Column]='" + Column + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllBookSelfName()
        {
            da = new SqlDataAdapter("SELECT [Book Self Name] FROM tbl_BookSelfSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllNumberOfRow()
        {
            da = new SqlDataAdapter("SELECT [Number Of Raw] FROM tbl_BookSelfSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllNumberOfColumn()
        {
            da = new SqlDataAdapter("SELECT  [Numbar Of Column] FROM tbl_BookSelfSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        #endregion

        #region This Section for Employee Settings


        public void SaveEmployeeSettings(string EmployeeType,string MonthlyPay,string StartTime,string EndTime)
        {
            Payment = float.Parse(MonthlyPay);
            cmd = new SqlCommand("INSERT INTO tbl_EmployeeeSettings ([Employee Type], [Monthly Payment], [Start Duty], [End Duty]) VALUES ('" + EmployeeType + "','" + Payment + "','" + StartTime + "','" + EndTime + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllEmployeeSettings()
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeeSettings.* FROM tbl_EmployeeeSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateEmployeeSettings(string EmployeeType, string MonthlyPay, string StartTime, string EndTime,int Update_Id)
        {
            Payment = float.Parse(MonthlyPay);
            cmd = new SqlCommand("UPDATE       tbl_EmployeeeSettings SET [Employee Type] = '"+EmployeeType+"', [Monthly Payment] = '"+Payment+"', [Start Duty] = '"+StartTime+"', [End Duty] ='"+EndTime+"' WHERE (Record_Id = '"+Update_Id+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public System.Data.DataTable ShowAllEmployeeTypes()
        {
            da = new SqlDataAdapter("SELECT [Employee Type] FROM tbl_EmployeeeSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllPayment()
        {
            da = new SqlDataAdapter("SELECT [Monthly Payment] FROM tbl_EmployeeeSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByEmployeeType(string Type)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_EmployeeeSettings WHERE [Employee Type]='" + Type + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByMonthlyPayment(string Pay)
        {
            Payment = float.Parse(Pay);
            da = new SqlDataAdapter("SELECT * FROM tbl_EmployeeeSettings WHERE [Monthly Payment]='" + Payment + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable searchByStartTime(string Time)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_EmployeeeSettings WHERE [Start Duty]='" + Time + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable searchByEndTime(string Time)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_EmployeeeSettings WHERE [End Duty]='" + Time + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region This Section For Member Settings

        public void SaveMemberSettings(string Type,string pay,string bookkeep,string finevalue,string YearlyPay,string Notes)
        {
            Payment = float.Parse(pay);
            Int16 bookkeeping = Int16.Parse(bookkeep);
            float fine = float.Parse(finevalue);
            cmd = new SqlCommand("INSERT INTO tbl_MemberSettings  ([Member Type], [Monthly Pay], [Days Of Book Keeping], [Fine Value],[Yearly Pay],Notes) VALUES ('" + Type + "','" + Payment + "','" + bookkeeping + "','" + fine + "','"+float.Parse(YearlyPay)+"','"+Notes+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllSettings()
        {
            da = new SqlDataAdapter("SELECT  Record_Id, [Member Type], [Monthly Pay], [Yearly Pay], [Fine Value], [Days Of Book Keeping], Notes FROM tbl_MemberSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpdateMemberSettings(string Type, string pay, string bookkeep, string finevalue, int Update_Id, string YearlyPay, string Notes)
        {
            Payment = float.Parse(pay);
            Int16 bookkeeping = Int16.Parse(bookkeep);
            float fine = float.Parse(finevalue);
            //UPDATE  tbl_MemberSettings SET  [Member Type] = @d, [Monthly Pay] = @c, [Days Of Book Keeping] = @b, [Fine Value] = @a WHERE (Record_Id = @Update_Id)
            cmd = new SqlCommand("UPDATE  tbl_MemberSettings SET  [Member Type] = '"+Type+"', [Monthly Pay] = '"+Payment+"', [Days Of Book Keeping] = '"+bookkeeping+"', [Fine Value] = '"+fine+"',[Yeraly Pay]='"+float.Parse(YearlyPay)+"',Nots='"+Notes+"' WHERE (Record_Id ='"+Update_Id+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllMemberType()
        {
            da = new SqlDataAdapter("SELECT [Member Type] FROM tbl_MemberSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllMemberMonthlyPay()
        {
            da = new SqlDataAdapter("SELECT [Monthly Pay] FROM tbl_MemberSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllMemberDaysOfBookKeeping()
        {
            da = new SqlDataAdapter("SELECT [Days Of Book Keeping] FROM tbl_MemberSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByMemberType(string Type)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_MemberSettings WHERE [Member Type]='"+Type+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByMemberMonthlyPayment(string Pay)
        {
            Payment = float.Parse(Pay);
            da = new SqlDataAdapter("SELECT * FROM tbl_MemberSettings WHERE [Monthly Pay]='" + Payment + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByMemberBookKeeping(string Bookeep)
        {
            Int16 Date = Int16.Parse(Bookeep);
            da = new SqlDataAdapter("SELECT * FROM tbl_MemberSettings WHERE [Days Of Book Keeping]='" + Date + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        #region This Section for Payment Settings

        public void SavePaymentSettings(string paymentName,string AccountName,string Amount,string Notes)
        {
            Payment = float.Parse(Amount);
            cmd = new SqlCommand("INSERT INTO tbl_PaymentSettings ([Payment Name], [Account Name], Amount, Notes) VALUES ('"+paymentName+"','"+AccountName+"','"+Payment+"','"+Notes+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public System.Data.DataTable ShowAllPaymentSettings()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_PaymentSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable ShowAllPaymentName()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_PaymentSettings", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void UpadtePaymentSettings(int Upadte_id, string paymentName, string AccountName, string Amount, string Notes)
        {
            Payment = float.Parse(Amount);
            cmd = new SqlCommand("UPDATE tbl_PaymentSettings SET [Payment Name] ='"+paymentName+"', [Account Name] ='"+AccountName+"', Amount ='"+Payment+"', Notes ='"+Notes+"' WHERE Record_Id='"+Upadte_id+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public System.Data.DataTable SearchByAccountName(string Name)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_PaymentSettings WHERE [Account Name]='"+Name+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public System.Data.DataTable SearchByPaymentName(string PaymentName)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_PaymentSettings WHERE [Payment Name]='" + PaymentName + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
