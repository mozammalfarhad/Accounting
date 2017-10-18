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
    public class dalAllCommon
    {
        public DataTable GetBackupHistory()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_BackupHistory_Get", altParams);
        }

        public int InsertBackupHistory(string BackupBy, string FileName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@BackupBy", BackupBy));
            altParams.Add(new SqlParameter("@FileName", FileName));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_BackupHistory_Insert", altParams);
        }

        public int DeleteBackupHistory(string filename)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FileName", filename));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_BackupHistory_Delete", altParams);
        }

        public DataTable GetLogHistory(string FromDate, string ToDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_LogHistory_GetAll", altParams);

        }
    }
}
