﻿
using PcColletion.InfraStructure.Repository.Interface;
using System;
using System.Threading;

namespace PcColletion.InfraStructure.Repository
{
    public class ServiceProviderAccessor : IServiceProviderAccessor
    {
        private static AsyncLocal<ServiceProviderHolder> _serviceProviderCurrent = new AsyncLocal<ServiceProviderHolder>();
        public IServiceProvider ServiceProvider
        {
            get
            {
                return _serviceProviderCurrent.Value?.ServiceProvider;
            }
            set
            {
                var holder = _serviceProviderCurrent.Value;
                if (holder != null)
                {
                    // Clear current HttpContext trapped in the AsyncLocals, as its done.
                    holder.ServiceProvider = null;
                }

                if (value != null)
                {
                    // Use an object indirection to hold the HttpContext in the AsyncLocal,
                    // so it can be cleared in all ExecutionContexts when its cleared.
                    _serviceProviderCurrent.Value = new ServiceProviderHolder { ServiceProvider = value };
                }
            }
        }

        private class ServiceProviderHolder
        {
            public IServiceProvider ServiceProvider;
        }
    }
}
