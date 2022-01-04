using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.DepartmentCourses = new HashSet<DepartmentCourse>();
      this.DepartmentStudents = new HashSet<DepartmentStudent>();
    }

    public int DepartmentId {get; set;}
    public string Name {get; set;}
    public string DepartmentCode {get; set;}

    public virtual ICollection<DepartmentCourse> DepartmentCourses {get;}
    public virtual ICollection<DepartmentStudent> DepartmentStudents {get;}
  }
}