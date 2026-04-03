using System.Collections.Generic;

namespace PionereeDemo.MultiTenancy.HostDashboard.Dto;

public class GetEditionTenantStatisticsOutput
{
    public GetEditionTenantStatisticsOutput(List<TenantEdition> editionStatistics)
    {
        EditionStatistics = editionStatistics;
    }

    public List<TenantEdition> EditionStatistics { get; set; }
}

