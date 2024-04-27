using Aula_02.strategy;

namespace Aula_02;

public class Menu
{
    public void showMenu()
    {
        int opc;
        SortPlanner arraySortPlanner = new SortPlanner();

        do
        {
            Console.Clear();
            
            Console.WriteLine("1 - Quick sort");
            Console.WriteLine("2 - Bouble sorte");
            Console.WriteLine("3 - Selection sort");
            Console.WriteLine("4 - insertion sort ");
            Console.WriteLine("5 - select sort");
            Console.Write("Opcao: ");
            opc = int.Parse(Console.ReadLine());
            
            switch (opc)
            {
                case 1:
                    SortStrategy quickSort = new QuickSort();
                    quickSort.tamanhoArray();
                    break;
                case 2:
                    SortStrategy boubleSort = new BoubleSort();
                    boubleSort.tamanhoArray();
                    break;
                case 3:
                    SortStrategy selectionSort = new SelectionSort();
                    selectionSort.tamanhoArray();
                    break;
                case 4:
                    SortStrategy insertionSort = new InsertionSort();
                    insertionSort.tamanhoArray();
                    break;
                case 5:
                    SortStrategy shellSort = new ShellSort();
                    shellSort.tamanhoArray();
                    break;
                default:
                    return;
            }

        } while (opc != 0);
    }
}