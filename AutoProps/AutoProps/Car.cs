
namespace AutoProps;

class Car
{
    // automatic properties! no need to define backing fields
    public string PetName { get; set; }
    public int Speed { get; set; }
    public string Color { get; set; }

    // like ctor prop makes this property making automatic
    public string Test { get; set; }

    public Car()
    {
        
    }

    public Car(string name, int speed, string color): this(name, speed, color, "No Tests!")
    {
        
    }
    public Car (string name, int speed, string color, string test)
    {
        PetName = name;
        Speed = speed;
        Color = color;
        Test = test;
    }

    public void DisplayStats()
    {
        Console.WriteLine("Car Name: {0}\nSpeed: {1}\nColor: {2}\n", PetName, Speed, Color);
    }
}
