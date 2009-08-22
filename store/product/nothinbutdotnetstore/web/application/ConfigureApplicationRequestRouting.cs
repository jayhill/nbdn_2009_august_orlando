using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.infrastructure;
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
<<<<<<< HEAD:store/product/nothinbutdotnetstore/web/application/ConfigureApplicationRequestRouting.cs

            routes.add(null, () => IOC.get().instance_of<ViewMainDepartments>());
=======
            routes.add(new AnyCriteria<FrontControllerRequest>(),() => new ViewMainDepartments(IOC.get().instance_of<CatalogTasks>(),
                IOC.get().instance_of<DisplayEngine>()));
>>>>>>> b6036c5352b72f240cac94120ab2db491d7e8e95:store/product/nothinbutdotnetstore/web/application/ConfigureApplicationRequestRouting.cs
        }
    }
}