using Abstract;

internal class Program
{
    private static void Main(string[] args)
    {
        //object initializer = at the time of object creation, intialize the values
        FlightFare f = new FlightFare() { FlightNo = 1111, FlightName = "king", durationinhrs = 6, typedes = "international" };
        f.FlightDetails();
        f.FareDetails();
        f.Flicost();
        //create instance for flightfare by making as a refernce to flight which is abstract class
        Flight ff = new FlightFare() { FlightNo = 1221, FlightName = "Queen", durationinhrs = 4, typedes = "national" };
        ff.FlightDetails();
        ff.FareDetails();

    }
}