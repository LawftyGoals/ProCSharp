namespace RecordInheritance; 
public sealed record MiniVAn: Car {
    public int Seating { get; init; }
    public MiniVAn(string make, string model, string color, int seating) : base(make, model, color)
    {
        Seating = seating;
        
    }
}
