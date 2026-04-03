using Abp.Application.Services.Dto;

namespace PionereeDemo.Dto;

public class PagedSortedAndFilteredInputDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}

