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

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status is required")]
        public bool IsTenured { get; set; }

        public Rank Rank { get; set; }

        [Display(Name = "Hiring Date")]
        [Required(ErrorMessage = "Hiring date is required")]
        [DataType(DataType.Date)]
        public DateTime HiringDate { get; set; }

        [RegularExpression("[0-9]{2}-[0-9]{4}-[0-9]{4}", ErrorMessage=("Wrong format, must be 00-000-0000"))] //2 0-9 for country code 4 0-9, and 4 0-9
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
    }
}
