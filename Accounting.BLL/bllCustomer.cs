using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
   public class bllCustomer
    {
       dalCustomer objCustomer = new dalCustomer();

        public DataTable GetAll()
        {
            return objCustomer.GetAll();
        }
        public DataTable GetList(int StartRowIndex, int MaxRows, string Criteria, bool PrintMode)
        {
            return objCustomer.GetList(StartRowIndex, MaxRows, Criteria, PrintMode);
        }
        public DataTable GetCustomerBill(int CustomerId)
        {
            return objCustomer.GetCustomerBill(CustomerId);
        }
        
       
    }
}
