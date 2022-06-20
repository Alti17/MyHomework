int size = 8;
int[]array = new int [size];
for(int i=0; i<size; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");
}