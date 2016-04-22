using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Money.Models;
using Money.Models.ViewModels;
using Money.Models.Enums;

namespace Money.Controllers
{
    public class AccountBooksController : Controller
    {
        private SkillTreeHomeworkEntities1 db = new SkillTreeHomeworkEntities1();

        // GET: AccountBooks
        public ActionResult Index()
        {
           
            return View();            
        }

      
        //private IEnumerable<SelectListItem> CategoryGet()
        //{
        //    var items = new List<SelectListItem>();
        //    items.Add(new SelectListItem() { Text = "--請選擇--", Value = "", Selected = true });
        //    items.Add(new SelectListItem() { Text = "支出", Value = "1", Selected = false });
        //    items.Add(new SelectListItem() { Text = "收入", Value = "2", Selected = false });
        //    return items;
        //}
      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [ChildActionOnly]
        public ActionResult AccountBookList()
        {            
            var list = db.AccountBook.Take(10)
                .Select(d => new AccountBookViewModels { category = (MoneyCategory)d.Categoryyy, money = d.Amounttt, date = d.Dateee, description = d.Remarkkk });
            return View(list);
        }
    }
}
