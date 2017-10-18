using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllJournal
    {
        dalJournal objJournal = new dalJournal();
        public int InsertDebitVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.InsertDebitVoucher(VDate, VNO, Name, UserId,Particulars, Amount, MListl);
        }

        public int InsertCreditVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.InsertCreditVoucher(VDate, VNO, Name, UserId, Particulars, Amount, MListl);
        }

        public int InsertMultipleVoucher(string MListl)
        {
            return objJournal.InsertMultipleVoucher(MListl);
        }
        public int InsertContraVoucher(string MListl)
        {
            return objJournal.InsertContraVoucher(MListl);
        }
        public int InsertJurnalVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.InsertJurnalVoucher(VDate, VNO, Name, UserId, Particulars, Amount, MListl);
        }
        public int UpdateDebitVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.UpdateDebitVoucher(VId, VDate, VNO, Name, UserId, Particulars, Amount, MListl);
        }
        public int UpdateCreditVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.UpdateCreditVoucher(VId, VDate, VNO, Name, UserId, Particulars, Amount, MListl);
        }
        public int UpdateJurnalVoucher(int VId,string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl)
        {
            return objJournal.UpdateJurnalVoucher(VId,VDate, VNO, Name, UserId, Particulars, Amount, MListl);
        }
    }
}
