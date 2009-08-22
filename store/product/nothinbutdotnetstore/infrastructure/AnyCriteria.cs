namespace nothinbutdotnetstore.infrastructure
{
    public class AnyCriteria<T> : Criteria<T>
    {
        public bool is_satisfied_by(T item)
        {
            return true;
        }
    }
}