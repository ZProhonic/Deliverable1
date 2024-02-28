using Circle_Objects_Lab;

double radius = 0;

Console.WriteLine("Welcome to the Circle Generator");
Console.WriteLine("Enter the radius of the circle: ");

while (double.TryParse(Console.ReadLine(), out radius) == false)
{
    Console.WriteLine("Please enter a valid number");
}

Circle circle = new Circle(radius);

while (true)
{

    Console.WriteLine($"Diameter: {Circle.CalculateDiameter(radius)}");
    Console.WriteLine($"Circumference: {Circle.CalculateCircumference(radius)}");
    Console.WriteLine($"Area: {Circle.CalculateArea(radius)}");

    Console.WriteLine("Should the circle grow? (y/n)");
    string userSelection = Console.ReadLine();

    if (userSelection.ToLower() == "y")
    {
        Console.WriteLine("The circle is magically growing...");
        Circle.Grow(radius);
        radius = radius * 2;
        //could not get Grow() method to properly double radius. attempted to save new radius value as double but received error stating void cannot be converted to double. Stumped me!
    }
    else
    {
        Console.WriteLine($"Goodbye. The circle's final radius is {Circle.GetRadius(radius)}");
        break;
    }

}
