using System;

namespace PcColletion.InfraStructure.Repository.Interface
{
    public interface IServiceProviderAccessor
    {
        IServiceProvider ServiceProvider { get; set; }
    }
}
