using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "  Bilim Aşkına Açık Arttırım";
            string sonuc;
            string[] sonucDizi;
            char[] sonucCharDizi;
            int sonucSayi;

            sonuc = metin.Replace('a', 'X');
            sonuc = metin.Replace('A', 'X');
            sonuc = metin.Remove(7);
            sonuc = metin.Remove(7, 2);
            sonuc = metin.Substring(8);
            sonuc = metin.Substring(8, 2);
            sonuc = metin.Trim();
            sonucDizi = metin.Split('A');
            sonucDizi = metin.Split(new char[] { 'l', 'a' });
            sonuc = string.Format("Çalıştığım şirket : {0}", metin);
            sonuc = metin.ToLower();
            sonuc = metin.ToUpper();
            sonucCharDizi = metin.ToCharArray();
            sonucSayi = metin.Length;
        }
    }
}
