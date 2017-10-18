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
    public class dalLedger
    {

            public DataTable GetAllLedgerForTheHead(int AccHeadId,bool isDateSearch,DateTime DateFrom,DateTime DateTo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AccHeadId", AccHeadId));
            altParams.Add(new SqlParameter("@isDateSearch", isDateSearch));
            altParams.Add(new SqlParameter("@DateFrom", DateFrom));
            altParams.Add(new SqlParameter("@DateTo", DateTo));
            altParams.Add(new SqlParameter("@FiscalYear", 1));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetLedgerForTheHead", altParams);
        }
    }
}
