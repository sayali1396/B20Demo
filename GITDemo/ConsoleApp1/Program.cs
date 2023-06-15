// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Hello sayali");
Console.WriteLine("Calculator Task:");
Console.WriteLine("Enter First No:");
int a= int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second No. ");
int b= int.Parse(Console.ReadLine());   
Calculator c1= new Calculator();
c1.PrintA(a,b);
Console.ReadLine(); 