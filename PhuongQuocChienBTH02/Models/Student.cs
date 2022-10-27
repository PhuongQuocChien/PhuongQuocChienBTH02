using System.ComponentModel.DataAnnotations;
using System.Data;
namespace PhuongQuocChienBTH02.Models{
    public class Student
    {
        [Required(ErrorMessage ="ID khong duoc bo trong")]
        public string? ID {get; set;}
        [Required(ErrorMessage ="StudentID khong duoc bo trong")]
        public string? StudentID {get; set;}
        [Required(ErrorMessage ="Studentname khong duoc bo trong")]
        public string? Studentname {get; set;}
    }
}