using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class MyInfo
    {
        
        public int Id { get; set; }
        [Display(Name = "الاسم")]
        public string Name { get; set; }
        [Display(Name = "التخصص")]
        public string Mastar { get; set; }
        [Display(Name = "رقم الجوال")]
        public int Phone { get; set; }
        [Display(Name = "البريد الالكتروني")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "المهارات")]
        public string Skills { get; set; }
        [Display(Name = "الوصف")]
        public string Discraption { get; set; }
        [Display(Name = "الصوره")]
        public string Image { get; set; }
    }
}