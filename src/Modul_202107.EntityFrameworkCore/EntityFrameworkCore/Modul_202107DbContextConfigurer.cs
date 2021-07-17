using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Modul_202107.EntityFrameworkCore
{
    public static class Modul_202107DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Modul_202107DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Modul_202107DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
