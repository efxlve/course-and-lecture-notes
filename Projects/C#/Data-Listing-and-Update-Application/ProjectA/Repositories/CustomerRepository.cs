using Dapper;
using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Repositories
{
    internal class CustomerRepository:BaseRepository
    {
        public List<Customer> GetAllByEmployeeId(int employeeId)
        {
            List<Customer> dataItemList = new List<Customer>();
            var parameters = new { employeeId = employeeId };
            dataItemList = connection.Query<Customer>("SELECT * FROM customers WHERE SupportRepId = @employeeId", parameters).ToList();
            return dataItemList;
        }
            
    }
}
