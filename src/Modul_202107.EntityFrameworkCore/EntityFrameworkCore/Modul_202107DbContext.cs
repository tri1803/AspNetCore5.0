using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Modul_202107.Authorization.Roles;
using Modul_202107.Authorization.Users;
using Modul_202107.MultiTenancy;

namespace Modul_202107.EntityFrameworkCore
{
    public class Modul_202107DbContext : AbpZeroDbContext<Tenant, Role, User, Modul_202107DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Modul_202107DbContext(DbContextOptions<Modul_202107DbContext> options)
            : base(options)
        {
        }
    }
}
