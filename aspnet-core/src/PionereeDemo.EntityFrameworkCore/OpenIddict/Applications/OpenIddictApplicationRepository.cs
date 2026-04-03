using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.OpenIddict.EntityFrameworkCore.Applications;
using PionereeDemo.EntityFrameworkCore;

namespace PionereeDemo.OpenIddict.Applications;

public class OpenIddictApplicationRepository : EfCoreOpenIddictApplicationRepository<PionereeDemoDbContext>
{
    public OpenIddictApplicationRepository(
        IDbContextProvider<PionereeDemoDbContext> dbContextProvider,
        IUnitOfWorkManager unitOfWorkManager) : base(dbContextProvider, unitOfWorkManager)
    {
    }
}

