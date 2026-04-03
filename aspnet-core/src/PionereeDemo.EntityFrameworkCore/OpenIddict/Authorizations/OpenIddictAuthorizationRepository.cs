using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.OpenIddict.EntityFrameworkCore.Authorizations;
using PionereeDemo.EntityFrameworkCore;

namespace PionereeDemo.OpenIddict.Authorizations;

public class OpenIddictAuthorizationRepository : EfCoreOpenIddictAuthorizationRepository<PionereeDemoDbContext>
{
    public OpenIddictAuthorizationRepository(
        IDbContextProvider<PionereeDemoDbContext> dbContextProvider,
        IUnitOfWorkManager unitOfWorkManager) : base(dbContextProvider, unitOfWorkManager)
    {
    }
}

