namespace ObjectInitializers;

internal class PointReadOnlyAfterCreation
{
    public int X { get; init; }
    public int Y { get; init; }

    public void DisplayStats()
    {
        Console.WriteLine("InitOnlySetter: [{0}, {1}]", X, Y);
    }

    public PointReadOnlyAfterCreation(int x, int y)
    {
        X = x;
        Y = y;
    }

    public PointReadOnlyAfterCreation()
    {

    }

}
