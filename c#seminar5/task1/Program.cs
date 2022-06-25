int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i=0; i<size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindEvenNumbers(int[] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2 == 0)count++;
    }
    return count;
}

int[] myArray = CreateRandomArray(20,100,1000);
Console.WriteLine("Количество четных чисел в массиве: " + FindEvenNumbers(myArray));