using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_project_algorithms
{
    class ShellSort
    {
        public void ImprimeOrdenacao()
        {
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;

            n = arr.Length;
            Console.WriteLine("Elementos Originais do array :");
            exibe_elementos_array(arr);
            shellSort(arr, n);
            Console.WriteLine("\nElementos ordenados :");
            exibe_elementos_array(arr);
            Console.ReadKey();
        }

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        public void exibe_elementos_array(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");

        }
    }
}
