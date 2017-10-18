using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModel
{
    public class JournalList
    {
        public int DebitHeadId { get; set; }
        public int Vid { get; set; }
        public string DebitHead { get; set; }
        public int CreaditHeadId { get; set; }
        public string CreaditHead { get; set; }
        public decimal Amount { get; set; }
        public string particular { get; set; }
        public string ChequeNo { get; set; }
        public string ChequeDate { get; set; }
        public bool isCash { get; set; }
        public string DebitAccCode { get; set; }
        public string VoucherNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public string AccCode { get; set; }
        public bool IsAgainstCheque { get; set; }
        public JournalList()
        {
            this.DebitHeadId = 0;
            this.Vid = 0;
            this.DebitHead = "";
            this.CreaditHeadId = 0;
            this.CreaditHead = "";
            this.Amount = 0;
            this.particular = "";
            this.ChequeNo = "";
            this.ChequeDate = "";
            this.isCash = true;
            this.DebitAccCode = "";
            this.VoucherNo = "";
            this.VoucherDate = DateTime.Now;
            this.AccCode = "";
            this.IsAgainstCheque = false;
        }

        public JournalList(int DebitHeadId, string DebitHead, int CreaditHeadId, string CreaditHead, decimal Amount, string particular, string ChequeNo, string ChequeDate, bool isCash,string DebitAccCode, string AccCode, bool IsAgainstCheque)
        {
            this.DebitHeadId = DebitHeadId;
            this.DebitHead = DebitHead;
            this.CreaditHead = CreaditHead;
            this.CreaditHeadId = CreaditHeadId;
            this.Amount = Amount;
            this.particular = particular;
            this.ChequeNo = ChequeNo;
            this.ChequeDate = ChequeDate;
            this.isCash = isCash;
            this.DebitAccCode = DebitAccCode;
            this.AccCode = AccCode;
            this.IsAgainstCheque = IsAgainstCheque;
        }
    }
}
