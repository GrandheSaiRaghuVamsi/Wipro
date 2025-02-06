using Day3;

internal class Program
{
    private static void Main(string[] args)
    {
        //private instance
        Console.WriteLine("Enter PID: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter PNAME: ");
        string n = Console.ReadLine();
        Product srv = new Product(p,n);
        srv.PublicMthd();
        Console.WriteLine();

        //public instance
        Cust c = new Cust();
        Console.WriteLine("Enter CID: ");
        c.cid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter CNAME: ");
        c.cname = Console.ReadLine();
        Console.WriteLine(c.cid);
        Console.WriteLine(c.cname);
        c.Display();

        //
        
    }
}