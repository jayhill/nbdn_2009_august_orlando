 using System;
 using System.Collections.Generic;
 using System.Data.SqlClient;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure.containers.basic;
 using nothinbutdotnetstore.tasks;
 using developwithpassion.bdd.mbunit;

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
                 result = an<StartupCommand>();
                 item_to_add = new KeyValuePair<Type, Resolver>(typeof(string), new DelegateResolver(() => "xyz");
                 
                 dictionary = new Dictionary<Type, Resolver>();
                 dictionary.Add(item_to_add);
             };

             because b = () =>
             {
                 result = sut.create_startup_command(type, dictionary);
             };
        
             it should_create_a_command_that_has_access_to_the_dictionary_of_resolvers = () =>
             {
                 result.run();
                 dictionary.should_contain(item_to_add);
             };

             static StartupCommand result;
             static IDictionary<Type, Resolver> dictionary;
             static Type type;
             static KeyValuePair<Type, Resolver> item_to_add;

             private class ResolverAddingCommand : StartupCommand
             {
                 readonly IDictionary<Type, Resolver> resolvers;
                 readonly KeyValuePair<Type, Resolver> resolver_to_add;

                 public ResolverAddingCommand( IDictionary<Type,Resolver> resolvers ,
                     KeyValuePair<Type, Resolver> resolver_to_add)
                 {
                     this.resolvers = resolvers;
                     this.resolver_to_add = resolver_to_add;
                 }

                 public void run() {resolvers.Add(resolver_to_add);}
             }
         }
     }
 }
