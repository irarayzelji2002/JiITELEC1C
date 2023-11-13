using ITELEC1C_FinalLabAct2.Data;
using ITELEC1C_FinalLabAct2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITELEC1C_FinalLabAct2.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _dbContext;
        private DbSet<Student> StudentList;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            StudentList = _dbContext.StudentList;
        }

        public IActionResult Index()
        {
            return View(StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            StudentList.Add(newStudent);
            _dbContext.SaveChanges();
            return RedirectToAction("Index"); //View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditStudent(Student studentChange)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChange.Id);
            if (student != null)
            {
                student.FirstName = studentChange.FirstName;
                student.LastName = studentChange.LastName;
                student.Course = studentChange.Course;
                student.AdmissionDate = studentChange.AdmissionDate;
                student.GPA = studentChange.GPA;
                student.Email = studentChange.Email;
            }
            _dbContext.SaveChanges();
            return RedirectToAction("Index"); //View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)//was an student found?
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteStudent(Student deleteStudent)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == deleteStudent.Id);
            if (student != null)
            {
                StudentList.Remove(student);
                _dbContext.SaveChanges();
                return RedirectToAction("Index"); //View("Index", StudentList);
            }
            return NotFound();
        }
    }
}
