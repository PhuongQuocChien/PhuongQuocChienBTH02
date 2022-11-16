using System.ComponentModel.DataAnnotations;

namespace BaiThucHanhExcel.Models
{
    public class Faculty
    {
        [Key]
        public string FacultyID {get; set; }
        public string FacultyName {get; set; }
    }
}