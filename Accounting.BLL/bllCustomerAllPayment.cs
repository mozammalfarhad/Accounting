using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllCustomerAllPayment
    {
        dalCustomerAllPayment obj = new dalCustomerAllPayment();
        public int CustomerBillInsert(DateTime VDate, string VNO, int PatientId, string Particulars, int DebitHeadId, decimal HospitalAmount,
            decimal DiagnosticAmount, string ChequeNo, DateTime ChequeDt, decimal PharmacyAmount, bool isCash, bool IsCheque,decimal Discount)
        {
            return obj.CustomerBillInsert(VDate, VNO, PatientId, Particulars, DebitHeadId, HospitalAmount, DiagnosticAmount, ChequeNo, ChequeDt, PharmacyAmount, isCash, IsCheque, Discount);
        }
    }
}
