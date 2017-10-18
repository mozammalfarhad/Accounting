using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModel
{
   public class ExpenseTable
    {
     public Guid  Id{get;set;}	
     public int AccountingTypeId{get;set;}	
     public int BuildingId{get;set;}	
     public decimal Amount{get;set;}
     public decimal CashPay{get;set;}
     public decimal BankPay{get;set;}	
     public int BankId{get;set;}
     public string CequeNumber{get;set;}
     public DateTime  Date{get;set;}
     public string VoucherNumber { get; set; }
     public int userid { get;set; }
     public string payto { get; set; }
   
     public ExpenseTable(Guid Id, int AccountingTypeId, int BuildingId, decimal Amount, decimal CashPay, decimal BankPay, int BankId, string CequeNumber, DateTime Date, int userid, string payto, string vouchernumber)
     {
         this.Id = Id;
         this.AccountingTypeId = AccountingTypeId;
         this.BuildingId = BuildingId;
         this.Amount = Amount;
         this.CashPay = CashPay;
         this.BankId = BankId;
         this.BankPay = BankPay;
         this.CequeNumber = CequeNumber;
         this.Date = Date;
         this.userid = userid;
         this.payto = payto;
         this.VoucherNumber = vouchernumber;
     }

    }
}
