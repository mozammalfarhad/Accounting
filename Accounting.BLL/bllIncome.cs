using Accounting.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.BLL
{
    public class bllIncome
    {
        dalIncome objIn = new dalIncome();
        
        public DataTable GetClientAdvanceAndOthers(string FlatorRoomId)
        {
            return objIn.GetClientAdvanceAndOthers(FlatorRoomId);
        }

        public int FlatorRoomIncome(string datastring)
        {
            return objIn.FlatorRoomIncome(datastring);
        }
    }
}
