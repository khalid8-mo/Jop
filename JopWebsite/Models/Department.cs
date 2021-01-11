using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [DisplayName("القسم")]
        [Required]
        public string DepartmentName { get; set; }
        [DisplayName("مدير القسم")]
        [Required]
        public string DepartmentMangment { get; set; }
        public virtual ICollection<Student>Students { get; set; }
    }
}