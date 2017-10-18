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
    public class dalCashBook
    {
        public DataTable GetCreditCashBookBetweenDate(DateTime DateFrom,DateTime DateTo)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", DateFrom));
            altParams.Add(new SqlParameter("@ToDate", DateTo));
            altParams.Add(new SqlParameter("@FYear",1));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetCreditCashBook", altParams);
        }

        public DataTable GetDebitCashBookBetweenDate(DateTime DateFrom,DateTime DateTo)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", DateFrom));
            altParams.Add(new SqlParameter("@ToDate", DateTo));
            altParams.Add(new SqlParameter("@FYear", 1));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetDebitCashBook", altParams);
        }
    }
}
