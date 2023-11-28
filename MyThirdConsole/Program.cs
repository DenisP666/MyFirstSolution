namespace MyThirdConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            byte b = (byte)a; // for explicit conversion  byte b = a; - for implicit conversion
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
