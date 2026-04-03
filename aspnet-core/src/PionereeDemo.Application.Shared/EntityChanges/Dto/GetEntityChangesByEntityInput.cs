using PionereeDemo.Dto;
using System;

namespace PionereeDemo.EntityChanges.Dto;

public class GetEntityChangesByEntityInput
{
    public string EntityTypeFullName { get; set; }
    public string EntityId { get; set; }
}

