using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.IDAL
{
   public interface IAccHead
    {
        int Insert(AccHead accHead);
        int DeleteAccHead(int AccId);
        DataTable GetAllAccHead();
        IList<AccHead> GetAllAccHeadList();
        DataTable GetAllChildHead();
        DataTable GetAllSubCatagory();
        DataTable GetOpeningBalance(int AccId, DateTime OpeningDate);
        decimal GetBelanceFor(int AccId);
        
    }
}
