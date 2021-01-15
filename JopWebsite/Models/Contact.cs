using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Contact
    {
        [Required]
        [Display(Name="الاسم")]
        public string Name { get; set; }
        [Required]
        [Display(Name="الموضوع")]
        public string Subject { get; set; }
        [Required]
        [Display(Name = "الرساله")]

        public string Massege { get; set; }
        [Required]
        [Display(Name = "البريد الالكتروني")]

        public string Email { get; set; }
    }
}