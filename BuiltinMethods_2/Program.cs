using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BuiltinMethods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1, date2;
            date1 = new DateTime(2016, 1, 1, 01, 12, 00);
            date1 = DateTime.Now;
            date1 = new DateTime(2016, 1, 1);
            date2 = new DateTime(1990, 4, 12);
            date1 = date1.Add(TimeSpan.FromDays(20));
            date1 = new DateTime(2016, 1, 1);
            date1 = date1.AddDays(20);
            int a = date1.Subtract(date2).Days;
           
            
        }
    }
}
