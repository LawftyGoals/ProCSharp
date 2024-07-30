// See https://aka.ms/new-console-template for more information
using ObjectInitializers;

Console.WriteLine("***** Fun with Object Init Syntax *****\n");

Point firstPoint = new();
firstPoint.X = 10;
firstPoint.Y = 10;

firstPoint.DisplayStats();

Point anotherPoint = new(20, 20);
anotherPoint.DisplayStats();

// make point using init syntax shorthand for the 10, 10 thing up here.

Point finalPoint = new Point { X = 30, Y = 30 };
finalPoint.DisplayStats();


Console.WriteLine("***** Fun with Object Init Syntax 228 - Init Syntax *****\n");

PointReadOnlyAfterCreation firstReadOnly = new PointReadOnlyAfterCreation(20, 20);
firstReadOnly.DisplayStats();

PointReadOnlyAfterCreation secondReadOnly = new PointReadOnlyAfterCreation { X = 30, Y = 30 };
secondReadOnly.DisplayStats();

// will not work:
// secondReadOnly.X = 10;

Console.WriteLine("***** Fun with Object Init Syntax 228 - Init Syntax with constructor *****\n");

Point initWithConstructor = new Point(50, 50) { X = 100, Y = 100 };
//will be 100
initWithConstructor.DisplayStats();


Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 20 };
goldPoint.DisplayStats();



Console.WriteLine("***** Fun with Object Init Syntax 230 - init data with init syntax *****\n");

Rectangle myRect = new Rectangle { TopLeft = new Point { X = 10, Y = 10 }, BottomRight = new Point { X = 200, Y = 200 } };
myRect.DisplayStats();


Console.ReadLine();
