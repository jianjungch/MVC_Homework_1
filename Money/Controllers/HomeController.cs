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
        public ActionResult Index()
        {
            ViewBag.CategoryList = CategoryGet();            
            return View();
        }
        
        [ChildActionOnly]
        public ActionResult MyMoneyList()
        {
            List<MyMoneyViewModels> MyMoneyList = MyMoney();
            return View(MyMoneyList);
        }

        private  IEnumerable<SelectListItem> CategoryGet()
        {
            var items = new List<SelectListItem>();
            items.Add(new SelectListItem() { Text = "--請選擇--", Value = "", Selected = true });
            items.Add(new SelectListItem() { Text = "支出", Value = "pay", Selected = false });
            items.Add(new SelectListItem() { Text = "收入", Value = "income", Selected = false });
            return items;
        }

        private  List<MyMoneyViewModels> MyMoney()
        {
            //2016 / 4 / 14 上午 04:50:47

            return new List<MyMoneyViewModels> {
                new MyMoneyViewModels { category = "支出", date =  new DateTime(2016,4,8,9,50,47),money=123 },
                new MyMoneyViewModels { category = "支出", date = new DateTime(2016, 4, 10, 06, 50, 47), money = 123 },
                new MyMoneyViewModels { category = "收入", date = new DateTime(2016, 4, 12, 04, 50, 47), money = 810 },
                new MyMoneyViewModels { category = "支出", date = new DateTime(2016, 4, 13, 09, 50, 47), money = 2210 } };
        }

        
    }
}