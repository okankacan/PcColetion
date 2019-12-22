using Microsoft.EntityFrameworkCore;

namespace PcColletion.InfraStructure.Repository.Interface
{
    public interface IBaseRepository<TModel, CustomDbContext> : IBaseGenericRepository<TModel, int, CustomDbContext>
            where TModel : class, IDbEntity<int>
            where CustomDbContext : DbContext
    {

    }
}
