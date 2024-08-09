// See https://aka.ms/new-console-template for more information
using Shapes;

Console.WriteLine("***** Fun with Polymorphism - abstraction and overriding 272 *****");

Hexagon hex = new("Beth");
hex.Draw();

Circle cir = new("Cindy");
cir.Draw();

Console.WriteLine();

Shape[] shapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Rick"),new Hexagon("Pickle") };

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.GetType() == typeof(Hexagon));
    shape.Draw();
}


Console.WriteLine();

Console.WriteLine("***** Fun with Polymorphism - Member Shadowing 275 *****");
TriDCircle tdc = new();
tdc.Draw();

// uses the base class draw method instead of it's own
((Circle)tdc).Draw();


Console.WriteLine();

Console.WriteLine("****** Personal Test ******");



var (ANumber, AText) = new RecordTest();
int A = ANumber + 1;


Console.WriteLine($"{A}, {AText}");


Console.ReadLine();