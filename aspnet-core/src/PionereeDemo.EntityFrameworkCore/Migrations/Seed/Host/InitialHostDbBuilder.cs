using PionereeDemo.EntityFrameworkCore;

namespace PionereeDemo.Migrations.Seed.Host;

public class InitialHostDbBuilder
{
    private readonly PionereeDemoDbContext _context;

    public InitialHostDbBuilder(PionereeDemoDbContext context)
    {
        _context = context;
    }

    public void Create()
    {
        new DefaultEditionCreator(_context).Create();
        new DefaultLanguagesCreator(_context).Create();
        new HostRoleAndUserCreator(_context).Create();
        new DefaultSettingsCreator(_context).Create();

        _context.SaveChanges();
    }
}

