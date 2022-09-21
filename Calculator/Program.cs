using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный ккорень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");
            int action = Convert.ToInt32(Console.ReadLine());
            int a;
            int b;
            int c = 1;
            {

                while ((action > 0) && (action < 9))
                {
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("Введите 2 числа");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(a + b);
                            break;
                        case 2:
                            Console.WriteLine("Введите уменьшаемое");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите вычитаемое");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(a - b);
                            break;
                        case 3:
                            Console.WriteLine("Введите 2 числа");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(a * b);
                            break;
                        case 4:
                            Console.WriteLine("Введите делимое");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите делитель");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(a / b);
                            break;
                        case 5:
                            Console.WriteLine("Введие число");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите степень");
                            b = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= b; i++)
                            {
                                c = c * a;
                                Console.WriteLine(c);
                            }
                            Console.WriteLine(c);
                            break;
                        case 6:
                            Console.WriteLine("Введите число, из которого хотите извлечь квадратный корень");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Math.Sqrt(a));
                            break;
                        case 7:
                            Console.WriteLine("Введите число, от которого хотите найти 1%");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Convert.ToDouble(a / 100));
                            break;
                        case 8:
                            Console.WriteLine("Введите число, факториал которого хотите узнать");
                            a = Convert.ToInt32(Console.ReadLine());
                            int fact = 1;
                            for (int x = 1; x <= a; x++)
                            {
                                fact *= x;
                            }
                            Console.WriteLine(fact);
                            break;
                    }
                  Console.WriteLine("Выберите действие");
                  action = Convert.ToInt32(Console.ReadLine());
                }
            } 
           if(action <= 0)
            {
                Console.WriteLine("ошибка");
            } else if (action == 9)
            {
                Console.WriteLine("Вы вышли из программы");
            }
        }
    }
}
