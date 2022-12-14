/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 01, 2022
* Assignment CIS214 Week 5 GP - First Inheritance
*
* Main application (program) class.
* In this application I will demonstrate the concept of inheritance by
* instantiating Shape and Rectangle objects and demonstratin the use of base
* class methods in a derived class instantiated object.
\******************************************************************************/
public class ShapeDemo
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "Jason D'Oyley - Week 5 GP - First Inheritance\n"
        );

        // Instantiate Shape and Rectangle objects
        Shape s = new Shape("Blue");
        Rectangle r = new Rectangle("Orange", 5, 10);

        // Print each object's properties
        s.PrintShape();
        r.PrintRectangle();

        // Demonstrate calling a base class method from a derived class object
        r.PrintShape();

        // Update the objects' properties
        s.Color = "Green";

        r.Color = "Red";    // base class property
        r.Length = 2;
        r.Width = 4;

        // Print each object's properties
        s.PrintShape();
        r.PrintRectangle();
    }
}