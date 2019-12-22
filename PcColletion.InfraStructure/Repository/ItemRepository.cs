using PcColletion.InfraStructure.Model;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.InfraStructure.Repository
{
    public class ItemRepository : BaseRepository<Item, BaseDbContext>, IItemRepository
    {
    }
}
