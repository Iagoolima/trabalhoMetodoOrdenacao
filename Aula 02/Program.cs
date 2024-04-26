using Aula_02;

class Program
{
    static void Main(string[] args)
    {
        int opc;
        Ordenacao ordenacao = new Ordenacao();
        Metodos metodos = new Metodos();
        
        do
        {
            Console.Clear();
            
            Console.WriteLine("1 - Quick sort");
            Console.WriteLine("2 - Bouble sorte");
            Console.WriteLine("3 - Selection sort");
            Console.WriteLine("4 - insertion sort ");
            Console.WriteLine("5 - select sort");
            opc = int.Parse(Console.ReadLine());
            
            switch (opc)
            {
                case 1:
                    int tamanho1;
                
                    Console.Write("digite o tamanho da array:");
                    tamanho1 = int.Parse(Console.ReadLine());
                    
                    int[] array1 = ordenacao.GerarArrayComTamanhoERandom(tamanho1);
                    int[] arrayOrdenado1 = metodos.quickSort(array1, 0 , array1.Length - 1);
                    
                    ordenacao.ImprimirArray(arrayOrdenado1);
                    
                    break;
            
                case 2:
                    int tamanho2;
                
                    Console.Write("digite o tamanho da array:");
                    tamanho2 = int.Parse(Console.ReadLine());
                
                    int[] array2 = ordenacao.GerarArrayComTamanhoERandom(tamanho2);
                    int[] arrayOrdenado2 = metodos.boubleSort(array2);
                
                    ordenacao.ImprimirArray(arrayOrdenado2);
                    break;
                case 3:
                    int tamanho3;
                
                    Console.Write("digite o tamanho da array:");
                    tamanho3 = int.Parse(Console.ReadLine());
                
                    int[] array3 = ordenacao.GerarArrayComTamanhoERandom(tamanho3);
                    int[] arrayOrdenado3 = metodos.selectionSort(array3);
                
                    ordenacao.ImprimirArray(arrayOrdenado3);
                    break;
                case 4:
                    int tamanho4;
                
                    Console.Write("digite o tamanho da array:");
                    tamanho4 = int.Parse(Console.ReadLine());
                
                    int[] array4 = ordenacao.GerarArrayComTamanhoERandom(tamanho4);
                    int[] arrayOrdenado4 = metodos.boubleSort(array4);
                
                    ordenacao.ImprimirArray(arrayOrdenado4);
                    break;
                case 5:
                    int tamanho5;
                
                    Console.Write("digite o tamanho da array:");
                    tamanho5 = int.Parse(Console.ReadLine());
                
                    int[] array5 = ordenacao.GerarArrayComTamanhoERandom(tamanho5);
                    int[] arrayOrdenado5 = metodos.boubleSort(array5);
                
                    ordenacao.ImprimirArray(arrayOrdenado5);
                    break;
                
                default:
                    return;
            }

        } while (opc != 0);
        
    }
}