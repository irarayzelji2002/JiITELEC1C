﻿using ITELEC1C_LabActivity1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITELEC1C_LabActivity1.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
        {
            new Instructor()
            {
                Id= 1, FirstName = "Spenser", LastName = "Mangubat", IsTenured = true, Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-09-30")
            },
            new Instructor()
            {
                Id= 2, FirstName = "Devon", LastName = "Mangubat", IsTenured = false, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-05-15")
            },
            new Instructor()
            {
                Id= 3, FirstName = "Nicolas", LastName = "Mangubat", IsTenured = true, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2022-03-30")
            },
            new Instructor()
            {
                Id= 4, FirstName = "Emerson", LastName = "Mangubat", IsTenured = false, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-11-10")
            }
        };

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
    }
}
