using Accounting.BLL;
using Accounting.IDAL;
using Accounting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZenAccounting.Controllers
{
    public class AccHeadController : Controller
    {
        IAccHead _iAccHead = null;
        //
        public AccHeadController()
        {
            _iAccHead = new Accounting.BLL.bllAccHead();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Lists()
        {
            return View();
        }
        public JsonResult AccHeadList()
        {
            List<AccHead> lst = _iAccHead.GetAllAccHeadList().ToList();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Create(AccHead accHead)
        {
            AccHead objAccHead = new AccHead();
            if (_iAccHead.Insert(accHead) > 0)
            {
                List<AccHead> lst  = _iAccHead.GetAllAccHeadList().ToList();
                objAccHead = lst.Last();

            }

            return Json(objAccHead, JsonRequestBehavior.AllowGet);

        } 
        public PartialViewResult Create()
        {
            return PartialView("Create");
        }
        [HttpGet]
        public PartialViewResult Edit(int ID)
        {

            AccHead accHeadlst = new AccHead();

           // accHeadlst = _iAccHead.GetBankById(ID);
            return PartialView("Edit", accHeadlst);
        }
        [HttpPost]
        public JsonResult Edit(AccHead accHead)
        {
            AccHead objAccHead = new AccHead();
            if (_iAccHead.Insert(accHead) > 0)
            {
                List<AccHead> lst = _iAccHead.GetAllAccHeadList().ToList();
                objAccHead = lst.Last();

            }

            return Json(objAccHead, JsonRequestBehavior.AllowGet);

        }
        //[HttpGet]
        //public ActionResult Details(int ID = 0)
        //{
        //    //Bank bank = GetBankById(id);

        //    //if (bank == null)
        //    //{
        //    //    return HttpNotFound();
        //    //}
        //    //return View(bank);
        //    ViewModels.Bank banklst = new ViewModels.Bank();
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:3362/");
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    HttpResponseMessage response = client.GetAsync("api/BankSVC/GetBankById?ID=" + ID).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        banklst = response.Content.ReadAsAsync<ViewModels.Bank>().Result;

        //    }
        //    return View("Details", banklst);
        //}
        public JsonResult Delete(int ID)
        {
            List<AccHead> lst = new List<AccHead>();
            if (_iAccHead.DeleteAccHead(ID) > 0)
            {
                 lst = _iAccHead.GetAllAccHeadList().ToList();
            }

            return Json(lst, JsonRequestBehavior.AllowGet);

        }
        [HttpPost]
        // [AuthorizeRoles("Admin", "User", "VokalatnamaUser", "BailBondUser")]
        public ActionResult Insert(AccHead accHead)
        {
            try
            {
                int result = _iAccHead.Insert(accHead);
                if (result == 1)
                {
                  
                    return RedirectToAction("AccHead");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            catch (Exception ex)
            {
                
            }
            return Json(new { success = true, oldval = _iAccHead.GetAllAccHead() },
              JsonRequestBehavior.AllowGet);
        }
    }
}