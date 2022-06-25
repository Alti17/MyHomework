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

int FindSumNegativeNumbers(int[] array)
{
    int sum=0;
    for(int i=1; i<array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(10,-100,101);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях в массиве: " + FindSumNegativeNumbers(myArray));
