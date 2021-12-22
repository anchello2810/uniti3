using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] agrs)
        {
            string name1;
            string name2;
            Random randomize = new Random();
            int gameNumber = randomize.Next(12, 121);
            Console.WriteLine("Привет! Предлагаю сыграть тебе в игру." +
              "\nРобот Пухля испек пиццу произвольного диаметра." +
              "\nИгроки по очереди едят по кусочку разной величины и тот, кто съест последний кусочек выиграл." +
              "\nЕсли хочешь сыграть нажми любую клавишу");
            Console.ReadKey();
            Console.Write("\n Игрок если хочешь сыграть с другом, то нажми 1." +
            "\n Если хочешь завести нового друга и сыграть с Пухлей нажми 2." +
            "\n");
            int z = int.Parse(Console.ReadLine());


            Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
            if (z == 1)
            {
                Console.Write("\n Выберите уровень сложности." +
                "\n Для выбора простого уровня нажмите 1." +
                "\n Для выбора сложного уровня нажмите 2." +
                 "\n");
                int level = int.Parse(Console.ReadLine());
                if (level == 1)
                {
                    Console.WriteLine("\n Игрок 1 введите имя: ");
                    name1 = Console.ReadLine();
                    Console.WriteLine("\n Игрок 2 введите имя: ");
                    name2 = Console.ReadLine();
                    for (; gameNumber > 0;)
                    {
                        Console.Write($"{name1}, введите число от 1 до 4\n" +
                            $"\n Ваше число: ");
                        int x = int.Parse(Console.ReadLine());
                        if (x >= 1 && x <= 4)
                        {
                            Console.WriteLine($"Итоговое число: {gameNumber = gameNumber - x}");
                        }
                        else
                        {
                            Console.WriteLine("Неверное число, ход переходит к игроку 2");

                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Победа!");
                            Console.Write("Понравилось?" +
                            "Для реванша нажмите 1.");
                            int end = int.Parse(Console.ReadLine());
                            if (end == 1)
                            {
                                gameNumber = randomize.Next(12, 121);
                                Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
                            }
                        }
                    }
                    Console.Write($"{name2}, введите число от 1 до 4\n" +
                       $"\n Число {name2}: ");
                    int y = int.Parse(Console.ReadLine());
                    if (y >= 1 && y <= 4)
                    {
                        Console.WriteLine($"Итоговое число: {gameNumber = gameNumber - y}");
                    }
                    else
                    {
                        Console.WriteLine("Неверное число, ход переходит к игроку 1");
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"Победа!");
                        Console.Write("Понравилось?" +
                        "Для реванша нажмите 1.");
                        int end = int.Parse(Console.ReadLine());
                        if (end == 1)
                        {
                            gameNumber = randomize.Next(12, 121);
                            Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
                        }
                    }
                }
                if (level == 2)
                {
                    Console.WriteLine("\n Игрок 1 введите имя: ");
                    name1 = Console.ReadLine();
                    Console.WriteLine("\n Игрок 2 введите имя: ");
                    name2 = Console.ReadLine();
                    while (gameNumber > 0)
                    {
                        Console.Write($"{name1},введите число до 10\n" +
                            $"\n Ваше число: ");
                        int x = int.Parse(Console.ReadLine());
                        if (x < 10)
                        {
                            Console.WriteLine($"Итоговое число: {gameNumber = gameNumber - x}");
                        }
                        else
                        {
                            Console.WriteLine("Неверное число, ход переходит к игроку 2");

                        }
                        if (gameNumber == 0)
                        {
                            Console.WriteLine($"Победа!");
                            Console.Write("Понравилось?" +
                            "Для реванша нажмите 1." +
                            "\n");
                            int end = int.Parse(Console.ReadLine());
                            if (end == 1)
                            {
                                gameNumber = randomize.Next(12, 121);
                                Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");

                            }
                        }
                    }

                    Console.Write($"{name2}, введите число до 10\n" +
                           $"\n Число {name2}: ");

                    int y = int.Parse(Console.ReadLine());
                    if (y < 10)
                    {
                        Console.WriteLine($"Итоговое число: {gameNumber = gameNumber - y}");
                    }
                    else
                    {
                        Console.WriteLine("Неверное число, ход переходит к игроку 1");
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"Победа!");
                        Console.Write("Понравилось?" +
                         "Для реванша нажмите 1.");
                        int end = int.Parse(Console.ReadLine());
                        if (end == 1)
                        {
                            gameNumber = randomize.Next(12, 121);
                            Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
                        }
                    }
                }
            }
                
            if (z == 2)
            {
                Console.WriteLine("\n Игрок 1 введите имя: ");
                name1 = Console.ReadLine();
                while (gameNumber != 0)
                {
                    Console.Write($"{name1}, введите число от 1 до 4\n" +
                      $"\n Ваше число: ");
                    int x = int.Parse(Console.ReadLine());
                    if (x >= 1 && x <= 4)
                    {
                        Console.WriteLine($"Итоговое число {gameNumber = gameNumber - x}");
                    }
                    else
                    {
                        Console.WriteLine("Неверное число, ход переходит к Пухле");
                    }
                    if (gameNumber == 0)
                    {
                        Console.WriteLine($"Победа!");
                        Console.Write("Понравилось?" +
                        "Для реванша нажмите 1.");
                        int end = int.Parse(Console.ReadLine());
                        if (end == 1)
                        {
                            gameNumber = randomize.Next(12, 121);
                            Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
                        }
                    }
                }
                Random randomize1 = new Random();
                    int robot = randomize.Next(1, 5);
                    Console.Write($"Число Пухли: { robot }" +
                        $"\n");
                    if (robot >= 1 && robot <= 4)
                    {
                        Console.WriteLine($"Итоговое число: {gameNumber = gameNumber - robot}");
                    }
                    else
                    {
                        Console.WriteLine("Неверное число, ход переходит к игроку");
                    }
                if (gameNumber == 0)
                {
                    Console.WriteLine($"Победа!");
                    Console.Write("Понравилось?" +
                   "Для реванша нажмите 1.");
                    int end = int.Parse(Console.ReadLine());
                    if (end == 1)
                    {
                        gameNumber = randomize.Next(12, 121);
                        Console.WriteLine($"\n Диаметр пиццы: {gameNumber} , начнем игру");
                    }
                }
            }
              Console.ReadKey();
        }
   } }  