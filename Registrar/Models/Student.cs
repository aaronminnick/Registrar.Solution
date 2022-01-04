using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.CourseStudents = new HashSet<CourseStudent>();
      this.DepartmentStudents = new HashSet<DepartmentStudent>();
    }

    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public virtual ICollection<CourseStudent> CourseStudents { get; }
    public virtual ICollection<DepartmentStudent> DepartmentStudents { get; }
  }
}