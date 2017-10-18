using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllCashBook
    {
        dalCashBook objCash = new dalCashBook();

        public DataTable GetDebitCashBookBetDate(DateTime DateFrom, DateTime DateTo)
        {
            return objCash.GetDebitCashBookBetweenDate(DateFrom, DateTo);
        }

        public DataTable GetCreditCashBookBetDate(DateTime DateFrom, DateTime DateTo)
        {
            return objCash.GetCreditCashBookBetweenDate(DateFrom, DateTo);
        }
    }
}
