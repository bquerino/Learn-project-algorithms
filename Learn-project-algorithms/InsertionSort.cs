using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_project_algorithms
{
    class InsertionSort
    {
        public void OrdenaComInsertionSort()
        {
            int[] intArray = { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("==========Integer Array Input===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }

                intArray[j + 1] = temp;
            }

            Console.WriteLine("==========Integer Array OutPut===============");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadKey();
        }
    }
}
