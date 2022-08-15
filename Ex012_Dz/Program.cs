int[] arr ={1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("");
}

void SelectionSort(int[] array)
{
    //int count = array.Length;

    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
                maxPosition = j;
        }
        int temporay = array[i];
        array[i] = array[maxPosition];                                     //сделать упорядочивание в обратном порядке
        array[maxPosition] = temporay;
    }
    Console.WriteLine(" ");
}


PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);
