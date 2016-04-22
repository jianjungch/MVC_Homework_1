using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Money.Models;
using Money.Models.ViewModels;

namespace Money.Controllers
{
    public class HomeController : Controller
    {

        private SkillTreeHomeworkEntities1 db = new SkillTreeHomeworkEntities1();

        public ActionResult Index()
        {
            ViewBag.CategoryList = CategoryGet();            
            return View();
        }
        
        [ChildActionOnly]
        public ActionResult MyMoneyList()
        {
            List<MoneyViewModels> MyMoneyList = MyMoney();
            return View(MyMoneyList);
        }

        private  IEnumerable<SelectListItem> CategoryGet()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "--請選擇--", Value ="0", Selected = true });
            items.Add(new SelectListItem() { Text = "支出", Value = "1", Selected = false });
            items.Add(new SelectListItem() { Text = "收入", Value = "2", Selected = false });
            return items;
        }

        private  List<MoneyViewModels> MyMoney()
        {
            //2016 / 4 / 14 上午 04:50:47

            return new List<MoneyViewModels> {
                new MoneyViewModels { category = "支出", date =  new DateTime(2016,4,8,9,50,47),money=123 },
                new MoneyViewModels { category = "收入", date = new DateTime(2016, 4, 10, 06, 50, 47), money = 123 },
                new MoneyViewModels { category = "收入", date = new DateTime(2016, 4, 12, 04, 50, 47), money = 810 },
                new MoneyViewModels { category = "支出", date = new DateTime(2016, 4, 13, 09, 50, 47), money = 2210 } };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}