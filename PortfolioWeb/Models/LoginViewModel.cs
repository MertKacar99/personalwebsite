using System.ComponentModel.DataAnnotations;
namespace PortfolioWeb.Models
{
    public class LoginViewModel{
 [Required]
    [EmailAddress]
    [Display(Name ="Eposta")]
    public string? Email { get; set; }
    
    [Required]
    [StringLength(10, ErrorMessage = "{0} en az {2} karakter uzunlugunda olmalıdır", MinimumLength = 6)]
    [DataType(DataType.Password)] 
    [Display(Name ="Parola")]
    public string? Password { get; set; }
    }
}