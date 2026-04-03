using Abp.Mapperly;
using PionereeDemo.Authorization.Roles;
using PionereeDemo.Dto;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.GraphQL.Mappers;

[Mapper]
public partial class RoleToRoleDtoMapper : MapperBase<Role, RoleDto>
{
    public override partial RoleDto Map(Role source);
    public override partial void Map(Role source, RoleDto destination);
}

[Mapper]
public partial class RoleToUserDtoRoleDtoMapper : MapperBase<Role, UserDto.RoleDto>
{
    public override partial UserDto.RoleDto Map(Role source);
    public override partial void Map(Role source, UserDto.RoleDto destination);
}
