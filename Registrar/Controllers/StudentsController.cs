using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Linq;

namespace Registar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;

    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index(){
      return View(_db.Students.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisStudent = _db.Students
          .Include(student => student.CourseStudents)
          .ThenInclude(join => join.Course)
          .FirstOrDefault(student => student.StudentId == id);   
        return View(thisStudent);
    }

    public ActionResult AddCourse(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult AddCourse(Student student, int CourseId)
    {
      if (CourseId != 0)
      {
        _db.CourseStudents.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = student.StudentId});
    }

    public ActionResult AddDepartment(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "Name");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult AddDepartment(Student student, int DepartmentId)
    {
      if (DepartmentId != 0)
      {
        _db.DepartmentStudents.Add(new DepartmentStudent() { DepartmentId = DepartmentId, StudentId = student.StudentId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = student.StudentId});
    }

    public ActionResult Delete(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCourse(int joinId, int studentId)
    {
      var joinEntry = _db.CourseStudents.FirstOrDefault(joinEntry => joinEntry.CourseStudentId == joinId);
      _db.CourseStudents.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = studentId});
    }

    [HttpPost]
    public ActionResult DeleteDepartment(int joinId, int studentId)
    {
      var joinEntry = _db.DepartmentStudents.FirstOrDefault(joinEntry => joinEntry.DepartmentStudentId == joinId);
      _db.DepartmentStudents.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = studentId });
    }
    public ActionResult Edit(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student student)
    {
      _db.Entry(student).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = student.StudentId});
    }
  }
}