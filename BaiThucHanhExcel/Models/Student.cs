using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanhExcel.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string FacultyID { get; set;}
        [ForeignKey("FaculytyID")]
        public Faculty Faculty { get; set;}
    }
}