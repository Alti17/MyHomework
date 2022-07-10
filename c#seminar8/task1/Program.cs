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

int [,] SortingNumbers(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1)-1; j++)
        {
            for(int m=j+1; m<array.GetLength(1); m++)
            {
                    if(array[i,j]>array[i,m])
                    {
                        int temp=array[i,j];
                        array[i,j]=array[i,m];
                        array[i,m]=temp;
                    }
                     
            }
        }
        
    }    
    return array;
}

int [,]array=CreateRandomTwoDimArray(4,3,1,9);
ShowArray(array);
int [,]myArray=SortingNumbers(array);
Console.WriteLine();
ShowArray(myArray);

