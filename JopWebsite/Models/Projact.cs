using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Projact
    {
        public int Id { get; set; }
        [Display(Name = "اسم المشروع")]
        public string ProjactTitle { get; set; }
        [Display(Name = "صورة المشرع")]
        public string ProjactImage { get; set; }
        [Display(Name = "الرابط ")]
        public string ProjactUrl { get; set; }
                [Display(Name = "الوصف ")]
        public string ProjactDiscraption { get; set; }
    }
}