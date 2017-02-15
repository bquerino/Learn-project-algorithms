/*Muitos problemas têm a seguinte propriedade: cada instância do problema contém uma instância menor do mesmo problema. 
 * Dizemos que esses problemas têm estrutura recursiva.  Para resolver um tal problema, podemos aplicar o seguinte método:
 * se a instância em questão for pequena,
 * resolva-a diretamente (use força bruta se necessário);
 * senão,
 * reduza-a a uma instância menor do mesmo problema,
 * aplique o método à instância menor,
 * volte à instância original.
 * A aplicação desse método produz um algoritmo recursivo.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_project_algorithms
{
    class MergeSort
    {
        static public void DoMerge(int [] numbers, int left, int mid, int right)
        {
            int [] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
        
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
        
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
        
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
 
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
 
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
 
        static public void MergeSort_Recursive(int [] numbers, int left, int right)
        {
          int mid;
        
          if (right > left)
          {
            mid = (right + left) / 2;
            MergeSort_Recursive(numbers, left, mid);
            MergeSort_Recursive(numbers, (mid + 1), right);
        
            DoMerge(numbers, left, (mid+1), right);
          }
        }        
 
        public void ImprimeOrdenaComMergeSortRecursivo()
        {
            int[] numbers = { 200, 500, 900, 5, 2, 1, 9, 6, 4 };
            int len = 9;
 
            Console.WriteLine("MergeSort por método recursivo");
            MergeSort_Recursive(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers[i]);

            Console.ReadKey();
 
        }





    }
}
