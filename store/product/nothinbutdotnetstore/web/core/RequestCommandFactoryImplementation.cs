using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class RequestCommandFactoryImplementation : RequestCommandFactory
    {
        public RequestCommand create_command(Criteria<FrontControllerRequest> criteria, ApplicationCommand application_command)
        {
            return new BasicRequestCommand(criteria, application_command);
        }
    }
}