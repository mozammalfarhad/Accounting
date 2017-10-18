using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IExpense
   {
       int InsertUpdate(ExpenseTable et);
    }
}
