int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i=0; i<size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.Write("Это первый массив.");
    Console.WriteLine();
    return newArray;
}

int[] CreateRandomArray2(int size)
{
    int[] newArray = new int[size];
    for(int i=0; i<size; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.Write("Это второй массив.");
    Console.WriteLine();
    return newArray;
}

int[] CopyArray(int[] array1, int[] array2, int size)
{
    for(int i=0; i<size; i++)
    {
        array2[i]=array1[i];
        Console.Write(array2[i] + " ");
    }
    return array2;
}
int[] myArray = CreateRandomArray(5,100,1000);
int[] otherArray = CreateRandomArray2(5);
Console.WriteLine("Это первый массив во втором." + CopyArray(myArray, otherArray, 5));
