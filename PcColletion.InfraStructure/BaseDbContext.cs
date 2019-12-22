 
using PcColletion.InfraStructure.Model;
using Microsoft.EntityFrameworkCore;


namespace PcColletion.InfraStructure
{
    public class BaseDbContext : DbContext
    {


        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        public BaseDbContext(DbContextOptions<BaseDbContext> options)
            : base(options)
        {
        }



    }
}
