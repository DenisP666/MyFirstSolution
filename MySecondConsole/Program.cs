namespace MySecondConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141592653;
            const decimal e = 1.414213562373095048M;
            string output = string.Format("value pi = {0}, value e = {1}", pi, e); // String Format type of line output
            Console.WriteLine($"Value pi = {pi}, value e = {e}");                  // Interpolation type of line output
            Console.WriteLine(output);
        }
    }
}
