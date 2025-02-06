namespace NewMethoda
{
    internal class Program
    {
        static void Display( ref int n)
        {
            n *= 20 ;
            Console.WriteLine("Static method "+n);
            //return n;
        }
        static void Outsamp(out int n)
        {
            // n *= 20;
            int s = 20;
            n = s * 20;                  
            Console.WriteLine("Outsamp  " + n);
            //return n;
        }
        void Show() //instance class
        {
            Console.WriteLine("Instance method");
        }
        int add(int a,int b) //method with return type
        {
            return a + b;
        }
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Program p = new Program();
            //p.Show();
            //int a = 10;
            //Console.WriteLine($"the value of a is {a}");
            ////Display( ref a);
            ////Console.WriteLine("The value of a after display method " + a);
            //Console.WriteLine(p.add(10, 20));

            ////out parameter
            //Outsamp(out a);
            //Console.WriteLine("Value after out sample method " + a);
            //Emplyee[] emp = new Emplyee[5];
            //for (int i = 0; i < 2/*emp.Length*/; i++)
            //{
            //    Console.WriteLine("Enter Eid");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter EName");
            //    string en = Console.ReadLine();
            //    Console.WriteLine("Enter Dept");
            //    string de = Console.ReadLine();
            //    Console.WriteLine("Enter Salaray");
            //    decimal sa = Convert.ToDecimal(Console.ReadLine());

            //    emp[i] = new Emplyee(id, en, de, sa);
            //}

            //for (int i = 0; i < 2/*emp.Length*/; i++)
            //{
            //    Console.WriteLine("{0} , {1} , {2} , {3}",emp[i].EmpId, emp[i].Empname, emp[i].Dept, emp[i].sal);
            //}

            string k;
            do
            {
                Console.WriteLine("EMP MANAGEMENT SYS :\n1.ADDEMP\n2.DISPLAY\n3.UPDATE\n4.DELETE");
                Console.WriteLine("Enter your choice");
                string u = Console.ReadLine();
                EmpCRUDops empq = new EmpCRUDops();
                switch (u)
                {
                    case "1":
                        Console.WriteLine("Enter Eid");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter EName");
                        string en = Console.ReadLine();
                        Console.WriteLine("Enter Dept");
                        string de = Console.ReadLine();
                        Console.WriteLine("Enter Salaray");
                        decimal sa = Convert.ToDecimal(Console.ReadLine());

                        empq.Addemp(id, en, de, sa);
                        break;

                    case "2":
                        empq.Listemp();
                        break;

                    default:
                        Console.WriteLine("enter the valid choice");
                        break;


                }
                Console.WriteLine("Enter y for contine: ");
                k = Console.ReadLine();
            } while (k == "y");
        }
    }
}