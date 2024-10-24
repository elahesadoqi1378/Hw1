
int a, b, c, d, e;
Console.WriteLine("enter five numbers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
e = Convert.ToInt32(Console.ReadLine());
int largest = a;
if (b > largest)
{
    largest = b;
}
if (c > largest)
{
    largest = c;
}
if (d > largest)
{
    largest = d;
}
else
{
    largest = e;
}
Console.WriteLine("the largest number is:" + largest);
