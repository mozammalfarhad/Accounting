using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllShowVoucher
    {
        dalShowVoucher objSV = new dalShowVoucher();
        public DataTable GetAllVoucher(DateTime DateFrom, DateTime DateTo,int VType)
        {
            return objSV.GetAllVoucher(DateFrom, DateTo, VType);
        }

        public DataTable GetVoucherDetails(int VId)
        {
            return objSV.GetVoucherDetails(VId);
        }

        public DataTable GetListForVoucherUpdate(int VId, int VType)
        {
            return objSV.GetListForVoucherUpdate(VId, VType);
        }
    }
}
