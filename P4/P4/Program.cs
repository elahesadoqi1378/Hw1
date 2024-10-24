int a, b, c, d, e, sum, avg;
Console.WriteLine("enter five numbers:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
e = Convert.ToInt32(Console.ReadLine());
sum = a + b + c + d + e;
avg = sum / 5;
Console.WriteLine("average is:" + avg);
if (avg % 2 == 0)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
