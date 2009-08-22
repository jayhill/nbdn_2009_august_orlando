using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializingFrontController : StartupCommand
    {
        readonly IDictionary<Type, Resolver> resolvers;

        public InitializingFrontController(IDictionary<Type,Resolver> resolvers)
        {
            this.resolvers = resolvers;
        }

        public void run()
        {
            var container = IOC.get();

            register<RequestCommandFactory>(() => new RequestCommandFactoryImplementation());
            RouteTable table = new RouteTableImplementation(container_instance<RequestCommandFactory>());
            register<RouteTable>(() => table);
            register<IEnumerable<RequestCommand>>(() => table);
            register<CommandRegistry>(() => new CommandRegistryImplementation(container_instance<IEnumerable<RequestCommand>>()));
            register<FrontController>(() => new FrontControllerImplementation(container_instance<CommandRegistry>()));
            register<DisplayEngine>(() => new HtmlDisplayEngine(container_instance<ViewRegistry>()));
        }

        Dependency container_instance<Dependency>()
        {
            return IOC.get().instance_of<Dependency>();
        }

        void register<Contract>(Func<object> factory)
        {
            resolvers.Add(typeof(Contract),new DelegateResolver(() => factory()));
        }
    }
}