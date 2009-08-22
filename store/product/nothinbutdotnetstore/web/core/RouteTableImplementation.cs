using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class RouteTableImplementation : RouteTable
    {
        IList<RequestCommand> commands;
        RequestCommandFactory command_factory;

        public RouteTableImplementation(RequestCommandFactory command_factory)
        {
            this.commands = new List<RequestCommand>();
            this.command_factory = command_factory;
        }

        public IEnumerator<RequestCommand> GetEnumerator()
        {
            return commands.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void add(Criteria<FrontControllerRequest> criteria, Func<ApplicationCommand> factory_for_specific_command)
        {
            commands.Add(command_factory.create_command(criteria,factory_for_specific_command()));

        }
    }
}