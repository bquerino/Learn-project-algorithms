using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_project_algorithms
{
    class SelectionSort
    {
        public void OrdenaComSelectionSort()
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            //menor_posicao is short for position of min
            int menor_posicao, temp;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                menor_posicao = i;//set menor_posicao to the current index of array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[menor_posicao])
                    {
                        //menor_posicao will keep track of the index that min is in, this is needed when a swap happens
                        menor_posicao = j;
                    }
                }

                //if menor_posicao no longer equals i than a smaller value must have been found, so a swap must occur
                if (menor_posicao != i)
                {
                    temp = arr[i];
                    arr[i] = arr[menor_posicao];
                    arr[menor_posicao] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
