using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VallidationsDemo.Models
{
    public class CompanyDetailsModel
    {
        [Required]
        [Display(Name ="Enter Company ID:",Order =0)]
        public int CompanyID { get; set; }

        
        [Display(Order = 4,Name = "Enter No of Employees:")]
        [Required]
        [Range(2, 2000)]
        public int NoOfEmployees { get; set; }


        [Display(Name = "Enter Company Name:",Order =1)]
        [MinLength(2,ErrorMessage ="Name must be min 2 chars long")]
        public string CompanyName { get; set; }

        [Display(Name = "Enter City:",Order =2)]
        public string City { get; set; }

        
     

    }
}