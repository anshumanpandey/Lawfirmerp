using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LawFirmERP.EntityFrameworkCore
{
    public static class LawFirmERPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LawFirmERPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LawFirmERPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
