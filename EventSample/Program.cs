using Autofac;
using EventSample.Application;
using EventSample.Domain;
using EventSample.Events;
using EventSample.Handlers;
using EventSample.Infrastructure;
using EventSample.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            DomainEvents.Container = container;
            Console.WriteLine("Starting application.");
            using (var scope = container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IUserService>();
                service.UserCreate("deneme@deneme.com", "12345");
            }
            Console.ReadLine();
        }
    }

    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UserCreatedHandler>().As<IHandle<UserCreated>>();
            builder.RegisterType<UserCreated>().As<IDomainEvent>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<Repository<User>>().As<IRepository<User>>();
            // add other registrations here...
            return builder.Build();
        }
    }
}
