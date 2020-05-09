using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0 ile 10 arasında bir sayı giriniz: ");
            int deger = Convert.ToInt32(Console.ReadLine());
            if (deger > -1 && deger < 11)
            {
                if (deger == 5 || deger == 3)
                {
                    Console.Write("Tebrikler. İkramiye kazandınız.");
                }
                else if (deger >= 7)
                {
                    Console.Write("Şanslı gününüzdesiniz. Kaybettiniz.");
                }
                else
                {
                    Console.Write("Girdiğiniz değer istenilen aralıktadır.");
                }
            }
            else
            {
                Console.Write("Girdiğiniz sayı istenilen aralıkta değildir.");
            }
            Console.ReadKey();
        }
    }
}
// Kullanıcıdan alınan değer 0 ile 10 arasında ise mesaj veren program.