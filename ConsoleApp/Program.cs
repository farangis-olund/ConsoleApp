using System.Diagnostics.CodeAnalysis;

Console.WriteLine("#########################");
Console.WriteLine("Hello, What is your name?");
string name= Console.ReadLine()!;
int age;
if (string.IsNullOrEmpty(name))
    Console.WriteLine("Please write your name");
else
{
    Console.WriteLine($"Welcome {name} to our portal. Now how old are you?");
    bool isValid= int.TryParse(Console.ReadLine(), out age);
    
    if (isValid)
    {
        Console.WriteLine($"It seems you was barn in {DateTime.Now.Year - age}!" +
            $" Now write the sity where you are living");
        string city=Console.ReadLine()!;
        if (string.IsNullOrEmpty(city))
            Console.WriteLine("Please write your city of live");
        else
            Console.WriteLine($"Greate that you are living in {city.ToUpper()}");
    }
        
}
Console.ReadKey();

