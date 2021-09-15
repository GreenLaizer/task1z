using System;

namespace project03._09._2021
{

    class MyException : Exception
    {
        public int value;
        public MyException(string message, int value) : base(message)
        {
            this.value = value;
        }
    }
    class Program
    {
        static void String()
        {
            try
            {
                Console.Write("Введите строку: ");
                string message = Console.ReadLine();
                if (message.Length > 6)
                {
                    throw new MyException("Длина строки больше 6 символов", 100);
                }
            }
            catch (MyException e)
            {
                Console.WriteLine($"Ошибка: {e.Message} {e.value}");
            }
        }

        static void DivideZero()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }


            catch (DivideByZeroException)
            {

                Console.WriteLine("Деление на ноль не допустимо");

            }

        }



        static void IndexOutOfRange()
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Индекс вне границы массива");

            }

        }

        static void StackOverFlowEx(int i)
        {
            try
            {
                Console.WriteLine(i);
                i++;
                StackOverFlowEx(i);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Стек переполнен");

            }


        }

        class X
        {
            int x;
            public X(int a)
            {
                x = a;
            }
            public int Add(X o)
            {
                return x + o.x;
            }
        }
        class Nr
        {
            public void NullReferenceEx()
            {
                X p = new X(10);
                X q = null;

                int val;
                try
                {
                    val = p.Add(q);

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Исключение nullrefrenceException!");
                    Console.WriteLine("Исправление ошибки...\n");

                    q = new X(9);
                    val = p.Add(q);

                }
                Console.WriteLine("Значение val равно {0}", val);
            }
        }

        static void Main(string[] args)
        {
            //Nr n = new Nr();
            //n.NullReferenceEx();
            //String();
            //DivideZero();
            //IndexOutOfRange();
            //StackOverFlowEx(0);



        }
    }
}
