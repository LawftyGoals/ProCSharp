// See https://aka.ms/new-console-template for more information
using Employees;

Console.WriteLine("***** Employee Class Hierarchy - 252 *****");

SalesPerson fred = new() { Age = 31, Name = "Fred", SalesNumber = 50 };

Console.WriteLine(fred.Name);

Manager chucky = new("Chucky", 50, 92, 100000, "333-23-2322", 9000);

chucky.DisplayStats();
Console.WriteLine();
Console.WriteLine("***** Programming for Containment/Delegation - 261 *****");

Manager chuckyTwo = new("ChuckyTwo", 50, 92, 100000, "333-23-2323", 9000);
double cost = chucky.GetBenefitCost();
Console.WriteLine($"Benefit Cost: {cost}");

Console.WriteLine();
Console.WriteLine("***** Employee Class Hierarchy - 264 *****");

Manager chucksMalone = new("ChucksMalone", 50, 92, 1000000, "333-23-3232", 9000);
chucksMalone.GiveBonus(300);
chucksMalone.DisplayStats();
Console.WriteLine();

SalesPerson franny = new("franny", 43, 93, 30000000, "932-22-3232", 31);
franny.GiveBonus(50000000);
franny.DisplayStats();