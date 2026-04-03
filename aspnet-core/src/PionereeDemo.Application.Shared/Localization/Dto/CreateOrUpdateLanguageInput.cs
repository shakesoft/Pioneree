using System.ComponentModel.DataAnnotations;

namespace PionereeDemo.Localization.Dto;

public class CreateOrUpdateLanguageInput
{
    [Required]
    public ApplicationLanguageEditDto Language { get; set; }
}

