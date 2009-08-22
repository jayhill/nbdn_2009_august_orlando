using nothinbutdotnetstore.tasks.startup;
using nothinbutdotnetstore.tasks.startup.dsl;
using nothinbutdotnetstore.web.application;

namespace nothinbutdotnetstore.tasks
{
    public class ApplicationStartup
    {
        public void run()
        {
            Start.by<InitializeTheContainer>()
                .followed_by<InitializeTheServiceLayer>()
                .followed_by<InitializingFrontController>()
                .finish_by<ConfigureApplicationRequestRouting>();
                 

//            Start.by_loading_pipeline_from("startup_commands.txt");
        }
    }
}