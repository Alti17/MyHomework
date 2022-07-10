int [,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    int [,] newMatrix=new int [a,b];
    for(int i=0; i<a; i++)
    {
        for(int j=0; j<b; j++)
        {
            newMatrix[i,j]=new Random().Next(min,max+1);
        }
    }
    return newMatrix;
}

void ShowArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");   
        }
        Console.WriteLine();
    }
}

int[] FindSumInArray(int [,] array)
{
    int sum=0;
    int j=0;
    int[] ArraySum=new int[array.GetLength(1)];
    while (j<array.GetLength(1))
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        ArraySum[j]=sum;
        Console.Write(ArraySum[j]+" ");
        j++;
        sum=0;
    }
    return ArraySum;
}

int FindMinSumInLine(int[] array, int min)
{ 
    
    
    for(int i=1; i<array.Length;i++)
        if(array[i]<array[min])
        {    
            min=i;
        }
    return min;
}

int [,]array=CreateRandomTwoDimArray(2,3,1,9);
ShowArray(array);
Console.WriteLine();
int [] myArray = FindSumInArray(array);
int min = FindMinSumInLine(myArray, 0);
Console.Write("Столбец с наименьшей суммой: " + min);
Console.WriteLine();