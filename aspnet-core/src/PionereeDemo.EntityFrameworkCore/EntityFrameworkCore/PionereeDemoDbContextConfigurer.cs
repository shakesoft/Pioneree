using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PionereeDemo.EntityFrameworkCore;

public static class PionereeDemoDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<PionereeDemoDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<PionereeDemoDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}

