using System.ComponentModel.DataAnnotations;
namespace RainbowSchoool.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; } = null!;
        [Required]
        public int StudentClass { get; set; }
        [Required]
        public string Subject { get; set; } = null!;
        public int TeacherId { get; set; }
        public int? SubjectMark { get; set; }

    }
}
