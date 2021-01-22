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

            for (int i = 0; i < yasisim.Length; i++)
            {
                Console.WriteLine("Yaş:" + yasisim.GetKeys[i] +" "+"İsim:" + yasisim.GetValues[i]);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine(yasisim .Length);
            Console.ReadLine();
        }
    }
}
