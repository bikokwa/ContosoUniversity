using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50, MinimumLength =3),RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [StringLength(50, MinimumLength = 3),RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Column("FirstName"),Display(Name ="First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date), Display(Name ="Enrollment Date")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get { return FirstMidName + " " + LastName; }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}