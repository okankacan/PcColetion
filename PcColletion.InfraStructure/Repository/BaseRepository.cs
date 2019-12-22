using Microsoft.EntityFrameworkCore;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.InfraStructure.Repository
{


    public class BaseRepository<TModel, CustomDbContext> : BaseGenericRepository<TModel, int, CustomDbContext>, IBaseRepository<TModel, CustomDbContext>
    where TModel : class, IPersistentEntity
    where CustomDbContext : DbContext
    {
    }
}

 