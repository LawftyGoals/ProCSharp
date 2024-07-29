// See https://aka.ms/new-console-template for more information
using EmployeeApp;

Console.WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new("Marvin", 450, 30_000);
emp.GiveBonus(1000);
emp.DisplayStats();


emp.SetName("Marv");
Console.WriteLine("Employee is named: {0}", emp.GetName());



Employee emp2 = new();
emp2.SetName("Xena the Warrior Princess!");

Console.WriteLine("***** Fun with Encapsulation 214 *****\n");

Employee emp3 = new("Mervin", 456, 30000);
emp3.GiveBonus(1000);
emp.DisplayStats();

emp.Name = "Merv";
Console.WriteLine("Employee  is name: {0}", emp.Name);

Employee joe = new();
joe.Age++;

joe.DisplayStats();


Console.ReadLine();

