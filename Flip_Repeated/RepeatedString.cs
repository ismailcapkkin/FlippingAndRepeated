using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Flip_Repeated
{
    class RepeatedString : IRepeated
    {
        public void repeatedMethod()
        {

            Console.WriteLine("*****Repeated String***** Bir String Giriniz..");
            var s = ReadLine();
           
            
            while (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Boş bırakılamaz.. Tekrar deneyiniz.");
                s = Console.ReadLine();
            }
           
            Console.WriteLine("Tamsayı Giriniz..");

            var n = Console.ReadLine();
            Int64 val;
            while(!Int64.TryParse(n, out val))
            {
                Console.WriteLine("Tamsayı girmelisiniz.");
                n = Console.ReadLine();
            }
          
                var count = 0L;
            foreach (var letter in s)
            {
                if (letter == 'a' || letter == 'A')
                    count++;
            }

            var rep = val / s.Length;
            count *= rep;
            var offsetStringLength = val % s.Length;

            for (int i = 0; i < offsetStringLength; i++)
            {
                if (s[i] == 'a' || s[i] == 'A')
                    count++;
            }

            WriteLine( +count+ " tane a harfi içeriyor.");
        }

    }
}
