using Day4;
using Day4_OOPS;

internal class Program
{
    private static void Main(string[] args)
    {
        int Empid, sal;
        string Empname, Depn, Managername;
        //Console.WriteLine("Hello, World!");
        //Employee e = new Employee();
        //e.Display();
        //Console.WriteLine(e.Empid + " " + e.Empname + " in Main cls");

        //Department department = new Department();
        //department.Display();

        Console.WriteLine("Enter value for Empid and Empname : ");
        Empid = Convert.ToInt32(Console.ReadLine());
        Empname = Console.ReadLine();
        Console.WriteLine("Enter value for Depname and sal : ");
        Depn = Console.ReadLine();
        sal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for Managername : ");
        Managername = Console.ReadLine();

        Manager mgr = new Manager(Empid,Empname,Depn,sal,Managername);
        mgr.Display();


        Console.WriteLine(mgr.Empid + " " + mgr.Empname + " in Main cls");
        Console.WriteLine(mgr.Depn + " " + mgr.sal + " in Main cls");
        Console.WriteLine(mgr.Managername + " in Main cls");
    }
}