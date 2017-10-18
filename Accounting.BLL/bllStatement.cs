using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
   public class bllStatement
    {
        dalStatement obj = new dalStatement();
        public DataTable GetDailyStatement(DateTime Date)
        {
            return obj.GetDailyStatement(Date);
        }

        public DataTable GetMonthlyTrialBalance(DateTime Date)
        {
            return obj.GetMonthlyTrialBalance(Date);
        }

        public DataTable GetIncomeDataForTheDateRange(DateTime FromDate, DateTime ToDate)
        {
            return obj.GetIncomeDataForTheDateRange(FromDate, ToDate);
        }

        public DataTable GetExpenseDataForTheDateRange(DateTime FromDate, DateTime ToDate)
        {
            return obj.GetExpenseDataForTheDateRange(FromDate, ToDate);
        }
    }
}
