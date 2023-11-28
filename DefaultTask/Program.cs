namespace DefaultTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = default(sbyte);
            short s = default(short);
            int i = default(int);
            long l = default(long);
            byte d = default(byte);
            ushort u = default(ushort);
            char c = default(char);
            uint y = default(uint);
            ulong x = default(ulong);
            float f = default(float);
            double z = default(double);
            decimal p = default(decimal);
            bool n = default(bool);
            char h = default(char);
            string t = default;
            int? inul = default(int?);
            object obj = default;
            Console.WriteLine("..............DEFAULT VALUES OF DATA TYPES C#..............");
            Console.WriteLine($"           sbyte_____________________________{a}");
            Console.WriteLine($"           int_______________________________{i}");
            Console.WriteLine($"           short_____________________________{s}");
            Console.WriteLine($"           long______________________________{l}");
            Console.WriteLine($"           byte______________________________{d}");
            Console.WriteLine($"           ushort____________________________{u}");
            Console.WriteLine($"           char______________________________{c}"); //странно, но моя VS2022 не выводит стандартное для char значение (/0), null для ссылочных типов отображает (отсутствие значения)
            Console.WriteLine($"           uint______________________________{y}");
            Console.WriteLine($"           ulong_____________________________{x}");
            Console.WriteLine($"           float_____________________________{f}");
            Console.WriteLine($"           double____________________________{z}");
            Console.WriteLine($"           decimal___________________________{p}");
            Console.WriteLine($"           bool______________________________{n}");
            Console.WriteLine($"           char______________________________{h}");
            Console.WriteLine($"           string____________________________{t}");
            Console.WriteLine($"           int?______________________________{inul}");
            Console.WriteLine($"           object____________________________{obj}");
            Console.ReadLine();

        }
    }
}
