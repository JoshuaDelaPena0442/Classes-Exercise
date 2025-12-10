namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Civic";
            carOne.Year = 2005;
            
            Console.WriteLine($"This {carOne.Make} {carOne.Model}, was made in the year {carOne.Year}.");
        }
    }
}
