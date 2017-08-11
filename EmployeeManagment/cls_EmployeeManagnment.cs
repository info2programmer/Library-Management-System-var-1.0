using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace LibreryManagmentSystem.EmployeeManagment
{
    class cls_EmployeeManagnment
    {
        #region This section For Refarence

        SqlConnection con = new SqlConnection(LibraryManagmentpro.Properties.Settings.Default.Database1ConnectionString);
        private SqlDataAdapter da;
        private DataTable dt;
        SqlCommand cmd;

        #endregion


        //Save Employee
        public void SaveEmployee(string EmployeeName,string Gender,string dob ,string Join,string adress,string EmployeeType,string BankName,string accountNumber,string IFC,string Phone)
        {
            cmd = new SqlCommand("INSERT INTO tbl_Employee ([Employee Name], Gender, DOB, [Joinning Date], Address, [Employee Type], [Bank Name], [Account Number], IFC, Status,[Phone Number]) VALUES ('" + EmployeeName + "','" + Gender + "','" + dob + "','" + Join + "','" + adress + "','" + EmployeeType + "','"+BankName+"','"+accountNumber+"','"+IFC+"','Active','"+Phone+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //this code for display all employee
        public System.Data.DataTable ShowAllEmployee()
        {
            da = new SqlDataAdapter("SELECT tbl_Employee.Record_Id, tbl_Employee.[Employee Name], tbl_Employee.Gender, tbl_Employee.DOB, tbl_Employee.[Joinning Date], tbl_Employee.Address, tbl_Employee.[Employee Type], tbl_Employee.[Phone Number], tbl_Employee.Status, tbl_EmployeeeSettings.[Start Duty], tbl_EmployeeeSettings.[End Duty], tbl_Employee.[Bank Name], tbl_Employee.[Account Number], tbl_Employee.IFC FROM tbl_EmployeeeSettings INNER JOIN  tbl_Employee ON tbl_EmployeeeSettings.[Employee Type] = tbl_Employee.[Employee Type]", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Show All Employee 
        public System.Data.DataTable ShowEmployeeeType()
        {
            da = new SqlDataAdapter("SELECT [Employee Type] FROM      tbl_EmployeeeSettings",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Update Employees
        public void UpdateEmployee(string Updatre_Id, string EmployeeName, string Gender, string dob, string Join, string adress, string EmployeeType, string BankName, string accountNumber, string IFC, string Phone)
        {
            Int32 Id = Int32.Parse(Updatre_Id);
            cmd = new SqlCommand("UPDATE  tbl_Employee SET [Employee Name] = '"+EmployeeName+"', Gender = '"+Gender+"', DOB = '"+dob+"', [Joinning Date] = '"+Join+"', Address = '"+adress+"', [Bank Name] = '"+BankName+"', [Account Number] = '"+accountNumber+"', IFC = '"+IFC+"', [Employee Type] = '"+EmployeeType+"',[Phone Number] = '"+Phone+"' WHERE   (Record_Id = '"+Id+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Search Employeee By Employee Type
        public System.Data.DataTable SearchByEmployeeType(string Type)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Employee WHERE [Employee Type]='"+Type+"'",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Employee By EmployeeName

        public System.Data.DataTable SearchByEmployeeName(string Name)
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Employee WHERE [Employee Name]='" + Name + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Show EmployeeName From ComboBox
        public System.Data.DataTable cmboEmployeeName()
        {
            da = new SqlDataAdapter("SELECT * FROM tbl_Employee",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Save Employee Status
        public void SaveEmployeeStatus(string Name,string Status,string startDate,string EndDate,string Notes,string Update_Id)
        {
            cmd = new SqlCommand("INSERT INTO tbl_EmployeeStatus ([Employee Name], Status, [Start Date], [End Date], Notes) VALUES('"+Name+"','"+Status+"','"+startDate+"','"+EndDate +"','"+Notes+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            int Id = int.Parse(Update_Id);
            cmd = new SqlCommand("UPDATE  tbl_Employee SET Status ='"+Status+"' WHERE Record_Id='" + Id + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        

        //Show All Employee Status
        public System.Data.DataTable showAllEmployeestatus()
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeStatus.* FROM      tbl_EmployeeStatus",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }


        //search Employee Status By Employee Name

        public System.Data.DataTable SearchStatusByEmployeeName(string Name)
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeStatus.* FROM      tbl_EmployeeStatus WHERE [Employee Name]='"+Name+"'",con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Employee Status By Employee Status
        public System.Data.DataTable SearchStatusByEmployeeStatus(string Status)
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeStatus.* FROM      tbl_EmployeeStatus WHERE [Status]='" + Status + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Employee Status By Start Date
        public System.Data.DataTable SearchStatusByStartDate(string Date)
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeStatus.* FROM      tbl_EmployeeStatus WHERE [Start Date]='" + Date + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Search Employee Status By EndDate Date
        public System.Data.DataTable SearchStatusByEndDate(string Date)
        {
            da = new SqlDataAdapter("SELECT tbl_EmployeeStatus.* FROM      tbl_EmployeeStatus WHERE [End Date]='" + Date + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //count All Employees
        private string countEmployee()
        {
            cmd = new SqlCommand("SELECT * FROM tbl_Employee",con);
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
        public string TotalEmployees { get {return countEmployee(); } }
    }
}
