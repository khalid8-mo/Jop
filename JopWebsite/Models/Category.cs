using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="نوع الوظيفه")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name ="وصف النوع")]
        public string CategoryDescription { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="تاريخ الوظيفه")]
        public DateTime CategoryDate { get; set; }
        public virtual ICollection<Jop> Jobs { get; set; }
    }
}