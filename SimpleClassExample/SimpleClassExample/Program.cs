// See https://aka.ms/new-console-template for more information
using SimpleClassExample;

Console.WriteLine("***** Fun with Class Types! *****\r\n");

Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

for (int i = 0; i<=10; i++) {
    myCar.SpeedUp(5);
    myCar.PrintState();
}

Car chuck = new Car();
chuck.PrintState();


Car mary = new Car("mary");
Car daisy = new ("daisy", 75); // new can be simplified by removing Car

mary.PrintState();
daisy.PrintState();

// need to initiate the correct type of variable to apply it to an out.
Boolean boo;

Car jack = new("jack", 105, out boo);

jack.PrintState();
Console.WriteLine(boo);

Console.WriteLine("***** Fun with Class Types 2 *****\n");

Motorcycle mc = new();
mc.PopAWheely();
mc.SetDriverName("stan");
Console.WriteLine($"Rider name: {mc.name}");

Console.WriteLine("***** Fun with Class Types 3 194 *****\n");
Motorcycle mcc = new(name: "tiny");
mcc.PopAWheely();
Console.WriteLine($"rider name: {mcc.name}");

Console.WriteLine("***** Fun with Class Types 4 196 *****\n");
Motorcycle mac = new(6);
mcc.PopAWheely();
Console.WriteLine($"rider name: {mcc.name}");

Console.ReadLine();
