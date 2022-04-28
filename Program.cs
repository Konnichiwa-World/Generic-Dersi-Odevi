using System;
using System.Collections.Generic;

namespace generickoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>alanListesi = new List<int>();

            System.Console.WriteLine("2 adet uzunluk gir ve oluşacak küp alanlarinin farkini gor:");
            Int32 x =Int32.Parse(Console.ReadLine());
            Int32 y =Int32.Parse(Console.ReadLine());
            int a= x*x*x;
            alanListesi.Add(a);
            int b= y*y*y;
            alanListesi.Add(b);
            foreach(var alan in alanListesi)
            {System.Console.WriteLine(Math.Abs(alanListesi[0]-alanListesi[1])); }

            List<int>cemberListesi = new List<int>();

            System.Console.WriteLine("2 adet uzunluk gir ve oluşacak daire alanlarinin farkini gor:");
            Int32 c =Int32.Parse(Console.ReadLine());
            Int32 d =Int32.Parse(Console.ReadLine());
            int e= c*c;
            cemberListesi.Add(e);
            int f= d*d;
            cemberListesi.Add(d);
            foreach(var cember in cemberListesi){System.Console.WriteLine(Math.Abs((e-f)*Math.PI));}
        }
    }
}
