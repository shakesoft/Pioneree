using Abp.Mapperly;
using PionereeDemo.Authorization.Delegation;
using PionereeDemo.Authorization.Users.Delegation.Dto;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.Mappers;

[Mapper]
public partial class CreateUserDelegationDtoToUserDelegationMapper : MapperBase<CreateUserDelegationDto, UserDelegation>
{
    public override partial UserDelegation Map(CreateUserDelegationDto source);
    public override partial void Map(CreateUserDelegationDto source, UserDelegation destination);
}
