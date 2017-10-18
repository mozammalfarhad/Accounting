using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace Accounting.DAL
{
    public class dalStatement
    {

        public DataTable GetDailyStatement(DateTime Date)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Date", Date));
            altParams.Add(new SqlParameter("@FYear", 1));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetDailyStatement", altParams);
            return dt;
        }

        public DataTable GetMonthlyTrialBalance(DateTime Date)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Month", Date));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_getMonthlyTrialBalance", altParams);
            return dt;
        }

        public DataTable GetIncomeDataForTheDateRange(DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_IncomeForTheDateRange", altParams);
            return dt;
        }

        public DataTable GetExpenseDataForTheDateRange(DateTime FromDate, DateTime ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_ExpenseForTheDateRange", altParams);
            return dt;
        }
    }
}
