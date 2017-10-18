using Accounting.IDAL;
using Accounting.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIT.DataLogicLayer;

namespace Accounting.DAL
{
    public class dalAccHead : IAccHead
    {

        public DataTable GetAllAccHead()
        {
            ArrayList altParams = new ArrayList();

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetAllAccHead", altParams);
        }
        public IList<AccHead> GetAllAccHeadList()
        {
            ArrayList altParams = new ArrayList();
            List<AccHead> AccHeadList = new List<AccHead>();
          DataTable dt=  DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetAllAccHead", altParams);

          AccHeadList = (from DataRow dr in dt.Rows
                         select new AccHead()
                         {
                             AccId = Convert.ToInt32(dr["AccId"]),
                             AccCode = dr["AccCode"].ToString(),
                             AccOrder = Convert.ToInt32(dr["AccOrder"]),
                             AccType = dr["AccType"].ToString(),
                             Address = dr["Address"].ToString(),
                             BranchID = Convert.ToInt32(dr["BranchID"]),
                             Category = dr["Category"].ToString(),
                             CostCentre = Convert.ToBoolean(dr["CostCentre"]),
                             Depth = Convert.ToInt32(dr["Depth"]),
                             IsBank = Convert.ToBoolean(dr["IsBank"]),
                             Name = dr["Name"].ToString(),
                             OpenDate = Convert.ToDateTime(dr["OpenDate"]),
                             Parent = Convert.ToInt32(dr["P"]),
                             SetOrder = Convert.ToInt32(dr["SetOrder"]),
                             SubCategory = dr["SubCategory"].ToString(),
                             TopParent = Convert.ToInt32(dr["TP"]),
                             LR = dr["LR"].ToString()
                         }).ToList();


          return AccHeadList;
        }
        public int Insert(AccHead ah)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AccID", ah.AccId));
            altParams.Add(new SqlParameter("@AccCode", ah.AccCode));
            altParams.Add(new SqlParameter("@AccType", ah.AccType));
            altParams.Add(new SqlParameter("@Address", ah.Address));
            altParams.Add(new SqlParameter("@BranchID", ah.BranchID));
            altParams.Add(new SqlParameter("@Category", ah.Category));
            altParams.Add(new SqlParameter("@CostCentre", ah.CostCentre));
            altParams.Add(new SqlParameter("@IsBank", ah.IsBank));
            altParams.Add(new SqlParameter("@Name", ah.Name));
            altParams.Add(new SqlParameter("@OpenDate", ah.OpenDate));
            altParams.Add(new SqlParameter("@OpenType", ah.OpeningType));
            altParams.Add(new SqlParameter("@Parent", ah.Parent));
            altParams.Add(new SqlParameter("@SubCategory", ah.SubCategory));
            altParams.Add(new SqlParameter("@OpeningAmt", ah.OpeningAmt));
            altParams.Add(new SqlParameter("@FiscalYear", 1));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("[dbo].[Acc_Sp_insertAccHead]", altParams);
            return Convert.ToInt16(dt.Rows[0][0]);
        }
        public DataTable GetAllChildHead()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetChildHead", altParams);
        }

        public DataTable GetAllSubCatagory()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_getSubAccHead", altParams);
        }

        public Decimal GetAllCurrentBelance(int AccId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AccId", AccId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_getBalance", altParams);
            return Convert.ToDecimal(dt.Rows[0][0]);
        }

        public DataTable GetOpeningBalance(int AccId,DateTime OpeningDate)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AccId", AccId));
            altParams.Add(new SqlParameter("@OpeningDate", OpeningDate));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_GetOpeningBalance", altParams);
        }

        public int DeleteAccHead(int AccId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@AccId", AccId));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("Acc_Sp_DeleteAccHead", altParams);
            return Convert.ToInt16(dt.Rows[0][0]);
        }
        public decimal GetBelanceFor(int AccId)
        { return 0M; }

    }
}
