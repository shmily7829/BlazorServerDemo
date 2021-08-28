using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo.Data
{
    public class StaffInfo
    {
        [Required(ErrorMessage = "姓名不可為空白")]
        [StringLength(10, ErrorMessage = "名字不超過十個字")]
        public string Name { get; set; }

        [Required(ErrorMessage = "薪資不可為空白")]
        [Range(minimum: 1, maximum: 999999, ErrorMessage = "薪資必須介於 1~999999")]
        public decimal ExpectedSalary { get; set; }

        public DateTime UpdDtm { get; set; }

    }
}
