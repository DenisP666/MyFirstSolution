namespace OperationOnNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dec, Edin;
            int Sum = 0;
            Console.WriteLine("Enter your number");
            int Numb = Convert.ToInt32(Console.ReadLine());

            Edin = Numb % 10;
            Console.WriteLine($"Число единиц = {Edin}");
            Dec = (Numb / 10) % 10;
            Console.WriteLine($"Число десятков = {Dec}");

            while (Numb != 0)
            {
                Sum += Numb % 10;
                Numb /= 10;
            }

            Console.WriteLine($"Сумма цифр = {Sum}");
            Console.ReadLine();
        }
    }
}
