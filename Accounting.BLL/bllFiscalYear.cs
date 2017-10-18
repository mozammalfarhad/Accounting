using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllFiscalYear
    {
       dalGetFiscalYear objP = new dalGetFiscalYear();
        public DataTable GetYearList()
        {
            return objP.GetYearList();
        }
        public DataTable GetFiscalYearById(int id)
        {
            return objP.GetFiscalYearById(id);
        }

        public int GetCurrentFiscalYear()
        {
            return objP.GetCurrentFiscalYear();
        }
    }
}
