// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Hello sayali");
Console.WriteLine(  "Multiplication opeartion staeted");
Console.WriteLine("Enter 1st no:");
    int a= int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2 nd no.");
int b= int.Parse(Console.ReadLine());
mul m = new mul();
m.multi(4, 5);
Console.ReadLine(); 