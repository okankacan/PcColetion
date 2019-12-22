
using PcColletion.InfraStructure.Attributes;
using PcColletion.InfraStructure.Repository.Interface;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PcColletion.InfraStructure.Repository

{
    [Serializable]
    public class PersistentEntity : IPersistentEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        [EditorType("Key")]
        public virtual int Id { get; set; }

        [DataMember]
        public virtual DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
