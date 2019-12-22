using PcColletion.InfraStructure.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcColletion.InfraStructure.Model
{
    [Table("Categories", Schema = "dbo")]

    public class Categorie : PersistentEntity
    {
        public int Parent { get; set; }
        public string Name { get; set; }
    }
}
 