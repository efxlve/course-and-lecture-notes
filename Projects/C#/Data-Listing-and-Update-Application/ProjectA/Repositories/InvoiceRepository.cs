using Dapper;
using ProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Repositories
{
    internal class InvoiceRepository:BaseRepository
    {
        public List<Invoice> GetAll(int customerid)
        {
            List<Invoice> dataItemList = new List<Invoice>();
            var parameters = new { customerid = customerid };
            dataItemList = connection.Query<Invoice>("SELECT * FROM invoices WHERE customerid = @customerid", parameters).ToList();
            return dataItemList;
        }

        internal object GetAllByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
