// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
static int Func(int n, int m)
        {
            int sum = n;
            if(n == m)
            {
                sum = m;
                
            }
            else
            {
                sum += Func(n - 1, m);
            }
            return sum;
        }
             int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Func(m,n));

            Console.ReadKey(true);
       