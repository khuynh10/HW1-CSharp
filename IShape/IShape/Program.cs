using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Install Visual Studio Community 2015.

2. Create a C# Console Application with the following interface and classes:

A IShape interface that contains two methods Perimeter() and Area().
Three classes Point, Circle, and Rectangle, all implementing the IShape interface. The Point class 
should have two properties X and Y, which are the x and y coordinates of the point.

The Circle and the Rectangle class should have a property Center which is of type Point.
A ShapeTest class. The Main() method of this class does the following:
Create a List of type IShape.
Create a Point object, a Circle object, a Rectangle object, and add them to the List.
Use a loop statement to calculate the total perimeter and area of the objects stored in the List.
Output the total perimeter and area to console.
Note that your code should follow the .NET Naming Guidelines (a shorter version for C# is here).
*/

namespace Shapes
{

    public interface IShape
    {
        double Perimeter();
        double Area();
    }
    class Point : IShape
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
        int x { get; set; }
        int y { get; set; }

        public double Area()
        {
            return 0;
        }

        public double Perimeter()
        {
            return 0;
        }
    }

    class Circle : IShape
    {
        Point Center { get; }
        int radius;


        public Circle(int radius, Point Center)
        {
            this.radius = radius;
            this.Center = Center;
        }

        public double Area()
        {
            return 3.14 * radius * radius;
        }

        public double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }

    class Rectangle : IShape
    {
        int width;
        int length;
        Point Center { get; }

        public Rectangle(int width, int length, Point center)
        {
            this.width = width;
            this.length = length;
            this.Center = center;
        }

        public double Perimeter()
        {
            return (2 * length) + (2 * width);
        }

        public double Area()
        {
            return (length * width);
        }
    }


    public class Tester
    {
        public static void Main(string[] args)
        {
            Point pt1 = new Point(1, 1);
            Rectangle rec1 = new Rectangle(2, 2, pt1);
            Circle cic1 = new Circle(2, pt1);

            List<IShape> listOfShapes = new List<IShape>();
            listOfShapes.Add(pt1);
            listOfShapes.Add(rec1);
            listOfShapes.Add(cic1);

            for (int i = 0; i < listOfShapes.Count; i++)
            {
                Console.WriteLine("The Area for index# " + i + " is " + listOfShapes[i].Area());
                Console.WriteLine("The Perimeter for index# " + i + " is " + listOfShapes[i].Perimeter());
                Console.WriteLine(" ");
            }
        }
    }
}
