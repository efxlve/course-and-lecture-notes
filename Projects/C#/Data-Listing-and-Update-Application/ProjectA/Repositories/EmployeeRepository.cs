using Dapper;
using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Repositories
{
    internal class EmployeeRepository:BaseRepository
    {
        public EmployeeRepository()
        {
            
        }

        public List<Employee> GetAll()
        {
            List<Employee> dataItemList = new List<Employee>();
            dataItemList = connection.Query<Employee>("SELECT * FROM employees").ToList();
            return dataItemList;
        }

        public Employee GetDataById(int id)
        {
            Employee employee = new Employee();
            var parameters = new { employeeId = id };
            employee = connection.QueryFirstOrDefault<Employee>("SELECT * FROM employees WHERE employeeId = @employeeId", parameters);
            return employee;
        }

        public void UpdateEmployee(string postalCode, string phone, string fax, string email, int employeeId)
        {
            var parameters = new { postalCode = postalCode, phone = phone, fax = fax, email = email, employeeId = employeeId };
            connection.Execute("UPDATE employees SET PostalCode = @postalCode, Phone = @phone, Fax = @fax, Email = @email WHERE EmployeeId = @employeeId", parameters);
        }
    }
}
