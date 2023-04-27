using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class dataLayer
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public dataLayer()
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-P73CSRJSQLEXPRESS;Initial Catalog=Company_SD;Integrated Security=True");
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

        }
        public int InsertDepartment(string Dname, int Dno)
        {
            sqlCommand.CommandText = $"INSERT INTO Departments([Dname], [Dnum]) VALUES('{Dname}', {Dno})";
            sqlConnection.Open();
            int count = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return count;
        }
        public DataTable GetDepartments()
        {
            sqlCommand.CommandText = "Select * From Departments";
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }




        //public DataTable GetEmplooyees()
        //{
        //    sqlCommand.CommandText = "Select * From Employee";
        //    DataTable dataTable = new DataTable();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    sqlDataAdapter.Fill(dataTable);
        //    return dataTable;
        //}
        //public DataTable GetDepartments()
        //{
        //    sqlCommand.CommandText = "Select * From Departments";
        //    DataTable dataTable = new DataTable();
        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    sqlDataAdapter.Fill(dataTable);
        //    return dataTable;
        //}
        //public int InsertEmployee(string fname, string lname, decimal salary, int dno)
        //{
        //    sqlCommand.CommandText = $"INSERT INTO [dbo].[Employee] ([Fname]  ,[Lname] ,[Salary],[Dno] ) VALUES('{fname}','{lname}',{salary},{dno})";
        //    sqlConnection.Open();
        //    int count = sqlCommand.ExecuteNonQuery();
        //    sqlConnection.Close();
        //    return count;
        //}
    }
}
