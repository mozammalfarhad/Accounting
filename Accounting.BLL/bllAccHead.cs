using Accounting.DAL;
using Accounting.IDAL;
using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllAccHead : IAccHead
    {
         IAccHead _iAccHead = null;

        public bllAccHead()
        {
            _iAccHead = new dalAccHead();
        }
    
        dalAccHead dat = new dalAccHead();
        public DataTable GetAllAccHead()
        {
            return dat.GetAllAccHead();
        }
        public IList<AccHead> GetAllAccHeadList()
        { return dat.GetAllAccHeadList(); }
        public int Insert(AccHead ah)
        {
            return dat.Insert(ah);
        }
        
        public DataTable GetAllChildHead()
        {
            return dat.GetAllChildHead();
        }

        public DataTable GetAllSubCatagory()
        {
            return dat.GetAllSubCatagory();
        }

        public decimal GetBelanceFor(int AccId)
        {
            return dat.GetAllCurrentBelance(AccId);
        }

        public DataTable GetOpeningBalance(int AccId,DateTime OpeningDate)
        {
            return dat.GetOpeningBalance(AccId, OpeningDate);
        }
        public int DeleteAccHead(int AccId)
        {
            return dat.DeleteAccHead(AccId);
        }
    }
}
