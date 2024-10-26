using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            Point p1 = new Point(x, y, z);
            Random rnd = new Random();
            Point p2 = new Point(rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100));
            Point p3 = new Point(p1);
            Point p4 = p2.Clone();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            List<Point> points = new List<Point>();
            for (int i = 0; i < 5; i++)
                points.Add(new Point(rnd.Next(-100, 100), rnd.Next(-100, 100), rnd.Next(-100, 100)));

            foreach (var point in points)
                Console.WriteLine(point);

            points.RemoveAt(1);
            points.RemoveAt(3);

            foreach (var point in points)
                Console.WriteLine(point);
        }
    }
}