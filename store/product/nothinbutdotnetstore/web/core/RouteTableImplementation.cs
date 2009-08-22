using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class RouteTableImplementation : RouteTable
    {
<<<<<<< HEAD:store/product/nothinbutdotnetstore/web/core/RouteTableImplementation.cs
        readonly ICollection<RequestCommand> commands = new List<RequestCommand>();
        readonly RequestCommandFactory request_command_factory;

        public RouteTableImplementation(RequestCommandFactory request_command_factory)
        {
            this.request_command_factory = request_command_factory;
=======
        IList<RequestCommand> commands;
        RequestCommandFactory command_factory;

        public RouteTableImplementation(RequestCommandFactory command_factory)
        {
            this.commands = new List<RequestCommand>();
            this.command_factory = command_factory;
>>>>>>> b6036c5352b72f240cac94120ab2db491d7e8e95:store/product/nothinbutdotnetstore/web/core/RouteTableImplementation.cs
        }

        public IEnumerator<RequestCommand> GetEnumerator()
        {
            return commands.GetEnumerator();
        }

<<<<<<< HEAD:store/product/nothinbutdotnetstore/web/core/RouteTableImplementation.cs
        public void add(Criteria<FrontControllerRequest> criteria, 
            Func<ApplicationCommand> command)
        {
            commands.Add((request_command_factory.create_command(criteria,command.Invoke())));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
=======
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void add(Criteria<FrontControllerRequest> criteria, Func<ApplicationCommand> factory_for_specific_command)
        {
            commands.Add(command_factory.create_command(criteria,factory_for_specific_command()));

>>>>>>> b6036c5352b72f240cac94120ab2db491d7e8e95:store/product/nothinbutdotnetstore/web/core/RouteTableImplementation.cs
        }
    }
}