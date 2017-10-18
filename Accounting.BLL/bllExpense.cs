using Accounting.DAL;
using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
   public class bllExpense
    {
       dalExpense de = new dalExpense();
       public int InsertUpdate(ExpenseTable et)
       {
           return de.InsertUpdate(et);

       }
    }
}
