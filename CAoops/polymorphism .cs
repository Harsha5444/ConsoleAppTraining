using System;

namespace CAoops
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class polymorphism
    {
        static void Main(string[] args)
        {
            Shape shape; // Declare a reference of type Shape

            shape = new Circle(); // Assign a Circle object to the Shape reference
            shape.Draw();         // Calls the overridden Draw() in Circle

            shape = new Square(); // Assign a Square object to the Shape reference
            shape.Draw();         // Calls the overridden Draw() in Square
        }
    }
}
