 using System.Data.SqlClient;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.tasks;

namespace nothinbutdotnetstore.tests.tasks
 {   
     public class StartupCommandFactorySpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<StartupCommandFactory,
                                             StartupCommandFactoryImplementation>
         {
        
         }

         [Concern(typeof(StartupCommandFactoryImplementation))]
         public class when_creating_a_startup_command_from_a_type : concern
         {
             context c = () =>
             {
            
             };

             because b = () =>
             {
        
             };

        
             it should_create_a_command_that_has_access_to_the_dictionary_of_resolvers = () =>
             {
                 
            
            
             };
         }
     }
 }
