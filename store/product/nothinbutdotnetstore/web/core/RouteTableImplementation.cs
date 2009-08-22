using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class RouteTableImplementation : RouteTable
    {
        readonly ICollection<RequestCommand> commands = new List<RequestCommand>();
        readonly RequestCommandFactory request_command_factory;

        public RouteTableImplementation(RequestCommandFactory request_command_factory)
        {
            this.request_command_factory = request_command_factory;
        }

        public IEnumerator<RequestCommand> GetEnumerator()
        {
            return commands.GetEnumerator();
        }

        public void add(Criteria<FrontControllerRequest> criteria, 
            Func<ApplicationCommand> command)
        {
            commands.Add((request_command_factory.create_command(criteria,command.Invoke())));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}