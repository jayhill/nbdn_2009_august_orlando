using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.infrastructure
{
    public class AnyCriteria : Criteria<FrontControllerRequest>
    {
        public bool is_satisfied_by(FrontControllerRequest item)
        {
            return true;
        }
    }
}