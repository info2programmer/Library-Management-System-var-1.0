using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace LibreryManagmentSystem.Books_Managment
{
    
    class cls_BookManegment
    {
        Lbry Obj = new Lbry();

        #region This section For Refarence

        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        private SqlDataAdapter da;
        private DataTable dt;
        SqlCommand cmd;
        private   int count = 0;

        #endregion


        //Show All Books
        public System.Data.DataTable ShowAllBooks()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Books", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Save Books
        public void SaveBooks(string uniqueNumber,string BookName,string BookCategory,string subCategory,string BookTypes,string SelfNumber,string SelfName,string NumberOfRow,string NumberOfColumn,string SerialNumber)
        {
            int UniqueNumber = int.Parse(uniqueNumber);
            Int16 Row = Int16.Parse(NumberOfRow);
            Int16 Column = Int16.Parse(NumberOfColumn);
            Int16 SNumber = Int16.Parse(SerialNumber);
            cmd = new SqlCommand("INSERT INTO tbl_Books ([Book Number], [Book Name], [Book Category], [Book SubCategory], [Book Type], [Exsit Self], [Self Name], [Number Of Row], [Number Of Column], Number, Status) VALUES ('"+UniqueNumber+"','"+BookName+"','"+BookCategory+"','"+subCategory+"','"+BookTypes+"','"+SelfNumber+"','"+SelfName+"','"+Row+"','"+Column+"','"+SNumber+"','Avaleble')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //Update Books
        public void UpdateBooks(string uniqueNumber, string BookName, string BookCategory, string subCategory, string BookTypes, string SelfNumber, string SelfName, string NumberOfRow, string NumberOfColumn, string SerialNumber,int Update_Id)
        {
            int UniqueNumber = int.Parse(uniqueNumber);
            Int16 Row = Int16.Parse(NumberOfRow);
            Int16 Column = Int16.Parse(NumberOfColumn);
            Int16 SNumber = Int16.Parse(SerialNumber);
            //UPDATE tbl_Books SET [Book Number] =@Number, [Book Name] =@Name, [Book Category] =Category, [Book SubCategory] =@subCategory, [Book Type] =@Type, [Exsit Self] =@SelfNumber, [Self Name] =@SelfName, [Number Of Row] =@Row, [Number Of Column] =@Column, Number =@Number, Status =@Status WHERE Record_ID=@Id
            cmd = new SqlCommand("UPDATE tbl_Books SET [Book Number] ='" + UniqueNumber + "', [Book Name] ='" + BookName + "', [Book Category] ='" + BookCategory + "', [Book SubCategory] ='" + subCategory + "', [Book Type] ='" + BookTypes + "', [Exsit Self] ='" + SelfNumber + "', [Self Name] ='" + SelfName + "', [Number Of Row] ='" + Row + "', [Number Of Column] ='" + Column + "', Number ='" + SNumber + "', Status ='Avaleble' WHERE Record_ID='" + Update_Id + "'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //Search By Unique Self Number
        public System.Data.DataTable SearchByUniqueBookNumber(string number)
        {
            int UniqueNumber = int .Parse(number);
            da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Book Number]='" + UniqueNumber + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Search By Category
        public System.Data.DataTable SearchByBookCategory(string category)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Book Category]='" + category + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Search By sub CateGory
        public System.Data.DataTable SearchByBookSubCategory(string categoery)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Book SubCategory]='" + categoery + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Search By Books Types
        public System.Data.DataTable SearchByBooksType(string type)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Book Type]='" + type + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Search By Bookself
        public System.Data.DataTable SearchByBookSelf(string BookSelf)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Books WHERE [Self Name]='" + BookSelf + "' ", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //chkBookNumber
        public bool CheckUniqueBookNumber(string Data)
        {
           
                int Number = int.Parse(Data);
                cmd = new SqlCommand("SELECT * FROM tbl_Books WHERE [Book Number]='" + Number + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Int16 count = 0;
                while (dr.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
           
        }


        //Serach By Bokk Name
            public System.Data.DataTable SearchBookByName(string Name)
            {
                da = new SqlDataAdapter("SELECT [Book Number], [Book Name], [Exsit Self], [Self Name], [Number Of Row], [Number Of Column], Number, Status FROM  tbl_Books WHERE [Book Name] LIKE '%'+'" + Name + "'+'%'", con);
                dt= new DataTable();
                da.Fill(dt);
                return dt;
            }


        //Get Date 
            public string getDate(string Member_Id)
            {
                Int32 Id = Int32.Parse(Member_Id);
                da = new SqlDataAdapter("SELECT   tbl_MemberSettings.[Days Of Book Keeping] FROM tbl_Member INNER JOIN tbl_MemberSettings ON tbl_Member.[Member Type] = tbl_MemberSettings.[Member Type] WHERE (tbl_Member.[Member Id] = '" + Id + "')", con);
                dt = new DataTable();
                da.Fill(dt);
                string maxDate = dt.Rows[0].ToString();
                return maxDate;
            }


        //Save Book Issue
            public void SaveBookIssue(string Member_Id,string Book_Id,string Issue_Date,string Return_Date)
            {
                cmd = new SqlCommand("INSERT INTO tbl_BookIssu (Member_Id, Book_Id, [Issu Date], [Return Date], Returned) VALUES ('"+Member_Id+"','"+Book_Id+"','"+Issue_Date+"','"+Return_Date+"','No')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new SqlCommand("UPDATE  tbl_Books SET Status ='Not Avaleble' WHERE [Book Number]='" + Book_Id + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }



        //Show All Book Issue
            public System.Data.DataTable ShowAllBookissue()
            {
                da = new SqlDataAdapter("SELECT * FROM tbl_BookIssu",con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }



        //Search By Member Number
            public System.Data.DataTable SearchByMemberNumberIssu(string MemberNumber)
            {
                da = new SqlDataAdapter("SELECT   Record_Id, Member_Id, Book_Id, [Issu Date], [Return Date], Returned FROM  tbl_BookIssu WHERE   (Member_Id = '"+MemberNumber+"')",con);
                dt= new DataTable();
                da.Fill(dt);
                return dt;
            }


        //Search By Date
            public System.Data.DataTable SearchByIssuDateIssu(string Date)
            {
                da = new SqlDataAdapter("SELECT   Record_Id, Member_Id, Book_Id, [Issu Date], [Return Date], Returned FROM  tbl_BookIssu WHERE   ([Issu Date] = '" + Date + "')", con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }


        //Search By Return Date
            public System.Data.DataTable SearchByReturnDateIssu(string Date)
            {
                da = new SqlDataAdapter("SELECT   Record_Id, Member_Id, Book_Id, [Issu Date], [Return Date], Returned FROM  tbl_BookIssu WHERE   ([Return Date] = '" + Date + "')", con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }


        //Search Return Book By MemberName 
            public System.Data.DataTable ReturnBook(string Member_Id)
            {
                da = new SqlDataAdapter("SELECT tbl_BookIssu.Record_Id, tbl_BookIssu.Member_Id, tbl_Member.[Member Name], tbl_Member.[Mobile Number], tbl_Member.Address, tbl_Member.Email, tbl_BookIssu.Book_Id, tbl_BookIssu.[Issu Date], tbl_BookIssu.[Return Date],tbl_Books.[Book Name], tbl_Books.[Exsit Self] FROM tbl_BookIssu INNER JOIN tbl_Member ON tbl_BookIssu.Member_Id = tbl_Member.[Member Id] INNER JOIN tbl_Books ON tbl_BookIssu.Book_Id = tbl_Books.[Book Number] WHERE   (tbl_BookIssu.Member_Id='" + Member_Id + "')", con);
                dt = new DataTable();
                da.Fill(dt); 
                return dt;
            }

        //check membernumbe dose exist
            public bool CheckMemberNumber(string Member_Id)
            {
                Int32 Id = Int32.Parse(Member_Id);
                Int16 count = 0;
                cmd = new SqlCommand("SELECT   [Member Id] FROM tbl_Member WHERE ([Member Id] = '" + Id + "')", con);
                con.Open();
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    count++;
                }
                con.Close();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void CollectBooks(string Book_Id)
            {
                cmd = new SqlCommand("UPDATE  tbl_BookIssu SET Returned = 'Yes' WHERE (Book_Id = '"+Book_Id+"')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Int32 Number = Int32.Parse(Book_Id);
                cmd = new SqlCommand("UPDATE  tbl_Books SET Status = 'Avaleble' WHERE   ([Book Number] = '" + Number + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

#region This Section Total Books Property
        //GetTotal Books
            private int totalBooks()
            {
                cmd = new SqlCommand("SELECT * FROM tbl_Books",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                }
                con.Close();
                return count;
            }
            public int TotalBooks
            {
                get { return totalBooks(); }
            }
#endregion
        //

        //Number Of Book which Is Issue
            private string TotalIssueBookMethord()
            {
                cmd = new SqlCommand("SELECT   tbl_Books.* FROM      tbl_Books WHERE Status='Not Avaleble'",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Int16 count = 0;
                while (dr.Read())
                {
                    count++;
                }
                con.Close();
                return count.ToString();
            }
            public string TotalIssueBook { get { return TotalIssueBookMethord(); } }
        }

    }
