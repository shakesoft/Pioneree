using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.OpenIddict.EntityFrameworkCore.Scopes;
using PionereeDemo.EntityFrameworkCore;

namespace PionereeDemo.OpenIddict.Scopes;

public class OpenIddictScopeRepository : EfCoreOpenIddictScopeRepository<PionereeDemoDbContext>
{
    public OpenIddictScopeRepository(
        IDbContextProvider<PionereeDemoDbContext> dbContextProvider,
        IUnitOfWorkManager unitOfWorkManager) : base(dbContextProvider, unitOfWorkManager)
    {
    }
}

