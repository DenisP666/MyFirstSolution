namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 1, z = 5;
            x += y - x++ * z;
            Console.WriteLine($"x = {x}"); //x = -55
            z = --x - y * 5;
            Console.WriteLine($"z = {z}"); //z = -61
            y /= x + 5 % z;
            Console.WriteLine($"y = {y}"); //y = 0
            z = x++ + y * 5;
            Console.WriteLine($"z = {z}"); // z = -56
            x = y - x++ * z;
            Console.WriteLine($"x = {x}"); //x = -3080
            Console.ReadLine();
        }
    }
}
