using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introCSrharpWorld
{
    public static class Process
    {


        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }



        private static int[] customArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static void ShowNumbers()
        {
            // var filteredNumber1 = FilterStrategy.Filter(customArray, isEven);


            //var filteredNumber2 = FilterStrategy.Filter(customArray, 
            //delegate (int n)
            //{
            //    return n % 2 == 1;
            //});

            var filteredNumber3 = FilterStrategy.Filter(customArray, n => n > 5);
            showAlternative(filteredNumber3);
        }

        private static void show(int[] ints)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static void showAlternative(int[] ints)
        {
            ints.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
