int num;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Это четное число.");
}
else
{
    Console.WriteLine("Это нечетное число.");
}