using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubemetots
{
    class Program
    {
        static void Main(string[] args)
        {
            //string yazilacakmetin = "merhaba türkiyem ";
            //metinyaz(yazilacakmetin);

            int sonuc = topla(5,15);
            Console.Write("TOPLAMA SONUCU:{0}", sonuc);
            Console.ReadKey();
        }

        //public static void metinyaz (string metin)
        //  {
        //    for (int i = 1; i <=5; i++)
        //    {
        //        Console.WriteLine(metin);
        //    }
        //  }

        private static int topla(int s1,int s2)
        {
            return (s1+s2);
        }
    }
}
