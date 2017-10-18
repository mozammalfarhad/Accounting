using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface ICustomer
   {
       DataTable GetAll();
       DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode);
       DataTable GetCustomerBill(int CustomerId);
    }
}
