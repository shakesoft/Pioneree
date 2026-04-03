using Abp.Mapperly;
using PionereeDemo.Friendships;
using PionereeDemo.Friendships.Cache;
using Riok.Mapperly.Abstractions;

namespace PionereeDemo.Mappers;

[Mapper]
public partial class FriendshipToFriendCacheItemMapper : MapperBase<Friendship, FriendCacheItem>
{
    public override partial FriendCacheItem Map(Friendship source);
    public override partial void Map(Friendship source, FriendCacheItem destination);
}
