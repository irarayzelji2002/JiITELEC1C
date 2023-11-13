using ITELEC1C_FinalLabAct3.Data;
using ITELEC1C_FinalLabAct3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ITELEC1C_FinalLabAct3.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbContext;
        private DbSet<Instructor> InstructorList;

        public InstructorController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            InstructorList = _dbContext.InstructorList;
        }

        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null) //was an student found?
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
            if (!ModelState.IsValid) {
                return View();
            }
            InstructorList.Add(newInstructor);
            _dbContext.SaveChanges();
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
            _dbContext.SaveChanges();
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
                _dbContext.SaveChanges();
                return View("Index", InstructorList);
            }
            return NotFound();
        }
    }
}
