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
            //menor_posicao índice, starta com o 0
            int menor_posicao, temp;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                menor_posicao = i;//marca a variável menor_posicao como o índice atual do array

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[menor_posicao])
                    {
                        //menor_posicao vai continuar rastreando o menor índice, isso é necessário quando acontece o SWAP nas posições
                        menor_posicao = j;
                    }
                }

                //Essa condição basicamente checa se a menor_posicao não é mais igual a primeira variável, quando isso acontecer é porque temos a lista ordenada.
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
