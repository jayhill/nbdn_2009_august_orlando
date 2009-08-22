using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class RouteTableImplementation : RouteTable
    {
        public IEnumerator<RequestCommand> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void add(Criteria<FrontControllerRequest> criteria, Func<ApplicationCommand> command)
        {
            throw new NotImplementedException();
        }
    }
}