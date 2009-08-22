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
            var routes = IOC.get().instance_of<RouteTable>();

        }
    }
}