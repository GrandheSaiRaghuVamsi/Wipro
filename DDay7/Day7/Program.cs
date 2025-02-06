internal class Program
{
    public delegate void dels(string s);
    public delegate void dels1();
    private static void Main(string[] args)
    {
        Program o = new Program();
        //Console.WriteLine("Hello, World!");
        dels d = new dels(o.Disp);
        d("Sai Raghu Vamsi Grandhe");

        dels1 de = new dels1(Disp);
        de();

        Disp();
        o.Disp("qwe");
        
    }
     void Disp(string u)
    {
        Console.WriteLine(u);
    }

    static void Disp()
    {
        Console.WriteLine("HELLo EVERy ");
    }
}