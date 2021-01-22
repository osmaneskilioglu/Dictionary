using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Enes");
            isimler.Add("Yusuf");
            isimler.Add("Esmanur");
            Console.WriteLine(isimler.Lenght);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.ReadLine();
        }
    }
}
