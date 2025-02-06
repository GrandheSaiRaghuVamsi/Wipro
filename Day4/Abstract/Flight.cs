using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Flight
    {
        public int FlightNo { get; set; }
        public string FlightName { get; set; }
        public void FlightDetails()
        {
            Console.WriteLine(FlightName + " " + FlightNo);
        }
        public void Flicost()
        {
            Console.WriteLine("sai raghuvamsi");
        }
        public abstract void FareDetails();
    }
    class FlightFare : Flight
    {
        public decimal Basicfare { get; private set; }
        public int durationinhrs { get; set; }
        public string typedes { get; set; }
        public override void FareDetails()
        {
            if (durationinhrs > 4)
            {
                Basicfare = 8000;
            }
            else
            {
                Basicfare = 5000;
            }
            if (typedes.ToLower().Equals("international"))
            {
                Basicfare += 10000;
            }
            Console.WriteLine($"Basicfare : {Basicfare}");

        }
    }
}
