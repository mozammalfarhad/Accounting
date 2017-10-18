﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IGetFiscalYear
   {
       DataTable GetYearList();
       DataTable GetFiscalYearById(int id);
       int GetCurrentFiscalYear();
    }
}
