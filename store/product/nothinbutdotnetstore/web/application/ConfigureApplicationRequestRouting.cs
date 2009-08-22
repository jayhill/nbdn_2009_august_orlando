using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ConfigureApplicationRequestRouting : StartupCommand
    {
        public ConfigureApplicationRequestRouting(IDictionary<Type, Resolver> resolvers) {}

        public void run()
        {
            IOC.get().instance_of<RouteTable>()
            routes.add(new BasicRequestCommand(null, IOC.get().instance_of<ViewMainDepartments>()));
        }
    }
}