using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square s1 = new Square("Red",3);
        Shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue",4,5);
        Shapes.Add(s2);

        Circle s3 = new Circle("Green",6);
        Shapes.Add(s3);

        foreach(Shape s in Shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area} ");
        }
    }
}