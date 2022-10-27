using System.ComponentModel.DataAnnotations;

namespace PhuongQuocChienBTH02.Models;

public class ErrorViewModel
{
    [Required(ErrorMessage ="RequestId khong duoc bo trong")]
    public string? RequestId { get; set; }
    [Required(ErrorMessage ="ShowRequestId khong duoc bo trong")]
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
