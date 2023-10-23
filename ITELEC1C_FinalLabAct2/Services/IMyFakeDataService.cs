using System;
using ITELEC1C_FinalLabAct2.Models;

namespace ITELEC1C_FinalLabAct2.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
