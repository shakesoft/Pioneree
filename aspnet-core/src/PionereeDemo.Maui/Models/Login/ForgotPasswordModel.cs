using System.ComponentModel.DataAnnotations;

namespace PionereeDemo.Maui.Models.Login;

public class ForgotPasswordModel
{
    [EmailAddress]
    [Required]
    public string EmailAddress { get; set; }
}