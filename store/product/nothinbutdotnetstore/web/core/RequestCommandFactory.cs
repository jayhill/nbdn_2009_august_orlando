using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public interface RequestCommandFactory
    {
        RequestCommand create_command(Criteria<FrontControllerRequest> criteria, ApplicationCommand application_command);
    }
}