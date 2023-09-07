using System.ComponentModel.DataAnnotations;

namespace RainbowSchoool.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; } = null!;
    }
}
