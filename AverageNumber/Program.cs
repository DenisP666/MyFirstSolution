namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double FirstNumber, SecondNumber, ThirdNumber;

            while (true)
            {


                try
                {
                    Console.WriteLine("Enter first number");

                    FirstNumber = double.Parse(Console.ReadLine());


                    Console.WriteLine("Enter second number");

                    SecondNumber = double.Parse(Console.ReadLine());


                    Console.WriteLine("Enter third number");


                    ThirdNumber = double.Parse(Console.ReadLine());


                    double AverageNumber = (FirstNumber + SecondNumber + ThirdNumber) / 3;
                    Console.WriteLine($"Average namber = {AverageNumber}");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Incorrect data. Please enter correct number!");
                    continue;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
