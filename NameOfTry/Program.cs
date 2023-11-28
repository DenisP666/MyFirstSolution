namespace NameOfTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte Heigth;
            Console.WriteLine("Please enter your heigth");
            Heigth = Convert.ToByte(Console.ReadLine());
            Console.Write(nameof(Heigth));
            Console.WriteLine(Heigth);
            Console.ReadLine();
        }
    }
}
