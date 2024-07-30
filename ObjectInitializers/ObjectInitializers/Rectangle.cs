namespace ObjectInitializers;

internal class Rectangle
{
    private Point topLeft = new();
    private Point bottomRight = new();

    public Point TopLeft
    {
        get { return topLeft; }
        set { topLeft = value; }
    }

    public Point BottomRight
    {
        get { return bottomRight; }
        set { bottomRight = value; }
    }

    public void DisplayStats()
    {
        Console.WriteLine($"[TopLeft: {topLeft.X}, {topLeft.Y}, {topLeft.Color} BottomRight: {bottomRight.X}, {bottomRight.Y}, {bottomRight.Color}]");
    }




}
