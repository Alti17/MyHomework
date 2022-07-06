/*int [,] CreateRandomTwoDemArray(int a, int b, int min, int max)
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
int [,]array=CreateRandomTwoDemArray(4,5,1,9);*/

double [,] CreateRandomTwoDemArray(int m, int n, int min, int max)
{
    double [,] newMatrix=new double [m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            newMatrix[i,j]=Math.Round(new Random().Next(min,max+1) + new Random().NextDouble(),1);
            Console.Write(newMatrix[i,j] + "  ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
CreateRandomTwoDemArray(5,5,-10,10);



