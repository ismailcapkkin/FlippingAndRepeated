using System;

namespace Flip_Repeated
{
    class Program
    {
        public static void Main()
        {
 
            FlippingBits fp = new FlippingBits();
            RepeatedString rs = new RepeatedString();
            bool control = fp.flippingMehtod();
            if(control == true)
            {
                rs.repeatedMethod();
            }
        }
    }
}