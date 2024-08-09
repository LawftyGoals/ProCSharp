// See https://aka.ms/new-console-template for more information
using Employees;
using Shapes;

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


Console.WriteLine();
Console.WriteLine("***** Employee Class Hierarchy - the \"as\" keyword 278 *****");
var frank = CastingExample();

GivePromotion((Manager)frank);

GiveSwitchPromotion(new PtSalesPerson("Nom", 27, 1337, 100000, "420-69-1337", 1000));




static void GivePromotion(Employee emp)
{

    //runtime type check
    Console.WriteLine($"{emp.Name} was promoted");
    if (emp is SalesPerson s)
    {
        Console.WriteLine("Sleazy sales {0}\n", s.SalesNumber);
    }
    else if (emp is Manager m)
    {
        Console.WriteLine("Managemanger {0}\n", m.StockOptions);
    }
    else if (emp is not SalesPerson and not Manager)
    {
        Console.WriteLine("its no one ok.");
    }
    else if (emp is var _)
    {
        Console.WriteLine("Discarded emp");
    }
}

static void GiveSwitchPromotion(Employee emp)
{
    switch (emp)
    {
        case SalesPerson s:
            Console.WriteLine("{0} stupid number.", s.SalesNumber);
            break;
        case Manager m:
            Console.WriteLine("{0} theft options", m.StockOptions);
            break;
        case Employee _:
            Console.WriteLine("not a group.");
            break;
    }
            Console.WriteLine();

}


static object CastingExample()
{
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "1111-111-111", 5);

    object[] things = new object[4];

    things[0] = new Hexagon();
    things[1] = false;
    things[2] = new Manager();
    things[3] = "Last Thing";

    foreach (object item in things)
    {
        Hexagon h = item as Hexagon;
        if (h == null)
        {
            Console.WriteLine("Not a Hexy");
        }
        else
        {
            h.Draw();
        }
    }

    return frank;

}