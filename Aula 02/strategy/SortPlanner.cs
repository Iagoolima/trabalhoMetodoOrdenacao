using System;
using Aula_02.strategy;

namespace Aula_02
{
    public class SortPlanner
    {
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public int[] ExecutarOrdenacao(int[] array)
        {
            if (_sortStrategy == null)
            {
                throw new InvalidOperationException("Estratégia de ordenação não definida.");
            }

            return _sortStrategy.sort(array);
        }

        public int[] GerarArrayComTamanhoERandom(int tamanho)
        {
            Random random = new Random();
            int[] array = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                array[i] = random.Next(tamanho);
            }

            Console.Write($"Array de tamanho {tamanho}: ");
            return array;
        }

        public void ImprimirArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("aperte ENTER para continuar...");
            Console.ReadLine();
        }
    }
}