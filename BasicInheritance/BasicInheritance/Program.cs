// See https://aka.ms/new-console-template for more information
using BasicInheritance;

Console.WriteLine("***** Basic Inheritance *****\n");
// Make a Car Object, set max speed and current speed
Car myCar = new(80) { Speed = 50 };

Console.WriteLine("My car is going {0} KPH", myCar.Speed);
Console.WriteLine();

Console.WriteLine("***** Basic Inheritance - Inheritance 247 *****\n");

MiniVan myVan = new();
Console.WriteLine("My van is going {0} KPH", myVan.Speed);
// ERrOr
//myVan._currSpeed = 55;






Console.ReadLine();
