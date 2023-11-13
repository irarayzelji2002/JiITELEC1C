using ITELEC1C_LabActivity1.Models;
using ITELEC1C_LabActivity3.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITELEC1C_LabActivity1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _fakeData;
        private List<Instructor> InstructorList;

        public InstructorController(IMyFakeDataService fakeData)
        {
            _fakeData = fakeData;
            InstructorList = _fakeData.InstructorList;
        }

        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }
    
        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult EditInstructor(Instructor instructorChange)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChange.Id);
            if (instructor != null)
            {
                instructor.FirstName = instructorChange.FirstName;
                instructor.LastName = instructorChange.LastName;
                instructor.IsTenured = instructorChange.IsTenured;
                instructor.Rank = instructorChange.Rank;
                instructor.HiringDate = instructorChange.HiringDate;
            }
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Instructor deleteStudent)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == deleteStudent.Id);
            if (instructor != null)
            {
                InstructorList.Remove(instructor);
            }
            return View("Index", InstructorList);
        }
    }
}
