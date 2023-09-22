//************************
//*Проверочная Работа №6 *
//*Поогудин Павел 2ИСП   *
//************************

//комбинации для проверки масти        0; от 1 до 4  включительно; символ
//комбинации для проверки номера карты 0; от 6 до 14 включительно; символ

using System;

namespace PR_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №6";
            Console.WriteLine("Здраствуйте!");
            

            try                                             //отмечаю часть кода как объект для обработки ошибок или очистки
            {
                int N, M;

                Console.Write("Введите номер карты = ");    //номер карты
                N = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите номер масти = ");    //номер масти
                M = Convert.ToInt32(Console.ReadLine());

                switch (N)                                  //множественный выбор
                {
                    case (6):                               //кейс команды при значении 6
                        Console.Write("Это карта шесть");
                        break;                              //конец кейса
                    case (7):
                        Console.Write("Это карта семь");
                        break;
                    case (8):
                        Console.Write("Это карта восемь");
                        break;
                    case (9):
                        Console.Write("Это карта девять");
                        break;
                    case (10):
                        Console.Write("Это карта десять");
                        break;
                    case (11):
                        Console.Write("Это карта валет");
                        break;
                    case (12):
                        Console.Write("Это карта дама");
                        break;
                    case (13):
                        Console.Write("Это карта король");
                        break;
                    case (14):
                        Console.Write("Это карта туз");
                        break;
                    default:
                        Console.Write("такого номера карты нет");
                        break;
                }
                switch (M)
                {
                    case (1):
                        Console.Write(" бубны");
                        break;
                    case (2):
                        Console.Write(" трефы");
                        break;
                    case (3):
                        Console.Write(" черви");
                        break;
                    case (4):
                        Console.Write(" пики");
                        break;
                    default:                    
                        Console.Write(" такой масти нет");
                        break;
                }
            }
            catch (Exception e)                             //вывод ошибки    //базовый класс при обнаружении ошибок
            {
                Console.WriteLine("Што-то пошло не так. Ошибка: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}