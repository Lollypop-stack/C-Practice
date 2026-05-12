using System;

namespace project
{
    class Pervui
    {
        static void Main()
        {
            /*
            Операции с вещественным числом, полученным от пользователя 
            с преобразованием после получения в необходимый формат

            Console.Write("Введите число с точкой: ");
            float UsersInput = float.Parse(Console.ReadLine());
            float result = UsersInput + 10f - 10f * 10f % 10f;
            Console.WriteLine("Сумма с 10: " + result); */

            /*
            Операции с математикой и т.п.

            Console.Write("радиус для площади :");
            float Rad = float.Parse(Console.ReadLine());
            double RadS = Math.Round(Math.Pow(Rad, 2) * Math.PI, 1);
            Console.WriteLine("Площадь круга с радиусом {0} после округления: {1}", Rad, RadS);*/

            /* Мини программка (типо тест)
            
            Console.Write("Напишите логин :");
            string login = Console.ReadLine();
            if(login == "Admin")
            {
                Console.Write("User`s name: ");
                string UserName = Console.ReadLine();
                Console.Write("User`s age: ");
                short UserAge = short.Parse(Console.ReadLine());
                Console.WriteLine("User`s name is {0} and his age is {1}", UserName, UserAge);
            }
            else
            {
                Console.WriteLine("Try one more time pupuppupuu");
            }*/

            /*Switch-case 
            
            Проверка только одной переменной на значение (только факт равенства)
            */

            /* 
            short UserInput = Convert.ToInt16(Console.ReadLine());
            switch (UserInput)
            {
                case 5:
                    Console.WriteLine("Ebat negrou 5");
                    break;
                case 6:
                    Console.WriteLine("Ebat negrou 6");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Ebat negrou 7");
                    break;
                default:
                    Console.WriteLine("Soryan bro, negry ne umerli (");
                    break;*/
            /*Циклы и операторы for while dop while*/
            /* for (byte i = 0; i <= 10; i++)
                Console.WriteLine("Elem: {0}", i);



            for (byte i = 0; i <= 10; i++)
            {
                Console.WriteLine("Elem: {0}", i);
            } */
            /* bool isNihher = true;
            while (isNihher)
            {
                string ques = Console.ReadLine();
                if (ques == "dih")
                    isNihher = false;
            } 
            
            do{
            }while();
            */
            /* bool stopper = true;
            while (stopper)
            {
                int shirina = Convert.ToInt32(Console.ReadLine());
                if (shirina == 1488)
                {
                    Console.WriteLine("OH NO, NIGGA KITLER -_-");
                    break;
                }
                else
                {
                    char elochkaRight = '>';
                    char elochkaLeft = '<';
                    int SideAmount = (shirina - 1) / 2;
                    int probely = SideAmount - 1;
                    int symboly = 0;

                    // Елка 
                    for (int i = 0; i < SideAmount; i++)
                    {
                        for (int a = probely; a > 0; a--)
                        {
                            Console.Write(" ");
                        }

                        for (int a = 0; a <= symboly; a++)
                        {
                            Console.Write(elochkaLeft);
                        }

                        Console.Write("|");

                        for (int a = 0; a <= symboly; a++)
                        {
                            Console.Write(elochkaRight);
                        }

                        for (int a = probely; a > 0; a--)
                        {
                            Console.Write(" ");
                        }

                        probely--;
                        symboly++;
                        Console.Write("\n");
                    }

                    int probely2 = SideAmount - 1;
                    double stwolDlin = shirina * 0.2;
                    double stwolShir = shirina * 0.1;
                    // Ствол 
                    if (shirina % 2 != 0)
                    {
                        for (int i = 0; i < stwolDlin - (35 % stwolDlin); i++)
                        {
                            for (int a = 0; a < probely2 - stwolShir / 2; a++)
                            {
                                Console.Write(" ");
                            }
                            for (int a = 0; a < stwolShir / 2; a++)
                            {
                                Console.Write("|");
                            }
                            Console.Write("|");
                            for (int a = 0; a < stwolShir / 2; a++)
                            {
                                Console.Write("|");
                            }
                            for (int a = 0; a < probely2 - stwolShir / 2; a++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < stwolDlin - (35 % stwolDlin); i++)
                        {
                            for (int a = 0; a < probely2 - stwolShir / 2; a++)
                            {
                                Console.Write(" ");
                            }
                            for (int a = 0; a < stwolShir / 2; a++)
                            {
                                Console.Write("|");
                            }
                            Console.Write("|");
                            for (int a = 0; a < stwolShir / 2; a++)
                            {
                                Console.Write("|");
                            }
                            for (int a = 0; a < probely2 - stwolShir / 2; a++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("\n");
                        }
                    }
                }
            } */


            /* Массивы данных */
            Console.WriteLine("Hui");
        }
    }
}