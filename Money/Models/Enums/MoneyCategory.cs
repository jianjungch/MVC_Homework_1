using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models.Enums
{
    public enum  MoneyCategory
    {
        [Display(Name = "支出")]
        支出 = 0,

        [Display(Name = "收入")]
        收入 = 1
    }
}