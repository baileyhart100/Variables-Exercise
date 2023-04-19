namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialize Variables
            string name = "Bailey";
            int age = 25;
            char middleInitial = 'L';
            bool isOver18 = true;
            double currentTemp = 66.2;
            decimal currentPrice = 3.89m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");

        }
    }
}
