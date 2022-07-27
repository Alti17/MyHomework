string[] CreateStringArray(int size)
{
    string[] words=new string[size];
    for(int i=0; i<size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        words[i] = Console.ReadLine();
    }
    return words;
}

void ShowArray(string[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] ArrayCombination(string[] array, int size)
{
    string[] newarray=new string[size/2];
    for (int i =0; i<size/2; i++)
    newarray[i] = array[2*i] + array[2*i+1];
    return newarray;
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array=CreateStringArray(size);
ShowArray(array);
string[] newarray = ArrayCombination(array, size);
ShowArray(newarray);
