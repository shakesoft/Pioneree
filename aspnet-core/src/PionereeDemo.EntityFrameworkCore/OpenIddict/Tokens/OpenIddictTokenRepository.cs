using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.OpenIddict.EntityFrameworkCore.Tokens;
using PionereeDemo.EntityFrameworkCore;

namespace PionereeDemo.OpenIddict.Tokens;

public class OpenIddictTokenRepository : EfCoreOpenIddictTokenRepository<PionereeDemoDbContext>
{
    public OpenIddictTokenRepository(
        IDbContextProvider<PionereeDemoDbContext> dbContextProvider,
        IUnitOfWorkManager unitOfWorkManager) : base(dbContextProvider, unitOfWorkManager)
    {
    }
}

