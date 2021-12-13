using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = MethodAsync().Result;
            Console.WriteLine($"Факториал  равен {f}");
            Console.ReadKey();
        }
        static int Factorial()
        {
            Console.WriteLine("Введите число, факториал которого необходимо вычислить:");


            int factorial = 1;
            try
            {

                int n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {

                    for (int i = 1; i <= n; i++)
                    {
                        factorial *= i;

                    }
                }
                else if (n == 0)
                {
                    return 1;
                }
                else if (n < 0)
                {
                    Console.WriteLine("Нельзя вычислить факториал отрицательного числа.");
                    return 0;
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }

            return (factorial);
        }
        static async Task<int> MethodAsync()
        {

            int result = await Task<int>.Run(() => Factorial());
            return result;
        }
    }
}
