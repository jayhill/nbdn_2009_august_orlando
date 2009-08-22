using System.Collections;
using System.Linq;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;

namespace nothinbutdotnetstore.tests.web
{
    public class EnueratorSpikes : observations_for_a_static_sut
    {
        public class Key
        {
            public int number { get; set; }

            public override bool Equals(object obj)
            {
                return ((Key) obj).number == number;
            }

            public override int GetHashCode()
            {
                return 1;
            }
        }

        it enumerating_with_enumerator = () =>
        {
            var numbers = Enumerable.Range(1, 100);
            var dictionary = new Hashtable();

            var key = new Key {number = 2};
            var other_key = new Key {number = 3};

            dictionary.Add(key, key);
            dictionary.Add(other_key, other_key);
        };
    }
}