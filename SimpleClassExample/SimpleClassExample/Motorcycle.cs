

namespace SimpleClassExample;
class Motorcycle {

    public int driverIntensity;
    public string name;

    public void SetDriverName(string name) => this.name = name;


    public void PopAWheely() {
        for (int i = 0; i <= driverIntensity; i++) {
            Console.WriteLine("YEEEEEE HAWWWWWWWW!!");
        }

    }

    // type ctor for creation of a custom constructor in vscode <3 or vs
    public Motorcycle() { Console.WriteLine("default ctor"); }

    // the following 2 ctors extend the main ctor, its called constructor chaining.
    //public Motorcycle(int intensity) : this(intensity, "") { Console.WriteLine("int ctor"); }
    //public Motorcycle(string name) : this(0, name) { Console.WriteLine("string ctor"); }


    public Motorcycle(int intensity = 0, string name = "") {
        Console.WriteLine("main ctor");
        if (intensity > 10) {
            intensity = 10;
        }
        driverIntensity = intensity;
        this.name = name;
    }



}

