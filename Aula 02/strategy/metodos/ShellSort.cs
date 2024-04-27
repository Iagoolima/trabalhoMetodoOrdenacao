using System.Diagnostics;
using Aula_02.strategy;

namespace Aula_02
{
    public class ShellSort : SortStrategy
    {
        public int[] sort(int[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = array.Length;
            
            for (int intervalo = n / 2; intervalo > 0; intervalo /= 2)
            {
                for (int i = intervalo; i < n; i += 1)
                {
                    int temp = array[i];
                    
                    int j;
                    for (j = i; j >= intervalo && array[j - intervalo] > temp; j -= intervalo)
                    {
                        array[j] = array[j - intervalo];
                    }
                    
                    array[j] = temp;
                }
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
}