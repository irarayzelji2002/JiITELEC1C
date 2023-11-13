using System;
using ITELEC1C_LabActivity1.Models;
namespace ITELEC1C_LabActivity3.Services
{
    public interface IMyFakeDataService
    {
        List<Student>StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
