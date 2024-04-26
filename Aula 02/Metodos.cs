namespace Aula_02;

public class Metodos
{
    
        public int[] quickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
        
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
    
            if (leftIndex < j)
                quickSort(array, leftIndex, j);
            if (i < rightIndex)
                quickSort(array, i, rightIndex);
            return array;
    }
        
    public int[] boubleSort(int[] array) 
    {
        var n = array.Length;
        for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (array[j] > array[j + 1])
            {
                var tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
            }
        return array;
    }
    
    public int[] selectionSort(int[] array)
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
        
        
        
        
        
        
        
        
}