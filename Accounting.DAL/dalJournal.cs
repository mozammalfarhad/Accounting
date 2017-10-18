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
    public class dalJournal
    {

        public int InsertDebitVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear",1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_DebitVocherInsert", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int InsertCreditVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_CreditVocherInsert", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int InsertMultipleVoucher(string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserId", ""));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_MultipleVocherInsert", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int InsertContraVoucher(string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserId", ""));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_ContraVocherInsert", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int InsertJurnalVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_JurnalVocherInsert", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int UpdateDebitVoucher(int VId,string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VId", VId));
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_DebitVocherUpdate", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }
        public int UpdateCreditVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VId", VId));
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_CreditVocherUpdate", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }

        public int UpdateJurnalVoucher(int Vid,string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            DataTable tblbuilidreturn = new DataTable();
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VID", Vid));
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@Name", Name));
            altParams.Add(new SqlParameter("@UserId", UserId));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@Amount", Amount));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@MListl", MListl));

            tblbuilidreturn = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_JurnalVocherUpdate", altParams);
            return Convert.ToInt16(tblbuilidreturn.Rows[0][0].ToString());
        }
    }
}