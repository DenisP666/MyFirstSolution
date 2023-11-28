namespace EvenOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {


                    Console.WriteLine("Enter Number");
                    double Number = double.Parse(Console.ReadLine());
                    if (Number % 2 == 0)
                    {
                        Console.WriteLine($"number {Number} even");
                    }
                    else
                    {
                        Console.WriteLine($"number {Number} odd");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter valid data!");
                    continue;

                }
            }
        }
    }
}
