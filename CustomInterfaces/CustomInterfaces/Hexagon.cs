
namespace CustomInterfaces;
public class Hexagon : Shape, IPointy {
    public Hexagon() {

    }
    public Hexagon(string name) : base(name) {

    }
    public override void Draw() {
        Console.WriteLine($"Drawing {PetName} the Hexagon");
    }

    public byte Points => 6;
}
