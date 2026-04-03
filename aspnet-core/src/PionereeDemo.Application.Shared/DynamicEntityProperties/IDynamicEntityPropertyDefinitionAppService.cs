using System.Collections.Generic;

namespace PionereeDemo.DynamicEntityProperties;

public interface IDynamicEntityPropertyDefinitionAppService
{
    List<string> GetAllAllowedInputTypeNames();

    List<string> GetAllEntities();
}

