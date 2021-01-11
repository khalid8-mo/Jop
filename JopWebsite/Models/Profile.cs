using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Display(Name =" الاسم")]
        public string ProTitle { get; set; }
        [Display(Name = "الوصف")]
        public string ProDiscraption { get; set; }
        [Display(Name = "صوره")]
        public string ProImage { get; set; }
        [Display(Name = "تاريخ النشر")]
        public DateTime ProDate { get; set; }

        
    }
}