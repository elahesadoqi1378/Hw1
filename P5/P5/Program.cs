int a, firstnumber, secondnumber, thirdnumber, c;
Console.WriteLine("Enter a three-digit number");
a = Convert.ToInt32(Console.ReadLine());
firstnumber = a / 100;
c = a % 100;
secondnumber = c / 10;
thirdnumber = c % 10;
if (a >= 100 && a <= 999)
{
    if (firstnumber + thirdnumber == secondnumber)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }
}


else { Console.WriteLine("your chosen number is false"); }
