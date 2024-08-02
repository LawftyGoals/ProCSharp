namespace FunWithRecordStructs;

//readonly is the most important here yo
public readonly record struct PointRecordImmutableStandardStruct
{
    public double X { get; init; } = default;
    public double Y { get; init; } = default;
    public double Z { get; init; } = default;

    public PointRecordImmutableStandardStruct(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}
