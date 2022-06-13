bool Holiday (int num)
{
    if(num>5 && num<8) return true;
    
    else return false;
}
bool DayWeek (int num)
{
    if(num>0 && num<8) return true;
    else return false;
}
Console.Write("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if(DayWeek(a)) if(Holiday(a)) Console.WriteLine("Это выходной день.");
else Console.WriteLine("Это будний день.");
else Console.WriteLine("В неделе 7 дней.");