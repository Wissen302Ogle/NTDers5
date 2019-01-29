using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinMethods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamSayi;
            double kusuratliSayi;

            tamSayi = 5;
            kusuratliSayi = Math.Sqrt(tamSayi);
            kusuratliSayi = Math.Pow(tamSayi,2);

            kusuratliSayi = 23.495;
            kusuratliSayi = Math.Ceiling(kusuratliSayi);

            tamSayi = -4;
            tamSayi = Math.Abs(tamSayi);
        }
    }
}
