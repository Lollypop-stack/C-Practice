using System;
using System.Collections.Generic; //для коллекций типо массивов и списков
using System.IO; //для работы с файлами (создание, запись, закрытие и считывание)
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
                    Console.WriteLine("OH NO, NIce LER -_-");
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


            /* Одномерные Массивы данных 
            int[] iv = new int[4];
            iv[0] = 4231231;
            iv[1] = 42311;
            iv[2] = 12;
            iv[3] = 0;
            Console.WriteLine(iv[2]);

            Random random = new Random();
            byte[] awp = new byte[10];
            short sum = 0;
            for (byte i = 0; i < awp.Length; i++)
            {
                awp[i] = Convert.ToByte(random.Next(12, 123));
                sum += awp[i];
                Console.WriteLine(awp[i]);
            }
            Console.WriteLine(sum);*/

            // Многомерные массивы данных
            /*int[,] symb = new int[4, 3];
            byte[,] huysosethr = new byte[,]
            {
                {1,2,3},
                {1,2,3},
                {1,2,3}
            };
            symb[0, 0] = 'a';
            Random ran = new Random();
            for (int i = 0; i < symb.GetLength(0); i++)
            {
                for (int a = 0; a < symb.GetLength(1); a++)
                {
                    symb[i, a] = ran.Next(0, 14);
                    Console.Write(symb[i, a] + " |");
                }
                Console.Write("\n");
            }*/

            /* Цикл foreach для работы с массивами
            short[,] nums =
            {
                {12,2,1,12,2},
                {6,2,4,2,123},
                {1,2,16,15,2},
                {11,2,13,34,122}
            };
            foreach (short el in nums)
                Console.Write(el); 
            List<int> nazvanie = [3, 5, 6];
            List<string> texe = ["nina", "nana", "nunu"];
            List<int> asd = new List<int>() { 1, 1, 1, 1, 1, 1 };
            // foreach (int el in asd)
            // {
            //     Console.WriteLine(el);
            // }
            texe.Add(Convert.ToString(44));
            nazvanie.Add(23);
            texe.Add(Convert.ToString(3));
            //    Методы для списков: 
            nazvanie.Add(15);
            asd.Remove(1);
            texe.Sort();
            texe.Reverse();
            // texe.Find("nuna");
            string? e = texe.Find(e => e.StartsWith("n"));
            Console.WriteLine(e);
            // foreach (string el in texe)
            // {
            //     Console.WriteLine(el);
            // } */


            /* Пробный вызов функции из мейна
            Console.WriteLine("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш результат после сложения: ");
            calc(first, second); */

            /* Запись результата ретёрна в значение для дальнейшего использования
            int a = 9, b = 10;
            int r = Summ(a, b);
            Console.WriteLine(r.ToString) - конвертация в текстовый формат;
            Console.WriteLine(r); */

            /* 
            List<int> list = [1, 123, 123, 45, 6, 8, 34, -213, -123, -9]; - динамическая коллекция
            int[] nums = { 123, 123, 123, 123, 123, 12 }; - массив
            // int result = ListSumm(list);
            int result = ListSumm2(nums);
            Console.WriteLine(result); */

            // array.Length → поле массива
            // list.Count → свойство списка

            /* Работа с файлами и строками
            string word = "nice";
            word += "!!";

            // char[] sym = { 'n', 'i', 'g', 'g', 'a' };
            // Console.WriteLine(word.Length);
            // string a = String.Concat(word, "!");
            // Console.WriteLine(a);
            List<char> letters = word.ToList();
            letters.Reverse();
            string naword = new string(letters.ToArray());
            Console.WriteLine(String.Compare(Convert.ToString(naword), "nice!!")); */
            /* Если имеется полное сходство -> 0
               Имеется сравнимое слово, но либо не тот регистр либо лишний символ (реверс приводит к -1) -> -1
               Нет сходства в целом (возможно имеются схожие символы не в том порядке) -> 1*/


            /* //  разбиение по символу 
            string STnames = "Biba,Boda, Buba";
            List<string> names = STnames
                .Split(',')
                .Select(x => x.Trim()) // удаление Всех пробелов
                .ToList();
            string a = String.Join(" ", names);
            // char[] chars = STnames.ToCharArray(); - работает только со строками
            // foreach (string name in names)
            //     Console.WriteLine(name);

            ToArray()   List → array
            ToCharArray()   string → char[]
            Split() string → string[] по разделителю
            // Также все методы со строками создают новую строку и поэтому требуют записи результата в новую переменную
            Console.WriteLine(a.Substring(0, a.Length - 1)); // обрезает основной кусок от последнего элемента */

            /* Создание, запись и чтение файла через 
            библиотеку System.IO c созданием изолированной среды для работы*/

            /* Создание файла с собственным текстом, введенным от пользователя   
             Console.Write("Введите текст для помещения в новый файл: ");
            string text = Console.ReadLine();
            using (FileStream stream = new FileStream("File.txt", FileMode.OpenOrCreate))
            {
                byte[] arr = System.Text.Encoding.Default.GetBytes(text);

                stream.Write(arr, 0, arr.Length);
            } */
            /* 
            Чтение файла
            using (FileStream stream1 = File.OpenRead("File.txt"))
            {
                byte[] arr1 = new byte[stream1.Length];
                stream1.Read(arr1, 0, arr1.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(arr1);
                Console.WriteLine(textFromFile);
            } */
        }
        /* Создание функций (методов класса)
          Невозвратимая функция
        
        public static void calc(int a, int b)
        {
            Console.WriteLine(a + b);
        }
           Возвратимая функция
        // public static int ListSumm(List<int> x)
        // {
        //     int basis = 0;
        //     foreach (int a in x)
        //     {
        //         basis += a;
        //     }
        //     return basis;
        // }
        public static int ListSumm2(int[] x)
        {
            int basis = 0;
            foreach (int a in x)
            {
                basis += a;
            }
            return basis;
        } */
    }
}