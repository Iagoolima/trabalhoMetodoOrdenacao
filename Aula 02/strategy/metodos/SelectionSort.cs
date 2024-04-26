using Aula_02.strategy;

namespace Aula_02;

public class SelectionSort : SortStrategy
{
    public int[] sort(int[] array)
    {
        var arrayLength = array.Length;
        for (int i = 0; i < arrayLength - 1; i++)
        {
            var smallestVal = i;
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (array[j] < array[smallestVal])
                {
                    smallestVal = j;
                }
            }
            var tempVar = array[smallestVal];
            array[smallestVal] = array[i];
            array[i] = tempVar;
        }
        return array;
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