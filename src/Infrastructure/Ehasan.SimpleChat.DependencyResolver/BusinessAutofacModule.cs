using Autofac;
using tp.SimpleChat.Business;
using tp.SimpleChat.Business.ServiceQuery;
using tp.SimpleChat.Core.Business_Interface;
using tp.SimpleChat.Core.Business_Interface.ServiceQuery;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace tp.SimpleChat.DependencyResolver
{
    public static class BusinessAutofacModule
    {
        public static ContainerBuilder CreateAutofacBusinessContainer(this IServiceCollection services, ContainerBuilder builder)
        {
            builder.RegisterType<IMessageService>().As<MessageService>();
            builder.RegisterType<IMessageServiceQuery>().As<MessageServiceQuery>();
            return builder;
        }
    }

    public class BusinessAutofacModule1 : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<MessageServiceQuery>().As<IMessageServiceQuery>();
        }
    }
}
