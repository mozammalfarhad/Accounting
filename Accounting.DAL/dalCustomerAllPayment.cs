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
   public class dalCustomerAllPayment
    {
       public int CustomerBillInsert(DateTime VDate, string VNO, int PatientId, string Particulars, int DebitHeadId, decimal HospitalAmount,
            decimal DiagnosticAmount, string ChequeNo, DateTime ChequeDt, decimal PharmacyAmount, bool isCash, bool IsCheque, decimal Discount)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@VDate", VDate));
            altParams.Add(new SqlParameter("@VNO", VNO));
            altParams.Add(new SqlParameter("@PatientId", PatientId));
            altParams.Add(new SqlParameter("@UserId", ""));
            altParams.Add(new SqlParameter("@Particulars", Particulars));
            altParams.Add(new SqlParameter("@FYear", 1));
            altParams.Add(new SqlParameter("@DebitHeadId", DebitHeadId));
            altParams.Add(new SqlParameter("@HospitalAmount", HospitalAmount));
            altParams.Add(new SqlParameter("@DiagnosticAmount", DiagnosticAmount));
            altParams.Add(new SqlParameter("@ChequeNo", ChequeNo));
            altParams.Add(new SqlParameter("@ChequeDt", ChequeDt));
            altParams.Add(new SqlParameter("@PharmacyAmount", PharmacyAmount));
            altParams.Add(new SqlParameter("@isCash", isCash));
            altParams.Add(new SqlParameter("@IsCheque", IsCheque));
            altParams.Add(new SqlParameter("@Discount", Discount));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Sp_PatientBillPaymentInsert", altParams);
            return Convert.ToInt16(dt.Rows[0][0]);
        }

    }
}
