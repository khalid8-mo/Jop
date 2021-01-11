using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JopWebsite.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [DisplayName("اسم الطالب")]
        [Required(ErrorMessage ="الرجاء إدخال اسم الطالب")]
        public string StdudentName { get; set; }
        [DisplayName("الرقم الجامعي")]
        [Required(ErrorMessage = "الرجاء إدخال الرقم الجامعي")]
        public string StudentNamber { get; set; }
        [DisplayName("رقم الهاتف")]
        [Required(ErrorMessage = "الرجاء إدخال رقم الهاتف")]

        public string StudentPhone { get; set; }
        [DisplayName("البريد الالكتروني")]
        [Required(ErrorMessage = "الرجاء إدخال البريد الالكتروني")]
        [EmailAddress]
        public string StudentEmail { get; set; }
        [DisplayName("عنوان الطالب")]
        public string StudentAddress { get; set; }
        [DisplayName(" القسم")]
        [Required(ErrorMessage = "الرجاء إدخال اسم الطالب")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}