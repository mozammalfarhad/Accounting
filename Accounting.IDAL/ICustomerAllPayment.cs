using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface ICustomerAllPayment
    {
       int CustomerBillInsert(DateTime VDate, string VNO, int PatientId, string Particulars, int DebitHeadId, decimal HospitalAmount,
              decimal DiagnosticAmount, string ChequeNo, DateTime ChequeDt, decimal PharmacyAmount, bool isCash, bool IsCheque, decimal Discount);
    }
}
