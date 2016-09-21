﻿using MassActivation;
using Microsoft.Extensions.DependencyInjection;
using ServiceBridge.AspNetCore;
using ServiceBridge.Autofac.Activation;

[assembly:AssemblyActivator(typeof(ServiceBridge.Samples.AspNetCore.Activator))]
namespace ServiceBridge.Samples.AspNetCore
{
    public class Activator
    {
        public Activator(IActivatingEnvironment environment)
        {
            environment.UseAutofac();
        }

        public void Configuration(IServiceContainer container, IServiceCollection services)
        {
            container.Register<ICacheRepository, CacheRepository>(ServiceLifetime.Singleton);
            container.RegisterServices(services);
        }
    }
}
