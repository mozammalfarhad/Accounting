using Accounting.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace Accounting.DAL
{
    public class dalExpense
    {
        public int InsertUpdate(ExpenseTable et)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Id", et.Id));
            altParams.Add(new SqlParameter("@AccountingTypeId", et.AccountingTypeId));
            altParams.Add(new SqlParameter("@Amount", et.Amount));
            altParams.Add(new SqlParameter("@BankId", et.BankId));
            altParams.Add(new SqlParameter("@BankPay", et.BankPay));
            altParams.Add(new SqlParameter("@BuildingId", et.BuildingId));
            altParams.Add(new SqlParameter("@CashPay", et.CashPay));
            altParams.Add(new SqlParameter("@CequeNumber", et.CequeNumber));
            altParams.Add(new SqlParameter("@Date", et.Date.Date));
            altParams.Add(new SqlParameter("@userid", et.userid));
            altParams.Add(new SqlParameter("@payto", et.payto));
            altParams.Add(new SqlParameter("@vouchernumber", et.VoucherNumber));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("Acc_sp_ExpenceInsertUpdate", altParams);
        }
    }
}
