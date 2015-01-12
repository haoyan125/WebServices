using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace HY.MiPlate.Services.Host.ServiceInstance
{
    public class IocServiceBehavior : IServiceBehavior
    {
        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase){}

    public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher channelDispatcher in serviceHostBase.ChannelDispatchers)
            {
                foreach (EndpointDispatcher endpointDispatcher in channelDispatcher.Endpoints)
                   {
                       Type contractType = (from endpoint in serviceHostBase.Description.Endpoints
                                            where endpoint.Contract.Name == endpointDispatcher.ContractName && endpoint.Contract.Namespace == endpointDispatcher.ContractNamespace
                                            select endpoint.Contract.ContractType).FirstOrDefault();
                       if (null == contractType)
                       {
                           continue;
                       }
                       endpointDispatcher.DispatchRuntime.InstanceProvider =
                           new IocInstanceProvider(contractType);
                   }
                }

            //foreach (var channelDispatcherBase in serviceHostBase.ChannelDispatchers)
            //{
            //    var channelDispatcher = (ChannelDispatcher) channelDispatcherBase;
            //    var cd = cdb as ChannelDispatcher;
            //    if (cd != null)
            //    {
            //        foreach (var ed in cd.Endpoints)
            //        {
            //            ed.DispatchRuntime.InstanceProvider = new StructureMapInstanceProvider(serviceDescription.ServiceType);
            //        }
            //    }
            //}
        }
    }
}