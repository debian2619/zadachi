Console.WriteLine("Put number x : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Put number y : ");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0)
{
    Console.WriteLine(" First guarter ");
}
if(x > 0 && y < 0)
{
    Console.WriteLine(" Fourth guarter ");
}
if(x < 0 && y < 0)
{
    Console.WriteLine(" Third quarter ");
}
if(x < 0 && y > 0)
{
    Console.WriteLine(" Second quarter ");
}

