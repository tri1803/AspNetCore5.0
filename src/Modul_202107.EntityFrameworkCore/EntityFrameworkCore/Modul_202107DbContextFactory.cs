using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Modul_202107.Configuration;
using Modul_202107.Web;

namespace Modul_202107.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Modul_202107DbContextFactory : IDesignTimeDbContextFactory<Modul_202107DbContext>
    {
        public Modul_202107DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Modul_202107DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Modul_202107DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Modul_202107Consts.ConnectionStringName));

            return new Modul_202107DbContext(builder.Options);
        }
    }
}
