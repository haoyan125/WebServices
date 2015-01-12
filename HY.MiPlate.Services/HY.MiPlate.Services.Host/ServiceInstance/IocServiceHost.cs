using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace HY.MiPlate.Services.Host.ServiceInstance
{
    public class IocServiceHost : ServiceHost
    {
        public IocServiceHost()
        {
        }

        public IocServiceHost(string serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
        }

        protected override void OnOpening()
        {
            //Description.Behaviors.Add(new IocServiceBehavior());
            base.OnOpening();
            this.Description.Behaviors.Add(new IocServiceBehavior());
        }
    }
}