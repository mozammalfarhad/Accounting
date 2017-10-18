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
    public class dalIncome
    {

        public dalIncome()
        {
        }
        public DataTable GetClientAdvanceAndOthers(string FlatorRoomId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FlatorRoomId", FlatorRoomId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetClientAdvanceAntOthers", altParams);
            return dt;
        }

        public int FlatorRoomIncome(string datastring)
        {
            string userName = "";
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@MListl", datastring));
            altParams.Add(new SqlParameter("@FiscalYear", 1));
            altParams.Add(new SqlParameter("@UserId", userName));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_FlatorRoomIncomeInsert", altParams);
            return Convert.ToInt16(dt.Rows[0][0]);
        }
    }
}
