using PcColletion.InfraStructure.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcColletion.InfraStructure.Model
{
    [Table("Items", Schema = "dbo")]

    public class Item : PersistentEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
