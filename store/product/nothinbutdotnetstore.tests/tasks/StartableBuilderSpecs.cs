using System;
using System.Collections.Generic;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.startup.dsl;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.tasks
{
    public class StartableBuilderSpecs
    {
        public abstract class concern : observations_for_a_sut_without_a_contract<StartableBuilder> {}

        [Concern(typeof (StartableBuilder))]
        public class when_created_with_an_initial_command_type_that_should_serve_as_the_first_command : concern
        {
            context c = () =>
            {
                command_type = typeof(OurCommand);
                first_command = an<StartupCommand>();
                list_of_commands = new List<StartupCommand>();
                startup_command_factory = the_dependency<StartupCommandFactory>();


                provide_a_basic_sut_constructor_argument(list_of_commands);
                provide_a_basic_sut_constructor_argument(command_type);

                startup_command_factory
                    .Stub(x => x.create_startup_command(Arg<Type>.Is.Equal(typeof(OurCommand)),
                        Arg<IDictionary<Type,Resolver>>.Is.NotNull)).Return(first_command);
            };


            it should_place_the_instance_of_the_command_on_the_list_of_commands_to_run = () =>
            {
                list_of_commands.should_contain(first_command);
            };


            static IList<StartupCommand> list_of_commands;
            static Type command_type;
            static StartupCommandFactory startup_command_factory;
            static StartupCommand first_command;
        }

        public class OurCommand : StartupCommand
        {
            public void run()
            {
                throw new NotImplementedException();
            }
        }
    }
}