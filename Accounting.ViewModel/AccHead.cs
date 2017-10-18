using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModel
{
    public class AccHead
    {
        public int AccId{get;set;}
        
        public string AccCode{get;set;}
        public int Parent{get;set;}
        public int TopParent{get;set;}
        public string Name{get;set;}

        public string Category{get;set;}
        public string SubCategory{get;set;}
        public int Depth{get;set;}
        public DateTime OpenDate{get;set;}
        public string Address{get;set;}

        public int AccOrder{get;set;}
        public int BranchID{get;set;}
        public decimal OpeningAmt { get; set; }
        public string OpeningType { get; set; }
        public string LR { get; set; }
        public string AccType{get;set;}
        public bool CostCentre{get;set;}
        public int SetOrder { get; set; }
        public bool IsBank { get; set; }

    }
}
