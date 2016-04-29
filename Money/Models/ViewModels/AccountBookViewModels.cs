using Money.Models.CustAttributes;
using Money.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models.ViewModels
{
    public class AccountBookViewModels
    {
        [Display(Name = "類別")]
        [Required(ErrorMessage = "此為必填欄位")]
        [Range(0, int.MaxValue, ErrorMessage = "請選擇類別")]
        public MoneyCategory category { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        [Display(Name ="金額")]
        [Required(ErrorMessage = "此為必填欄位")]        
        [Range(0, int.MaxValue, ErrorMessage = "{0}需為正整數")]
        public  int money { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "日期")]
        [Required(ErrorMessage = "此為必填欄位")]          
        [DateValidation()]
        public DateTime  date { get; set; }

        [Display(Name = "備註")]
        [Required(ErrorMessage = "此為必填欄位")]
        [MaxLength(100, ErrorMessage = "此欄位最多輸入 [{1}] 個字元")]
        public string description { get; set; }
    }
}