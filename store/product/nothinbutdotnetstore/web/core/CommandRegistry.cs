namespace nothinbutdotnetstore.web.core
{
    public interface CommandRegistry 
    {
        RequestCommand get_command_that_can_handle(FrontControllerRequest request);
    }
}