using System.Diagnostics;
using Aula_02.strategy;

namespace Aula_02;

public class BoubleSort : SortStrategy
{
    public int[] sort(int[] array)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        var n = array.Length;
        for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (array[j] > array[j + 1])
            {
                var tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
            }
        long tempoDecorrido = stopwatch.ElapsedMilliseconds;
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