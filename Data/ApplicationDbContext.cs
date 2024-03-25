using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chanino.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet para tus otras entidades personalizadas, como IdentityUser y Mensaje
        //public DbSet<IdentityUser> IdentityUsers { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
    }

}
