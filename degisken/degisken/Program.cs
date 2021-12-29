using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi !");

            byte b = 1;            //1 byte
            short s = 2;           //2 byte
            int i = 4;             //4 byte
            long l = 8;            //8 byte

            float f = 0.4F;        // Tam sayı değilse sonua f koymak gerekir
            double d = 0.8;        //8 byte
            decimal de = 0.16M;    //16 byte  neden M :D
            double x = l + d;
            Console.WriteLine(x);

            char c = 'c';           //2 byte 
            string str = "ibrahim";   //Sınırsız
            bool b1 = true;
            bool b2 = false;


            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //DateTime stringe cevirip arasına . koyma
            string dt2 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt2);

            string hour = DateTime.Now.ToString("HH:MM");
            Console.WriteLine(hour);
        }
    }
}
