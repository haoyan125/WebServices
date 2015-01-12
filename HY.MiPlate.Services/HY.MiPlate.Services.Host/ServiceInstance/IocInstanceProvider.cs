using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using StructureMap;

namespace HY.MiPlate.Services.Host.ServiceInstance
{
    public class IocInstanceProvider : IInstanceProvider
    {
        private readonly Type _serviceType;
        private readonly IContainer _container;
        public IocInstanceProvider(Type serviceType)
        {
            this._serviceType = serviceType;
            //this._container = CustomServiceHostFactory.Configure();
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return this._container.GetInstance(_serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }
    }
}