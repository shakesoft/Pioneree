using System;

namespace PionereeDemo.HealthChecks.Dto;

public class HealthCheckItemDto
{
    public string Name { get; set; }
    
    public string Status { get; set; }
    
    public string Description { get; set; }
    
    public TimeSpan Duration { get; set; }
}
