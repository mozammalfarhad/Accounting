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
    public class dalShowVoucher
    {
        public DataTable GetAllVoucher(DateTime DateFrom, DateTime DateTo, int VType)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DateFrom", DateFrom));
            altParams.Add(new SqlParameter("@DateTo", DateTo));
            altParams.Add(new SqlParameter("@VType", VType));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetAllVoucher", altParams);
        }

        public DataTable GetVoucherDetails(int VId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VId", VId));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_ViewVoucher", altParams);
        }

        public DataTable GetListForVoucherUpdate(int VId, int VType)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Vid", VId));
            altParams.Add(new SqlParameter("@VType", VType));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_getListForVoucherUpdate", altParams);
        }
    }
}
