// See https://aka.ms/new-console-template for more information
using RecordInheritance;

Console.WriteLine("***** Record type inheritance! *****");

Car c = new("Honda", "Pilot", "Blue");

MiniVAn m = new("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking MiniVan is a Car = {m is Car}");
Console.WriteLine();


Console.WriteLine("***** Record types with positional parameters! 258 *****");

PositionalCar pc = new("Honda", "Pilot", "Blue");
PositionalMiniVan pm = new("Honda", "Pilot", "Blue", 10);

Scooter s = new("Mo", "Ma");
FancyScooter f = new("Mo", "Ma", "Blurple");

Console.WriteLine($"Checking PositionalMiniVan is-a PositionalCar: {pm is PositionalCar}");

Console.WriteLine($"Checking PositionalFancyScooter is-a PositionalScooter: {f is Scooter}");
Console.WriteLine();


Console.WriteLine("***** Equality with inherited Record Types! 259 *****");

MotorCycle mc3 = new("Harley", "Lowrider");
Scooter sc3 = new("Harley", "Lowrider");

Console.WriteLine($"MotorCycle and Scooter are equal: {Equals(mc3, sc3)}"); // False

MotorCycle scMc = new Scooter("Harley", "Lowrider");
Console.WriteLine($"MotorCycle and MotorCycle Scooter are equal: {Equals(mc3, scMc)}"); // False

Console.WriteLine();

Console.WriteLine("***** Deconstructor behavior with inherited record types! 260 *****");
MotorCycle mcDec = new FancyScooter("Harley", "Lowrider", "Gold"); //wont deconstruct fancycolor bc not on MotorCycle
var (make1, model1/*, fancyColor1*/) = mcDec; //fancyColor causes error
var  (make2, model2, fancyColor2) = (FancyScooter)mcDec; //must cast

Console.WriteLine($"{make2}{model2}{fancyColor2}");
Console.WriteLine();

