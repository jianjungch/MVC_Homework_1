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


        [HttpPost]        
        public ActionResult Add(AccountBookViewModels para)        
        {
            if (!ModelState.IsValid)
                return View("Index");
                        
            AccountBook AddData = new AccountBook
            {
                Id = Guid.NewGuid(),
                Categoryyy = (int)para.category,
                Dateee = para.date,
                Amounttt = para.money,
                Remarkkk = para.description
            };

            db.AccountBook.Add(AddData);
            db.SaveChanges();
            return RedirectToAction("index");
        }


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
                .Select(d => new AccountBookViewModels { category = (MoneyCategory)d.Categoryyy, money = d.Amounttt, date = d.Dateee, description = d.Remarkkk }).OrderByDescending(m => m.date);
            return View(list);
        }
    }
}
