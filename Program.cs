int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода: ");
    Console.WriteLine("1. Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
    Console.WriteLine("2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
                /* Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
                 N = 5. -> "5, 4, 3, 2, 1"
                N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"   */
                        
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            NaturalToLow(number, count);


            void NaturalToLow(int n, int count)
            {
                if (count > n)
                {
                    return;
                }
                else
                {
                    NaturalToLow(n, count + 1);
                    Console.Write(count + " ");
                }
            }
            break;


        case 2:
            /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30 */

            Console.Write("Введите число M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            SumFromMToN(M, N);
                
            void SumFromMToN(int M, int N)
            {                        
                Console.Write(SumMN(M - 1, N));
            }
                    
            int SumMN(int M, int N)
            {
                int res = M;
                if (M == N)
                return 0;
                else
                {
                    M++;
                    res = M + SumMN(M, N);
                    return res;
                }
            }

            break;
        case 3:
            /*  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            m = 2, n = 3 -> A(m,n) = 9
            m = 3, n = 2 -> A(m,n) = 29 */
                    
            Console.Write("Введите число M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            AkkermanFunction(m,n);

            void AkkermanFunction(int m, int n)
            {
                Console.Write(Akkerman(m, n)); 
            }

            int Akkerman(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }
                else if (n == 0 && m > 0)
                {
                    return Akkerman(m - 1, 1);
                }
                else
                {
                    return (Akkerman(m - 1, Akkerman(m, n - 1)));
                }
            }

 
            break;
    }
}