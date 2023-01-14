// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static int Akk(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return Akk(n - 1, 1);
            else
                return Akk(n - 1, Akk(n, m - 1));
        }

        static void Main(string[] args)
        {

            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Akk(n,m));

            Console.ReadKey(true);
        }
    }
}
