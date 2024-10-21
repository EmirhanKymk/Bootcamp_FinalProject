using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int Credits { get; set; }
    }
}
