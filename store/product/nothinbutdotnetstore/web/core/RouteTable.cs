using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public interface RouteTable : IEnumerable<RequestCommand>
    {
        void add(Criteria<FrontControllerRequest> criteria, Func<ApplicationCommand> command_factory); 
    }
}