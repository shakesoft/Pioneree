using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PionereeDemo.MultiTenancy.HostDashboard.Dto;

namespace PionereeDemo.MultiTenancy.HostDashboard;

public interface IIncomeStatisticsService
{
    Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
        ChartDateInterval dateInterval);
}
