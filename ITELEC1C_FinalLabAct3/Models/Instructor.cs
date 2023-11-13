using System.ComponentModel.DataAnnotations;

namespace ITELEC1C_FinalLabAct3.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int Id { get; set; }
        [Display(Name = "Unang Pangalan")]
        public string FirstName { get; set; }
        [Display(Name = "Apelyido")]
        public string LastName { get; set; }
        [Display(Name = "Status")]
        public bool IsTenured { get; set; }
        [Display(Name = "Teacher's Rank")]
        public Rank Rank { get; set; }
        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }
        [RegularExpression("[0-9]{2}-[0-9]{4}-[0-9]{4}", ErrorMessage=("Wrong format, must be 00-000-0000"))] //2 0-9 for country code 4 0-9, and 4 0-9
        public string Phone { get; set; }
    }
}
