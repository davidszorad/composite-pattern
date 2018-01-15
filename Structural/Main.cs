using System;

namespace CompositeDesignPattern.Structural
{
    /*
    DEFINITION:
    Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients 
    treat individual objects and compositions of objects uniformly.

    Participants
    The classes and objects participating in this pattern are:
        Component   (DrawingElement)
            declares the interface for objects in the composition.
            implements default behavior for the interface common to all classes, as appropriate.
            declares an interface for accessing and managing its child components.
            (optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
        Leaf   (PrimitiveElement)
            represents leaf objects in the composition. A leaf has no children.
            defines behavior for primitive objects in the composition.
        Composite   (CompositeElement)
            defines behavior for components having children.
            stores child components.
            implements child-related operations in the Component interface.
        Client  (CompositeApp)
            manipulates objects in the composition through the Component interface.
    
    
    This structural code demonstrates the Composite pattern which allows the creation of a tree structure 
    in which individual nodes are accessed uniformly whether they are leaf nodes or branch (composite) nodes.


    OUTPUT:
        -root
        ---Leaf A
        ---Leaf B
        ---Composite X
        -----Leaf XA
        -----Leaf XB
        ---Leaf C
    */

    /// <summary>
    /// Main startup class for Structural 
    /// Composite Design Pattern.
    /// </summary>
    class Main
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void MainApp()
        {
            // Create a tree structure
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);

            // Wait for user
            Console.ReadKey();
        }
    }
}
