// Point.cs
public class Point
{
    
    public int X = 0;
    public int Y = 0;

    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    
    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}