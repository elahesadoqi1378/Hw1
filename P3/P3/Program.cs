int a, b, c;
Console.WriteLine("enter 3 numbers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    if (b > c)
    {
        Console.WriteLine(a + ">" + b + ">" + c);
    }
    else { Console.WriteLine(a + ">" + c + ">" + b); }
}
if (b > a && b > c)
{
    if (a > c)
    {
        Console.WriteLine(b + ">" + a + ">" + c);
    }
    else { Console.WriteLine(b + ">" + c + ">" + a); }
}
if (c > a && c > b)
{
    if (a > b)
    {
        Console.WriteLine(c + ">" + a + ">" + b);
    }
    else { Console.WriteLine(c + ">" + b + ">" + a); }
}