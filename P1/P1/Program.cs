Console.WriteLine("enter your first and last name:");
string name = Console.ReadLine();
Console.WriteLine("enter your phonenumber:");
string mobile = Convert.ToString(Console.ReadLine());
if (mobile.Length == 11 && mobile.Substring(0, 2) == "09")
{
    Console.WriteLine("phonenumber is true");
}
else
{
    {
        Console.WriteLine("phonenumber is wrong");

    }
    return;
}
Console.WriteLine("enter your national code:");
string national = Convert.ToString((Console.ReadLine()));
if (national.Length == 10)
{
    Console.WriteLine("format is true");
}
else
{
    Console.WriteLine("your national code is wrong!");
    return;
}
Console.WriteLine("enter your date of birth(dd/mm/yyyy)");
string birthday = Console.ReadLine();
//string day = tarikh.Substring(0, 2);
//string month = tarikh.Substring(3, 2);
//string year = tarikh.Substring(6, 4);
if (birthday[2] == '/' && birthday[5] == '/' && birthday.Length==10)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("your birthday is wrong!");
    return;
}
Console.WriteLine("enter your email:");
string email = Console.ReadLine();
if ((email.IndexOf('@') == email.LastIndexOf('@')) && (email.IndexOf('.') == email.LastIndexOf('.')))
{
    Console.WriteLine("true");

}

else
{
    Console.WriteLine("your email is wrong!");
}

