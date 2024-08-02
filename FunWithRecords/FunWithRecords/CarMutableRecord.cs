namespace FunWithRecords;

// While this syntax is supported, the record types are intended to be used for immutable data models.
internal record CarMutableRecord
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public CarMutableRecord()
    {

    }

    public CarMutableRecord(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }
}
