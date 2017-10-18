using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IShowVoucher
   {
       DataTable GetAllVoucher(DateTime DateFrom, DateTime DateTo, int VType);
       DataTable GetVoucherDetails(int VId);
       DataTable GetListForVoucherUpdate(int VId, int VType);
    }
}
