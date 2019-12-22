using PcColletion.InfraStructure.Model;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.InfraStructure.Repository
{
    public class CategorieRepository : BaseRepository<Categorie,BaseDbContext>, ICategorieRepository
    {
    }
}
