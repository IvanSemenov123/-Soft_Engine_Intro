namespace Lab1;

public class Point
{
    private int x;
    private int y;
    private int z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Point() : this(0, 0, 0)
    {
    }

    public Point(Point point) : this(point.x, point.y, point.z)
    {
    }

    public void MoveBy(int dx, int dy, int dz)
    {
        x += dx;
        y += dy;
        z += dz;
    }

    public Point Clone()
    {
        return new Point(x, y, z);
    }

    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }
}