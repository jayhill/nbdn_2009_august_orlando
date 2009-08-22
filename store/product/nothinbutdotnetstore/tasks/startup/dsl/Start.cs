using developwithpassion.commons.core.infrastructure.containers;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class Start
    {
        static public StartableBuilder by<T>() where T : StartupCommand
        {
            return new StartableBuilder(typeof(T), new SCF);
        }
    }
}