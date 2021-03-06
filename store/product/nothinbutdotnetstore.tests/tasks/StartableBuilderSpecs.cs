using System;
using System.Collections.Generic;
using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.startup.dsl;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.tasks
{
    public class StartableBuilderSpecs
    {
        public abstract class concern : observations_for_a_sut_without_a_contract<StartableBuilder>
        {
            context c = () =>
            {
                commands_to_queue = new List<StartupCommand>();
                startup_command_factory = the_dependency<StartupCommandFactory>();
                command_type = typeof (OurCommand);
                provide_a_basic_sut_constructor_argument(command_type);

                first_command = an<StartupCommand>();

                startup_command_factory
                    .Stub(x => x.create_startup_command(Arg<Type>.Is.Equal(typeof (OurCommand)),
                                                        Arg<IDictionary<Type, Resolver>>.Is.NotNull)).Return(first_command);
            };

            static protected StartupCommandFactory startup_command_factory;
            static protected IList<StartupCommand> commands_to_queue;
            static Type command_type;
            static protected StartupCommand first_command;
        }


        //[Concern(typeof (StartableBuilder))]
        //public class when_created_with_an_initial_command_type_that_should_serve_as_the_first_command : concern
        //{
        //    it should_queue_the_instance_of_the_command_to_run = () =>
        //    {
        //        sut.number_of_commands_to_run.should_be_equal_to(1);
        //    };

        //    static Type command_type;
        //}

        //[Concern(typeof (StartableBuilder))]
        //public class when_following_with_another_startup_command : concern
        //{
        //    because b = () =>
        //    {
        //        sut.followed_by<OurCommand>();
        //    };

        //    it should_queue_the_command_to_run = () =>
        //    {
        //        sut.number_of_commands_to_run.should_be_equal_to(2);
        //    };
        //}

        [Concern(typeof (StartableBuilder))]
        public class when_finished_with_another_command : concern
        {
            because b = () =>
            {
                sut.followed_by<OurCommand>();
                sut.finish_by<OurCommand>();
            };

            it should_run_all_queued_commands = () =>
            {
                commands_to_queue.each(x => x.received(y => y.run()));
            };
        }

        public class OurCommand : StartupCommand
        {
            public void run() {}
        }
    }
}