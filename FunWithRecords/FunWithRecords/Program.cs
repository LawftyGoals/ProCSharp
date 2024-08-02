// See https://aka.ms/new-console-template for more information
using FunWithRecords;

Console.WriteLine("***** Fun with Records! *****");

//Object initialization
Car myCar = new Car()
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};

Console.WriteLine("My car: ");
DisplayCarStats(myCar);
Console.WriteLine();

//Use the custom constructor
Car anotherMyCar = new("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
DisplayCarStats(anotherMyCar);
Console.WriteLine();

//Compile error if property is changed
//myCar.Color = "Red";

//Records

Console.WriteLine("***** Fun with Records - Records 237 *****");
//use object initialization
CarRecord myCarRecord = new CarRecord { Make = "Honda", Model = "Pilot", Color = "Blue" };
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();

CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car record:");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();

//Compile error if property is changed
//myCarRecord.Color = "Red";


Console.WriteLine("***** Fun with Records - Positional Syntax Records 237 *****");
CarShortRecord myCarShortRecord = new("Honda", "Pilot", "Blue");
DisplayCarShortRecordStats(myCarShortRecord);
Console.WriteLine();

Console.WriteLine("***** Fun with Records - Deconstruct Records 237 *****");
//only works with "positional syntax"
CarShortRecord myCarDeconstructRecord = new("Honda", "Pilot", "Orange");
// myCarDeconstructRecord.Deconstruct(out string make, out string model, out string color);
myCarDeconstructRecord.Deconstruct(out string a, out string b, out string c);
Console.WriteLine($"Make: {a}, Model: {b}, Color: {c}");

// tuple deconstructor
CarShortRecord tupleDeconstructor = new("Honda", "Prelude", "Pink");
var (make, model, color) = tupleDeconstructor;
Console.WriteLine($"Make: {make}, Model: {model}, Color: {color}");
Console.WriteLine();

/* DOES NOT WORK
CarRecord tupDecRecord = new("Honda", "Civic", "Yellow");
var (ma, mo, co) = tupDecRecord;
*/

Console.WriteLine("***** Fun with Records - Equating Records 240 *****");
Console.WriteLine($"Cars are the same? {myCar.Equals(anotherMyCar)}");
// returns False

Console.WriteLine($"Cars are the same refernce? {ReferenceEquals(myCar, anotherMyCar)}");
// returns False

/*
 * Record types behave differently. Record types implicitly override Equals, ==, and !=, and two record
 * types are considered equal if the hold the same values and are the same type, just as if the instances are
 * value types. Consider the following code and the subsequent results:
 */


Console.WriteLine($"Record Cars are the same? {myCarRecord.Equals(anotherMyCarRecord)}");
//returns True
Console.WriteLine($"Record Cars are the same refernce? {ReferenceEquals(myCarRecord, anotherMyCarRecord)}");
// returns False
Console.WriteLine($"Record Cars are the same? {myCarRecord == anotherMyCarRecord}");
//returns True
Console.WriteLine($"Record Cars are not the same? {myCarRecord != anotherMyCarRecord}");
// returns False


Console.WriteLine();

CarRecord myCopiedCarRecord = myCarRecord with { Model = "Odyssey" };

Console.WriteLine("My Copied Car:");
Console.WriteLine(myCopiedCarRecord.ToString());

Console.WriteLine("Car Record oyp using with expression results:");

Console.WriteLine($"Record Cars are the same? {myCopiedCarRecord.Equals(myCarRecord)}");
//returns False
Console.WriteLine($"Record Cars are the same refernce? {ReferenceEquals(myCarRecord, myCopiedCarRecord)}");
// returns False
Console.WriteLine($"Record Cars are the same? {myCarRecord == myCopiedCarRecord}");
//returns False
Console.WriteLine($"Record Cars are not the same? {myCarRecord != myCopiedCarRecord}");
// returns True


Console.WriteLine();



Console.ReadLine();

// can use displaycarrecordstats if extend carrecord
static void DisplayCarShortRecordStats(CarShortRecord c)
{
    Console.WriteLine($"Car Make: {c.Make}");
    Console.WriteLine($"Car Model: {c.Model}");
    Console.WriteLine($"Car Color: {c.Color}");
}

static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine($"Car Make: {c.Make}");
    Console.WriteLine($"Car Model: {c.Model}");
    Console.WriteLine($"Car Color: {c.Color}");
}

static void DisplayCarStats(Car c)
{
    Console.WriteLine($"Car Make: {c.Make}");
    Console.WriteLine($"Car Model: {c.Model}");
    Console.WriteLine($"Car Color: {c.Color}");
}