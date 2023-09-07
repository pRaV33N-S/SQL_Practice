using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolStats.Models
{
    public class StudentStatistics
    {
        public int StudentCount { get; set; }
        public Student MaxMarkStudent { get; set; }
        public Student MinMarkStudent { get; set; }
        public List<Student> StudentsWithLessThan50Marks { get; set; }
        public double AverageMark { get; set; }
    }
}