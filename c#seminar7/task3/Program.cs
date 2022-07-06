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
void FindArithmeticMeanInArray(int [,] array)
{
    double sa=0;
    int j=0;
    while (j<array.GetLength(1))
    {
        for(int i=0; i<array.GetLength(0); i++)
        {
            sa += array[i,j];
        }
        sa=sa/array.GetLength(0);
        Console.Write(sa + " ");
        j++;
        sa=0;
    } 
}

int [,]array=CreateRandomTwoDemArray(4,5,1,9);
FindArithmeticMeanInArray(array);