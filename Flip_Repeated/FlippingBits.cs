using System;
using System.Collections.Generic;
using System.Text;

namespace Flip_Repeated
{
    class FlippingBits : IFlipping
    {
        public bool flippingMehtod()
        {
            Console.WriteLine("");
            Console.WriteLine("*****Flipping Bits***** 1 ile 100 arasında integer giriniz.");

            var input = Console.ReadLine();
            int value;
           

            while (!int.TryParse(input, out value))
            {
                Console.WriteLine("Lütfen integer giriniz");
                input = Console.ReadLine();
            }

            if(value >= 1 && value <= 100)
            {
                for (int i = 0; i < value; i++)
                {
                    long n = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine(fBits(n));
                }
                return true;
            }
            else
            {
                Console.WriteLine("1'den küçük ve 100'den büyük olamaz");
                return false;
            }

        }
        static long fBits(long N)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = (int)(N & 1);
                result += (uint)((1 - bit) << i);
                N >>= 1;
            }
            return result;


        }
    }
}
