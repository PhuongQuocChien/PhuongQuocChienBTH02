using System.Data;
using System.ComponentModel.DataAnnotations;
namespace PhuongQuocChienBTH02.Models{
    public class Person
    {
        [Required(ErrorMessage ="ID khong duoc bo trong")]
        public string? ID {get; set;}
        [Required(ErrorMessage ="PersonID khong duoc bo trong")]
        public string? PersonID {get; set;}
        [Required(ErrorMessage ="Personname khong duoc bo trong")]
        public string? Personname {get; set;}

        [DataType(DataType.Date)]
        public DateTime namsinh { get; set; }
    }
}