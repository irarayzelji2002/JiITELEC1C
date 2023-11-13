using ITELEC1C_LabActivity1.Models;
using ITELEC1C_LabActivity3.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELEC1C_LabActivity1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        private List<Student> StudentList;
        
        public StudentController(IMyFakeDataService fakeData)
        { 
            _fakeData = fakeData;
            StudentList = _fakeData.StudentList;
        }

        public IActionResult Index()
        {
            return View(_fakeData.StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Student? student =StudentList.FirstOrDefault(st => st.Id == id);

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
            }
            return RedirectToAction("Index"); //View("Index", StudentList);
        }
    }
}
