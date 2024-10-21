using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }


        [Required(ErrorMessage = "Course title is required.")]
        public string Title { get; set; }


        [Range(1, 5, ErrorMessage = "Credits must be between 1 and 5.")]
        public int Credits { get; set; }

    }
}
