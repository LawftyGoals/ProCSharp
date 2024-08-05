// See https://aka.ms/new-console-template for more information
using RecordInheritance;

Console.WriteLine("***** Record type inheritance! *****");

Car c = new("Honda", "Pilot", "Blue");

MiniVAn m = new("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking MiniVan is a Car = {m is Car}");


Console.WriteLine("***** Record types with positional parameters! 258 *****");

PositionalCar pc = new("Honda", "Pilot", "Blue");
PositionalMiniVan pm = new("Honda", "Pilot", "Blue", 10);

Scooter s = new("Mo", "Ma");
FancyScooter f = new("Mo", "Ma", "Blurple");

Console.WriteLine($"Checking PositionalMiniVan is-a PositionalCar: {pm is PositionalCar}");

Console.WriteLine($"Checking PositionalFancyScooter is-a PositionalScooter: {f is Scooter}");