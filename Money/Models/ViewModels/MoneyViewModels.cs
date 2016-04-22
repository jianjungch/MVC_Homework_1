using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models.ViewModels
{
    public class MoneyViewModels
    {
        [Display(Name = "類別")]
        public string category { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        [Display(Name ="金額")]
        public  int money { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "日期")]
        public DateTime  date { get; set; }

        [Display(Name = "備註")]
        public string description { get; set; }
    }
}