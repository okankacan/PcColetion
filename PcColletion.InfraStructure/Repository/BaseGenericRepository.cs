using Microsoft.EntityFrameworkCore;
 
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.InfraStructure.Repository
{


    public class BaseGenericRepository<TModel, TKey, CustomDbContext> : BaseGenericBaseRepository<TModel, TKey, CustomDbContext>
   where TModel : class, IDbEntity<TKey>
   where CustomDbContext : DbContext
    {
       
        public BaseGenericRepository() : base(
        ServiceGetter.GetService<CustomDbContext>(),null)
  
        { }
    }
}
