namespace FunWithRecordStructs;

public record struct PointRecordStandardStruct
{
    public double X { get; set; } = default;
    public double Y { get; set; } = default;
    public double Z { get; set; } = default;

    public PointRecordStandardStruct(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
