 using System.Collections.Generic;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.web.core;
 using developwithpassion.bdd.mbunit;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
 {   
     public class RouteTableSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<RouteTable,
                                             RouteTableImplementation>
         {
        
         }

         [Concern(typeof(RouteTableImplementation))]
         public class when_adding_a_route_to_the_list_of_available_routes : concern
         {
             context c = () =>
             {
                 criteria = an<Criteria<FrontControllerRequest>>();
                 app_command = an<ApplicationCommand>();
                 command = an<RequestCommand>();
                 command_factory = the_dependency<RequestCommandFactory>();

                 command_factory.Stub(x => x.create_command(criteria, app_command)).Return(command);
             };

             because b = () =>
             {
                sut.add(criteria,() => app_command); 
             };

        
             it should_add_the_route_that_was_created_by_the_command_factory = () =>
             {
                 sut.should_contain(command);
             };

             static RequestCommand command;
             static Criteria<FrontControllerRequest> criteria;
             static ApplicationCommand app_command;
             static RequestCommandFactory command_factory;
         }
     }
 }
