using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Jop
    {
        public int Id { get; set; }
     
        [Display(Name ="اسم الوظيفه")]
        public string JopTitle { get; set; }
        [Display(Name ="وصف الوظيفه")]

        public string JopContent { get; set; }
        [Display(Name ="صورة الوظيفه")]
        
        public string JopImage { get; set; }
        [Display(Name ="نوع الوظيفه")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}