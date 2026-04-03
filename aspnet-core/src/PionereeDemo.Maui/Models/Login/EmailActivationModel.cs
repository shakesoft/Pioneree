using System.ComponentModel.DataAnnotations;

namespace PionereeDemo.Maui.Models.Login;

public class EmailActivationModel
{
    [Required]
    [EmailAddress]
    public string EmailAddress { get; set; }
}