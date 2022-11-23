using System.ComponentModel.DataAnnotations;
namespace BTHChon.Models
{
    public class Faculty
    {
        [Key]
        public string? FacultyID {get; set;}
        public string? FacultyName {get; set;}
    }
}
