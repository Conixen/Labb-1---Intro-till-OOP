namespace Labb_1___Intro_till_OOP
{
    internal class Program
    {
                        // LEON JOHANSSON SUT24
        static void Main(string[] args)
        {
            // Creating new Circle and Triangle with set values 
            var cirkel1 = new Circle(5);
            var cirkel2 = new Circle(6);
            var cirkel3 = new Circle(8);
            var triangel1 = new Triangel(6, 9);

            // Writes out the set valuve of area and circumfrence of a circle
            // Aswell as the area of a triangle
            Console.WriteLine($"Arean på en cirkel med radie 5 är: { cirkel1.GetArea() }");
            Console.WriteLine($"Arean på en cirkel med radie 6 är: { cirkel2.GetArea() }");

            Console.WriteLine($"\nOmkretsen med en radie på 8 är: { cirkel3.GetCircumfrence() }");

            Console.WriteLine($"Arean på en triangel med höjden 6 och basen 9 är: {triangel1.GetAreaTriangel()}");

            Console.WriteLine("Press any button to countine...");
            Console.ReadKey();
        }
    }
}
