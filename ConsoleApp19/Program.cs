using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            //циклы

            ////с предусловием
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine();

            //i = 11;
            ////с предусловием
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 10);

            ////for
            //for (i = 0; i < 10; i++)
            //    Console.WriteLine(i);
            //Console.WriteLine("Введите число ");
            //int n;
            //double sum = 0.0;
            //Int32.TryParse(Console.ReadLine(), out n);
            //if (n > 0)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            Console.Write("1/" + i);
            //            sum += 1 / (double)i;
            //        }
            //        else
            //        {
            //            Console.Write(" - 1/" + i);
            //            sum -= 1 / (double)i;
            //            if (i < n)
            //                Console.Write(" + ");

            //        }

            //    }

            //    Console.Write(" = " + sum);
            //}
            //else
            //    Console.WriteLine("Нужно положительное число  и целое !!! ");

            //switch

            //int n;
            //Int32.TryParse(Console.ReadLine(), out n);

            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine($"Вы ввели {n}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Вы ввели {n}");
            //        break;
            //    default:
            //        Console.WriteLine("Вы ввели неизвестное число");
            //        break;
            //}

            // Console.Close() - закрыть окно приложения
            
            int move;
            double num1, num2, num3, step, x1, x2, D;

            Console.WriteLine("1.Сложить.");
            Console.WriteLine("2.Вычесть.");
            Console.WriteLine("3.Умножить.");
            Console.WriteLine("4.Разделить.");
            Console.WriteLine("5.Квадратный корень числа.");
            Console.WriteLine("6.Возведение числа в степень.");
            Console.WriteLine("7.Перевод числа в двоичную СС.");
            Console.WriteLine("8.Нахождение корней квадратного уравнения.");
            Console.WriteLine("0.Выход. ");

            int.TryParse(Console.ReadLine(), out move);
            while (move != 0)
            {
                Console.Write("Введите число: ");
                Double.TryParse(Console.ReadLine(), out num1);

                if ((move >= 1) && (move <= 4))
                {
                    Console.Write("Второе число: ");
                    Double.TryParse(Console.ReadLine(), out num2);

                    if (move == 1)
                    {
                        num1 += num2;
                    }

                    if (move == 2)
                    {
                        num1 -= num2;
                    }

                    if (move == 3)
                    {
                        num1 *= num2;
                    }

                    if (move == 4)
                    {
                        if (num2 == 0)
                        {
                            num1 = 0;
                            Console.WriteLine("num2 != 0");
                        }
                        else num1 /= num2;
                    }

                    Console.WriteLine(num1);
                }
                if ((move >= 5) && (move <= 7))
                {
                    if (move == 5)
                    {
                        num1 = Math.Sqrt(num1);
                        Console.WriteLine(num1);
                    }

                    if (move == 6)
                    {
                        Console.WriteLine("Какая степень числа?");
                        step = Convert.ToDouble(Console.ReadLine());
                        num1 = Math.Pow(num1, step);
                        Console.WriteLine(num1);
                    }

                    if (move == 7)
                    {
                        int mod;
                        int i = 0;
                        string result = "";

                        int inum = Convert.ToInt32(num1);
                        while (inum >= 1)
                        {
                            mod = inum % 2;
                            result += mod.ToString();
                            i++;
                            inum /= 2;
                        }

                        for (int count = result.Length; count > 0; count--)
                            Console.Write(result[count - 1]);

                        Console.WriteLine();
                    }
                }
                if (move == 8)
                {
                    Console.Write("Второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Третье число: ");
                    num3 = Convert.ToDouble(Console.ReadLine());

                    D = num2 * num2 - 4 * num1 * num3;
                    D = Math.Sqrt(D);
                    x1 = (-num2 + D) / (2 * num1);
                    x2 = (-num2 - D) / (2 * num1);

                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1.Сложить.");
                Console.WriteLine("2.Вычесть.");
                Console.WriteLine("3.Умножить.");
                Console.WriteLine("4.Разделить.");
                Console.WriteLine("5.Квадратный корень числа.");
                Console.WriteLine("6.Возведение числа в степень.");
                Console.WriteLine("7.Перевод числа в двоичную СС.");
                Console.WriteLine("8.Нахождение корней квадратного уравнения.");
                Console.WriteLine("0.Выход. ");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Выберите следующее действие. ");
                move = Convert.ToInt16(Console.ReadLine());

            }
            Console.Write("Окей ");
        }
    }
}
