using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModel
{
    public  class Income
    {

        public int PayId { get; set; }
        public string ClientRoomId { get; set; }
        public string BuildingName { get; set; }
        public int BuildingId { get;set; }
        public int FloorId { get; set; }
        public string FlatorRoomId { get; set; }
        public string FlatName { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal PayAmount { get; set; }
        public decimal DueAmount { get; set; }
        public DateTime PayDate { get; set; }
        public string StPayDate { get; set; }
        public decimal CashAmount { get; set; }
        public decimal BankAmount { get; set; }
        public string ChequeNo { get; set; }
        public DateTime ChequeDate { get; set; }
        public int BankAccount { get; set; }
        public string voucherNo { get; set; }
        public int CollectionType { get; set; }
        public string CollectionName { get; set; }
        public int VId { get; set; }
        public Income()
        {
            this.PayId = 0;
            this.ClientRoomId = "";
            this.BuildingName = "";
            this.BuildingId = 0;
            this.FloorId = 0;
            this.FlatorRoomId = "";
            this.FlatName = "";
            this.ClientId = "";
            this.ClientName = "";
            this.PayAmount = 0;
            this.DueAmount = 0;
            this.PayDate = DateTime.Now;
            this.StPayDate = "";
            this.CashAmount = 0;
            this.BankAmount = 0;
            this.ChequeNo = "";
            this.ChequeDate = DateTime.Now;
            this.BankAccount = 0;
            this.voucherNo = "";
            this.CollectionType = 0;
            this.CollectionName = "";
            this.VId = 0;
        }

        public Income(int PayId, string BuildingName, int BuildingId,int FloorId,string FlatorRoomId, string FlatName, string ClientId, string ClientName, decimal PayAmount, decimal DueAmount,
            DateTime PayDate, string StPayDate, string StPayMonth, decimal CashAmount, decimal BankAmount, string ChequeNo, DateTime ChequeDate,
            int BankAccount, string voucherNo, string Particulars, int CollectionType, string CollectionName, int VId)
        {
            this.PayId = PayId;
            this.BuildingName = BuildingName;
            this.BuildingId = BuildingId;
            this.FloorId = FloorId;
            this.FlatorRoomId = FlatorRoomId;
            this.FlatName = FlatName;
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.PayAmount = PayAmount;
            this.DueAmount = DueAmount;
            this.PayDate = PayDate;
            this.StPayDate = StPayDate;
            this.CashAmount = CashAmount;
            this.BankAmount = BankAmount;
            this.ChequeNo = ChequeNo;
            this.ChequeDate = ChequeDate;
            this.BankAccount = BankAccount;
            this.voucherNo = voucherNo;
            this.CollectionType=CollectionType;
            this.CollectionName = CollectionName;
            this.VId = VId;
        }
    }
}
