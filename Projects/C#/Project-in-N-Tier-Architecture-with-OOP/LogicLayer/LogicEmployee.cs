using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicEmployee
    {
        public static List<EntityEmployee> LLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }

        public static int LLEmployeeAdd(EntityEmployee entityEmployee)
        {
            if (entityEmployee.Name != "" && entityEmployee.Surname != "" && entityEmployee.City != "" && entityEmployee.Task != "" && entityEmployee.Salary >= 1) 
            {
                return DALEmployee.AddEmployee(entityEmployee);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLEmployeeDelete(int id)
        {
            if (id >= 1)
            {
                return DALEmployee.DeleteEmployee(id);
            }
            else
            {
                return false;
            }
        }

        public static bool LLEmployeeUpdate(EntityEmployee entityEmployee)
        {
            if (entityEmployee.Id >= 1 && entityEmployee.Name != "" && entityEmployee.Surname != "" && entityEmployee.City != "" && entityEmployee.Task != "" && entityEmployee.Salary >= 1)
            {
                return DALEmployee.UpdateEmployee(entityEmployee);
            }
            else
            {
                return false;
            }
        }
    }
}
