using System;

namespace PcColletion.InfraStructure.Repository.Interface
{
    public interface IDbEntity<TKey>
    {
        TKey Id { get; set; }
        DateTime CreateDate { get; set; }
    }
}