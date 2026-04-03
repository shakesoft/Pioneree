using PionereeDemo.Dto;

namespace PionereeDemo.Organizations.Dto;

public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
{
    public long OrganizationUnitId { get; set; }
}

