using Abp.Mapperly;
using PionereeDemo.Authorization.Users;
using PionereeDemo.Dto;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.GraphQL.Mappers;

[Mapper]
public partial class UserToUserDtoMapper : MapperBase<User, UserDto>
{
    [MapperIgnoreTarget(nameof(UserDto.Roles))]
    [MapperIgnoreTarget(nameof(UserDto.OrganizationUnits))]
    public override partial UserDto Map(User source);

    [MapperIgnoreTarget(nameof(UserDto.Roles))]
    [MapperIgnoreTarget(nameof(UserDto.OrganizationUnits))]
    public override partial void Map(User source, UserDto destination);
}
