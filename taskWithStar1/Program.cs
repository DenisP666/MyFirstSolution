namespace taskWithStar1
{
    internal class Program                           //Алгоритм Евклида для простейшей реализации нахождения наибольшего общего делителя для двух чисел. Для неопределенного, пока не решил, потом обновлю.
    {
        static void Main(string[] args)
        {
            int FirstNumb, SecondNumb, Nod;
            Console.WriteLine("Enter FirstNumb");
            FirstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SecondNumb");
            SecondNumb = Convert.ToInt32(Console.ReadLine());

            while (FirstNumb != SecondNumb)
            {
                if (FirstNumb > SecondNumb)
                {
                    FirstNumb = FirstNumb - SecondNumb;
                }
                else
                {
                    SecondNumb = SecondNumb - FirstNumb;
                }
            }

            Nod = SecondNumb;
            Console.WriteLine("Divisor: " + Nod);

            Console.ReadKey();
        }
    }
}
