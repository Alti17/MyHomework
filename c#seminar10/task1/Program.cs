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

/*void ShowArray(string[] array)
{
    for(int i=0; i<array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}*/

int NumberOfWordsWithFirstVowel(string[] array1, char[] array2)
{
    int count = 0;
    for (int i=0; i<array1.Length; i++)
        for (int k=0; k<array2.Length; k++)
            if (array1[i][0] == array2[k])
            count++;
    return count;
}

Console.Write("Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array1=CreateStringArray(size);
char[] array2={'a','e','i','o','u','y'};
Console.WriteLine("Number of words with first vowel is " + NumberOfWordsWithFirstVowel(array1, array2));
