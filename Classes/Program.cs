namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "Ford";
            car1.Model = "F-150";
            car1.Year = 2023;

            Console.WriteLine($"The car is a {car1.Make} {car1.Model} made in {car1.Year}.");
        }
    }
}
