namespace ConeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592653;

            Console.WriteLine("Enter radius r");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("enter guide l");
            double l = double.Parse(Console.ReadLine());
            double Area = pi * r * (r + l);
            Console.WriteLine($"Cone Area = {Area}");

        }
    }
}
