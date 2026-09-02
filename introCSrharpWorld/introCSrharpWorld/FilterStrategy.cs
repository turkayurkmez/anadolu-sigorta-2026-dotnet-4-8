using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introCSrharpWorld
{
    public static class FilterStrategy
    {
       // public delegate bool criteria(int number);

        public static int[] Filter(int[] array, Func<int,bool> criteria)
        {
            List<int> result = new List<int>();
            foreach (var number in array)
            {
                if (criteria(number))
                {
                    result.Add(number);
                }
            }

            return result.ToArray();
        }
    }
}
