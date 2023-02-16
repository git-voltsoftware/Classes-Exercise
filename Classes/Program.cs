namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2022;

            Console.WriteLine($"Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");

        }


    }
}
