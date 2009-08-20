using System.Data;
using System.Data.SqlClient;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tests.infrastructure
{
    public class BasicContainerSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<Container,
                BasicContainer> {}

        [Concern(typeof (BasicContainer))]
        public class when_getting_an_instance_of_a_dependency : concern
        {
            context c = () =>
            {
            };

            because b = () =>
            {
                result = sut.instance_of<IDbConnection>();
            };


            it
                should_return_the_dependency_that_was_resolved_using_the_types_resolver
                    = () =>
                    {
                        result.should_be_equal_to(sql_connection);
                    };

            static IDbConnection result;
            static SqlConnection sql_connection;
        }
    }
}