using EntityLayer;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class DALEmployee
    {
        public static List<EntityEmployee> EmployeeList()
        {
            List<EntityEmployee> entities = new List<EntityEmployee>();
            SqlCommand command = new SqlCommand("SELECT * FROM TblInformation", Connection.sqlConnection);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                EntityEmployee entityEmployee = new EntityEmployee();
                entityEmployee.Id = int.Parse(sqlDataReader["ID"].ToString());
                entityEmployee.Name = sqlDataReader["NAME"].ToString();
                entityEmployee.Surname = sqlDataReader["SURNAME"].ToString();
                entityEmployee.City = sqlDataReader["CITY"].ToString();
                entityEmployee.Task = sqlDataReader["TASK"].ToString();
                entityEmployee.Salary = int.Parse(sqlDataReader["SALARY"].ToString());
                entities.Add(entityEmployee);
            }
            sqlDataReader.Close();
            return entities;
        }

        public static int AddEmployee(EntityEmployee entityEmployee)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TblInformation (NAME, SURNAME, CITY, TASK, SALARY) VALUES (@NAME, @SURNAME, @CITY, @TASK, @SALARY)", Connection.sqlConnection);
            command.Parameters.AddWithValue("@NAME", entityEmployee.Name);
            command.Parameters.AddWithValue("@SURNAME", entityEmployee.Surname);
            command.Parameters.AddWithValue("@CITY", entityEmployee.City);
            command.Parameters.AddWithValue("@TASK", entityEmployee.Task);
            command.Parameters.AddWithValue("@SALARY", entityEmployee.Salary);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public static bool DeleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TblInformation WHERE ID = @ID", Connection.sqlConnection);
            command.Parameters.AddWithValue("@ID", id);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result > 0;
        }

        public static bool UpdateEmployee(EntityEmployee entityEmployee)
        {
            SqlCommand command = new SqlCommand("UPDATE TblInformation SET NAME = @NAME, SURNAME = @SURNAME, CITY = @CITY, TASK = @TASK, SALARY = @SALARY WHERE ID = @ID", Connection.sqlConnection);
            command.Parameters.AddWithValue("@NAME", entityEmployee.Name);
            command.Parameters.AddWithValue("@SURNAME", entityEmployee.Surname);
            command.Parameters.AddWithValue("@CITY", entityEmployee.City);
            command.Parameters.AddWithValue("@TASK", entityEmployee.Task);
            command.Parameters.AddWithValue("@SALARY", entityEmployee.Salary);
            command.Parameters.AddWithValue("@ID", entityEmployee.Id);
            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result > 0;
        }
    }
}
