using Aula_02.strategy;

namespace Aula_02;

public class Menu
{
    public void showMenu()
    {
        int opc;
        SortPlanner arraySortPlanner = new SortPlanner();
        
        SortStrategy boubleSort = new BoubleSort();
        SortStrategy selectionSort = new SelectionSort();
        SortStrategy insertionSort = new InsertionSort();
        SortStrategy quickSort = new QuickSort();
        SortStrategy shellSort = new ShellSort();
        
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
                    quickSort.tamanhoArray();
                    break;
                case 2:
                    boubleSort.tamanhoArray();
                    break;
                case 3:
                    selectionSort.tamanhoArray();
                    break;
                case 4:
                    insertionSort.tamanhoArray();
                    break;
                case 5:
                    shellSort.tamanhoArray();
                    break;
                default:
                    return;
            }

        } while (opc != 0);
    }
}