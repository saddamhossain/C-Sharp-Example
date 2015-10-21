using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HelloWorldMvc.Models
{
    public class DepartmentContainer
    {
       public List<Department> GetAllDept()
        {
            List<Department> departments = new List<Department>();

            string conn = @"server=SADDAMHOSSAIN\SQLEXPRESS; database=DepartmentDB; integrated security=true";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();

            string query = string.Format("SELECT * FROM t_Department");
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();

            while(aReader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Name = aReader[1].ToString();
                aDepartment.Code = aReader[2].ToString();
                departments.Add(aDepartment);
            }

            connection.Close();
            return departments;
        }
    }
}