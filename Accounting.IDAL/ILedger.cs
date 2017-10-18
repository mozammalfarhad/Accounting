using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface ILedger
   {
       DataTable GetAllLedgerForTheHead(int AccHeadId, bool isDateSearch, DateTime DateFrom, DateTime DateTo);
    }
}
