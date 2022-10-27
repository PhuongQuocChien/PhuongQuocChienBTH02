using System.ComponentModel.DataAnnotations;
using System.Data;
namespace PhuongQuocChienBTH02.Models{
    public class Employee
    {
        [Required(ErrorMessage ="ID khong duoc bo trong")]
        public string? ID {get; set;}
        [Required(ErrorMessage ="MaNV khong duoc bo trong")]
        public string? MaNV {get; set;}
        [MinLength(3)]// ba ki tu
        public string? phongban {get; set;}
        [Required(ErrorMessage ="Ten khong duoc bo trong")]
        public string? tên {get; set;}
        
    }
}