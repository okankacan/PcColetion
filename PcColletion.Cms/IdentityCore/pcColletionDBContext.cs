using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PcColletion.InfraStructure;

namespace PcColletion.Cms.IdentityCore
{


    public class pcColletionDBContext : IdentityDbContext<ApplicationUser>
    {
        public pcColletionDBContext(DbContextOptions<pcColletionDBContext> options)
            : base(options)
        {

        }

    }
     
     
}
