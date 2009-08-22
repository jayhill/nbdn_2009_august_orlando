using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public interface RouteTable : IEnumerable<RequestCommand>
    {
<<<<<<< HEAD:store/product/nothinbutdotnetstore/web/core/RouteTable.cs
        void add(Criteria<FrontControllerRequest> criteria, 
            Func<ApplicationCommand> application_command);
=======
        void add(Criteria<FrontControllerRequest> criteria,Func<ApplicationCommand> factory_for_specific_command);
>>>>>>> b6036c5352b72f240cac94120ab2db491d7e8e95:store/product/nothinbutdotnetstore/web/core/RouteTable.cs
    }
}