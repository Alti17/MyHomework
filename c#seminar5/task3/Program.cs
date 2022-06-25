double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];
    for(int i=0; i<size; i++)
    {
        newArray[i] = Math.Round(new Random().Next(10,100) + new Random().NextDouble(),1);
        Console.Write(newArray[i] + "  ");
    }
    Console.WriteLine();
    return newArray;
}

double DifferenceMaxMin(double[] array)
{
    double max=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>max) max=array[i];
    }
    double min=max;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min) min=array[i];
    }
    double difference = max-min;
    return difference;
}

double[] myArray = CreateRandomArray(10);
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + DifferenceMaxMin(myArray));
