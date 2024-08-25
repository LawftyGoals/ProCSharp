// See https://aka.ms/new-console-template for more information

using CustomInterfaces;

Console.WriteLine("***** A first look at interaces - 317 *****\n");

CloneableExample();

static void CloneableExample() {
    string myStr = "Hello";
    OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());

    CloneMe(myStr);
    CloneMe(unixOS);

    static void CloneMe(ICloneable c) {
        object theClone = c.Clone();
        Console.WriteLine($"Clone is a: {theClone.GetType().Name}");
    }
}



Console.WriteLine("\n\n***** Fun with interfaces - 323 *****\n");

Hexagon hex = new();
Console.WriteLine($"Points: {hex.Points}");

Shape[] shapeArray = { new Hexagon("Peter"), new Circle("Lucy") };

foreach (Shape shape in shapeArray) {
    IPointy? ipt = shape as IPointy;
    if (ipt != null) {
        Console.WriteLine($"Points: {ipt.Points}");
    }
    else {
        Console.WriteLine("Not Pointy");
    }

    if (shape is IPointy ipt2) {
        Console.WriteLine("Points: {0}", ipt2.Points);
    }
    else {
        Console.WriteLine($"{shape.PetName} has no points");
    }
}



Console.WriteLine("\n\n***** Fun with interfaces - 325 *****\n");

var sq = new Square("Boxy") { NumberOfSides = 4, SideLength = 4 };

//square needs to be cast to IRegularPointy to get access to perimeter function;
Console.WriteLine($"{sq.PetName} has {sq.NumberOfSides} of length {sq.SideLength} and a perimeter of {((IRegularPointy)sq).Perimeter}");

//workaround code interface of type:
IRegularPointy sq2 = new Square("Boxy2") { NumberOfSides = 4, SideLength = 4 };
//issue is petname and draw() are not defined on interface and so will not show petname or draw
Console.ReadLine();

