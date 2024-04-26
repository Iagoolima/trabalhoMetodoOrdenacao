using Aula_02.strategy;

namespace Aula_02;

public class QuickSort : SortStrategy
{
    public int[] sort(int[] array) {
        if (array == null || array.Length == 0) {
            return new int[0]; // Retornando um array vazio se o array de entrada for nulo ou vazio
        }
        sort(array, 0, array.Length - 1);
        return array;
    }

    private void sort(int[] array, int leftIndex, int rightIndex) {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) {
                i++;
            }

            while (array[j] > pivot) {
                j--;
            }
            if (i <= j) {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            sort(array, leftIndex, j);
        if (i < rightIndex)
            sort(array, i, rightIndex);
    }


    public void tamanhoArray()
    {
        int tamanho;
        SortPlanner arraySortPlanner = new SortPlanner();
        
        Console.Write("Digite o tamanho da array: ");
        tamanho = int.Parse(Console.ReadLine());
        
        int[] array = arraySortPlanner.GerarArrayComTamanhoERandom(tamanho);
        int[] arrayOrdenado = sort(array);
                
        arraySortPlanner.ImprimirArray(arrayOrdenado);
    }
    
}