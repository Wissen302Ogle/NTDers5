using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialwithWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 1;
            //int i = 1;
            Console.Write("Bir sayı girin =");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int i = sayi;
            while(sayi!=1)
            {
                sonuc = sonuc * sayi;
                sayi--;
                
            }
            Console.Write("Girilen sayı ={0} \nFaktöriyeli= {1}", i, sonuc);
            Console.ReadKey();

        }
        
    }
}
