using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Yellow", 8);
        Rectangle rectangle1 = new Rectangle("Blue",8,4);
        Circle circle1 = new Circle("Brown", 5);


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(circle1);
        shapes.Add(rectangle1);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The Color is {color}\nThe area is {area}");
        }
    }
}