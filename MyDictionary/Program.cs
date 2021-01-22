using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> yasisim = new MyDictionary<int, string>();
            yasisim .Add(19, "Enes");
            yasisim .Add(10, "Esmanur");
            yasisim .Add(7, "Yusuf");

            foreach (var yas in yasisim .GetKeys)
            {
                Console.WriteLine(yas);
            }
            foreach (var isim in yasisim.GetValues)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine(yasisim .Length);
            Console.ReadLine();
        }
    }
}
