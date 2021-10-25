using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;//число до которого будем находить простые числа
            int ty;
            Console.WriteLine("Введите начальное число ");
            ty = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последние число ");
            N = int.Parse(Console.ReadLine());//вводим N
            for (int i = ty; i <= N; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i.ToString() + ",");
                }
            }
        }
        //метод который определяет простое число или нет
        private static bool isSimple(int N)
        {
            bool tf = false;
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                {
                    tf = false;
                    break;
                }
                else
                {
                    tf = true;
                }
            }
            return tf;
        }
    }
}