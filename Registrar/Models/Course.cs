using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.CourseStudents = new HashSet<CourseStudent>();
      this.DepartmentCourses = new HashSet<DepartmentCourse>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public virtual ICollection<CourseStudent> CourseStudents { get;} //leaving out set for now to see if it works
    public virtual ICollection<DepartmentCourse> DepartmentCourses {get;}
  }
}