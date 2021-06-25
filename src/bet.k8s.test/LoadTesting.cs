using System.Linq;

namespace bet.k8s.test
{
    public class LoadTesting
    {
        public int[] GetPrimeNumbers(int to)
        {
            return Enumerable.Range(2, to).Where(x => !Enumerable.Range(3, x / 2).Any(y => x % y == 0)).ToArray();
        }
    }
}
