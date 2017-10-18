using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IStatement
   {
       DataTable GetDailyStatement(DateTime Date);
       DataTable GetMonthlyTrialBalance(DateTime Date);
       DataTable GetIncomeDataForTheDateRange(DateTime FromDate, DateTime ToDate);
       DataTable GetExpenseDataForTheDateRange(DateTime FromDate, DateTime ToDate);
    }
}
