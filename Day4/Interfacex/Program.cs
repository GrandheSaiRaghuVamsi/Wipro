using Interfacex;

internal class Program
{
    private static void Main(string[] args)
    {
        string? o;
        do
        {
            Console.WriteLine("Enter the shape : 1.Circle 2.Rect");
            string? h = Console.ReadLine();
            switch (h.ToLower())
            {
                case "circle":
                    Console.WriteLine("Enter Value for radius for circle :");
                    int r = Convert.ToInt32(Console.ReadLine());
                    IShape i = new Circle() { radius = r };
                    i.calarea();
                    break;

                case "rectangle":
                    Console.WriteLine("Enter Value for length for Rectangle :");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Value for breadth for Rectangle :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    IShape v = new Rect() { length = l, breadth = b };
                    v.calarea();
                    break;

                default:
                    Console.WriteLine("Enter Value for length for square :");
                    int e = Convert.ToInt32(Console.ReadLine());
                    IShape vi = new Rect();
                    vi.defaultSquare(e);
                    break;
            }
            Console.WriteLine("Enter ''y'' to Continue ");
            o = Console.ReadLine();
        } while (o == "y");

    }
}