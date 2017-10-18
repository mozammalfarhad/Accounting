using Accounting.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllLedger
    {

        dalLedger objL = new dalLedger();
        public DataTable GetAllLedgerForTheHead(int AccHeadId,bool isDateSearch,DateTime DateFrom,DateTime DateTo)
        {
            return objL.GetAllLedgerForTheHead(AccHeadId, isDateSearch, DateFrom, DateTo);
        }
    }
}
