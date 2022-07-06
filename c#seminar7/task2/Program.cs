int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int [,] newMatrix=new int [a,b];
    for(int i=0; i<a; i++)
    {
        for(int j=0; j<b; j++)
        {
            newMatrix[i,j]=new Random().Next(min,max+1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

void FindPositionInArray(int [,] array, int i, int j)
{
    if (i<array.GetLength(0) && j<array.GetLength(1)) 
    Console.WriteLine(array[i,j]);
    
    else
    Console.WriteLine("Такого элемента нет.");
    
}

int [,]array=CreateRandomTwoDemArray(4,5,1,9);
Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
FindPositionInArray(array, i, j);