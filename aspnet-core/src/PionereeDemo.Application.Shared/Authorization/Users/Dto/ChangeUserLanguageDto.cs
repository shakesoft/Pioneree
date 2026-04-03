using System.ComponentModel.DataAnnotations;

namespace PionereeDemo.Authorization.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}

