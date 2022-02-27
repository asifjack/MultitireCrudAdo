using System;
using CommonLayer.Models;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class EmployeeDataAccessDb
    {
        /*Db Connection Class*/
        private DbConnection db = new DbConnection();

        /* Get All Employees */
        public List<Employees> GetEmployees()
        {
            string query = "select * from Employees"; //SQL Query For All Employees
            SqlCommand command = new SqlCommand();    //SQL CMD For Connection And CMD
            command.Connection = db.Cnn;              // Passing Connection String
            command.CommandText = query;              //Passing SQL Query
            command.CommandType = System.Data.CommandType.Text;  //CMD Type
            if (db.Cnn.State == System.Data.ConnectionState.Closed)  //Checking Connection
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader();     // Executing And Get ALl Records In SQR Class
            List<Employees> employees = new List<Employees>();  //A List For Adding All Employees
            while (reader.Read())
            {
                Employees Emp = new Employees();
                Emp.Id = (int)reader["Id"];
                Emp.FirstName = reader["FirstName"].ToString();
                Emp.LastName = reader["LastName"].ToString();
                Emp.Email = reader["Email"].ToString();
                Emp.Gender = reader["Gender"].ToString();
                employees.Add(Emp);

            }
            db.Cnn.Close();
            return employees;
        }

        // Get By Id Employee Record.
        public Employees GetEmployeesById(int id)  
        {
            string query = "select * from Employees where id="+id;
            SqlCommand command = new SqlCommand();
            command.Connection = db.Cnn;
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            SqlDataReader reader = command.ExecuteReader(); // errorr here
            reader.Read();
            Employees Emp = new Employees();
            Emp.Id = (int)reader["Id"];
            Emp.FirstName = reader["FirstName"].ToString();
            Emp.LastName = reader["LastName"].ToString();
            Emp.Email = reader["Email"].ToString();
            Emp.Gender = reader["Gender"].ToString();
            db.Cnn.Close();
            return Emp;
        }

        //Creating New Employee Method
        public bool CreateEmployee(Employees employee)
        {
            string query = "insert into Employees Values('" +
                employee.FirstName + "','" +
                employee.LastName + "','" + 
                employee.Email + "','" + 
                employee.Gender + "')";
            SqlCommand cmd = new SqlCommand(query, db.Cnn);
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            int i = cmd.ExecuteNonQuery();
            db.Cnn.Close();
            return Convert.ToBoolean(i);
        }

        // Deleting Employee Record
        public bool DeleteEmployee(int id)
        {
            string query = "Delete From Employees Where id="+id+" ";
            SqlCommand cmd = new SqlCommand(query, db.Cnn);
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            int i = cmd.ExecuteNonQuery();
            db.Cnn.Close();
            return Convert.ToBoolean(i);
        }

        //Update A Record
        public bool UpdateEmployee(Employees employee)
        {
            string query = "Update Employees Set FirstName=" +
                employee.FirstName + "," + "LastName=" + employee.LastName + "," +
                "Email =" + employee.Email + "," + "Gender=" + employee.Gender + "where id=" + employee.Id;
            //string query = $"Update Employees Set FirstName='{employee.FirstName}', LastName='{employee.LastName}' ,Email='{employee.Email}', Gender= '{employee.Gender}' Where id='{employee.Id}'";
            SqlCommand cmd = new SqlCommand(query, db.Cnn);
            if (db.Cnn.State == System.Data.ConnectionState.Closed)
                db.Cnn.Open();
            int i = cmd.ExecuteNonQuery();
            db.Cnn.Close();
            return Convert.ToBoolean(i);
        }

    }
}
