using System.Data;
using System.ComponentModel.DataAnnotations;

namespace PhuongQuocChienBTH02.Models{
    public class Customer
    {
        [Required(ErrorMessage ="khong duoc bo trong")]
        public string? ID {get; set;}
        [Required(ErrorMessage ="MaKH khong duoc bo trong")]
        public string? MaKH {get; set;}
        [Required(ErrorMessage ="SDT khong duoc bo trong")]// DIEU KIEN
        public int? SĐT {get; set;}
        
    }
}