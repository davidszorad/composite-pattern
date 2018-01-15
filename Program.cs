using System;

namespace CompositeDesignPattern
{
    /*
    This real-world code demonstrates the Composite pattern used in building a graphical tree structure 
    made up of primitive nodes (lines, circles, etc) and composite nodes (groups of drawing elements 
    that make up more complex elements). 


    OUTPUT:
        -+ Picture
        --- Red Line
        --- Blue Circle
        --- Green Box
        ---+ Two Circles
        ----- Black Circle
        ----- White Circle
    */

    /// <summary>
    /// Program startup class for Real-World 
    /// Composite Design Pattern.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Create a tree structure 
            CompositeElement root =
                new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp =
                new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe =
                new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
