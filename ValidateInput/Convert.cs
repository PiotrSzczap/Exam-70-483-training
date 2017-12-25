using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateInput
{
    class ConvertTest
    {
        public static void ConvertNumbers()
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i); // Displays 23
        }

        public static void ConvertNull()
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i); // Displays 0
        }
    }
}
