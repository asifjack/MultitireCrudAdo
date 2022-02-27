using System;
using System.Collections.Generic;
using System.Text;
using CommonLayer.Models;
using DataAccessLayer;

namespace BussinessAceessLayer
{
    public class BLEmployeeBussiness
    {
        private EmployeeDataAccessDb employeeDb;
        public BLEmployeeBussiness()
        {
            employeeDb = new EmployeeDataAccessDb();
        }
        public List<Employees> GetEmployees()
        {
            return employeeDb.GetEmployees();
        }
        public Employees GetEmployeesById(int id)
        {
            return employeeDb.GetEmployeesById(id);
        }
        public bool CreateEmployee(Employees employee)
        {
            return employeeDb.CreateEmployee(employee);
        }
        public bool DeleteEmployee(int id)
        {
            return employeeDb.DeleteEmployee(id);
        }
        public bool UpdateEmployee(Employees employee)
        {
            return employeeDb.UpdateEmployee(employee);
        }
    }
}








