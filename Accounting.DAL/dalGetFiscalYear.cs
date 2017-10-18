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
    public class dalGetFiscalYear
    {
        public DataTable GetYearList()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetAllFiscalYear", altParams);
        }
        public DataTable GetFiscalYearById(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AutoID", id));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetFiscalYearForId", altParams);
        }

        public int GetCurrentFiscalYear()
        {
            ArrayList altParams = new ArrayList();
            return Convert.ToInt16((DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_getCurrentFiscalYear", altParams)).Rows[0][0]);
        }
        
    }
}
