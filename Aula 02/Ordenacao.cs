namespace Aula_02;

public class Ordenacao
{
    public int[] GerarArrayComTamanhoERandom(int tamanho)
    {
        Random random = new Random();
        int[] array = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            array[i] = random.Next(tamanho);
        }
        
        Console.WriteLine($"Array de tamanho {tamanho}:");
        return array;

    }
    
    public void ImprimirArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.ReadLine();
    }
}