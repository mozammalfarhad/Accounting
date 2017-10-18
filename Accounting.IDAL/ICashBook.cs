using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface ICashBook
    {
       DataTable GetDebitCashBookBetDate(DateTime DateFrom, DateTime DateTo);
       DataTable GetCreditCashBookBetDate(DateTime DateFrom, DateTime DateTo);
    }
}
