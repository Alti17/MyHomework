int[,] CreateSpiraleTwoDimArray(int n)
{
    int[,] newMatrix = new int[n, n];
    int i = 0;
    int k = 1;
    int j = 0;
    for (j = 0; j < n; j++)
    {
        newMatrix[i, j] = k;
        k++;
    }

    j = n-1;
    k=n+1;
    for (i = 1; i < n; i++)
    {
        newMatrix[i,j] = k;
        k++;
    }

    i = n-1;
    k=n*2;
    for (j = n - 2; j >= 0; j--)
    {
        newMatrix[i,j] = k;
        k++;
    }

    j = 0;
    k=n*3-1;
    for (i = n - 2; i > 0; i--)
    {
        newMatrix[i,j] = k;
        k++;
    }

    i = n-3;
    k=n*3+1;
    for (j = 1; j <=n - 2; j++)
    {
        newMatrix[i,j] = k;
        k++;
    }

    i = n-2;
    k=n*4-1;
    for (j = n - 2; j > 0; j--)
    {
        newMatrix[i,j] = k;
        k++;
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

int [,]array=CreateSpiraleTwoDimArray(4);
Console.WriteLine();
ShowArray(array);
