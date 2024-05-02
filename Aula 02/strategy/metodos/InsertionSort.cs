using System.Diagnostics;
using Aula_02.strategy;

namespace Aula_02;

public class InsertionSort : SortStrategy
{
    public int[] sort(int[] array)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        var n = array.Length;
        for (int i = 1; i < n; i++)
        {
            var key = array[i];
            var flag = 0;
            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                    array[j + 1] = key;
                }
                else flag = 1;
            }
        }
        TimeSpan tempoDecorrido = stopwatch.Elapsed;
        stopwatch.Stop();
        Console.WriteLine("Esse metodo levou " + tempoDecorrido + " milesimos de segundos para ser executado");
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