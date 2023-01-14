//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
static void Func(int n)
        {
            if(n != 0)
            {
                Console.WriteLine(n);
                Func(n - 1);
            }
        }
        
        

            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Func(n);

            Console.ReadKey(true);
       