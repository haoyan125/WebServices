using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;
using HY.MiPlate.Services.Host.ServiceInstance;
using StructureMap;

namespace HY.MiPlate.Services.Host
{
    public class IocServiceHostFactory : ServiceHostFactoryBase
    {
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            return new IocServiceHost(constructorString, baseAddresses);
        }

        public static IContainer Configure()
        {
            return new Container(x => x.Scan(scan =>
            {
               // scan.Assembly("HY.MiPlate.Services.Repository");
                scan.Assembly("HY.MiPlate.Services.Domain");
                scan.Assembly("HY.MiPlate.Services.Service");
                scan.WithDefaultConventions();
            }));
        }
    }
}