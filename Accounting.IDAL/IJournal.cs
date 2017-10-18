using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IJournal
    {
       int InsertDebitVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);
       int InsertCreditVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);
       int InsertMultipleVoucher(string MListl);
       int InsertContraVoucher(string MListl);
       int InsertJurnalVoucher(string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);
       int UpdateDebitVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);
       int UpdateCreditVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);
       int UpdateJurnalVoucher(int VId, string VDate, string VNO, string Name, string UserId, string Particulars, decimal Amount, string MListl);

   }
}
