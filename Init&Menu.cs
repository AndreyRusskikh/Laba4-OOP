using NodeDef;

namespace Laba2_Alg
{
    internal class Init_Menu
    {
        public static int ReadInt(string message, Func<int, bool> validator)
        {
            int result;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out result) || !validator(result));
            return result;
        }


        public static void ShowStandart()

        {
            NodeWork<int> queue = new NodeWork<int>();

            queue.Add(18);
            queue.Add(5);
            queue.Add(45);
            queue.Add(56);
            queue.Add(78);
            queue.Add(34);
            queue.Add(27);
            queue.Add(337);
            queue.Add(2);
            queue.Add(8);
            queue.AddToFront(4);
            queue.AddToFront(2);

            Console.WriteLine("\nОригинальная очередь:");
            queue.Display();

            Console.WriteLine("\nУдаление первых двух элементов очереди:");
            queue.RemoveFromFront();
            queue.RemoveFromFront();
            queue.Display();

            Console.WriteLine("\nСмена первого и последнего элемента:");
            queue.SwapFirstAndEndEl();
            queue.Display();

            Console.WriteLine("\nРеверс очереди:");
            queue.Reverse();
            queue.Display();


            Console.WriteLine("\nЕсть ли элемент?");
            int choiceEl = 56;
            Console.WriteLine(queue.Equal(choiceEl));

            Console.WriteLine("\nОчистка очереди");
            queue.ClearQueue();

            Console.WriteLine("\nВывод очереди:");
            queue.Display();

        }
        public static void ShowOnChoice(int choice, NodeWork<int> queue)
        {
            

            if (choice == 2)
            {
                choice = ReadInt("Добавить число:", x => x < 0 || x >= 0);
                Console.WriteLine();
                queue.Add(choice);
                queue.Display();


            }
            else if (choice == 3)
            {
                Console.WriteLine();
                queue.RemoveFromFront();
                queue.Display();

            }
            else if (choice == 4)
            {
                Console.WriteLine();
                queue.SwapFirstAndEndEl();
                queue.Display();


            }
            else if (choice == 5)
            {
                Console.WriteLine();
                queue.Reverse();
                queue.Display();

            }
            else if (choice == 6)
            {
                int choiceEl = ReadInt("Принадлежит ли очереди элемент:", x => x >= 0 || x < 0);
                Console.WriteLine(queue.Equal(choiceEl));

            }
            else if (choice == 7)
            {
                Console.WriteLine();
                queue.ClearQueue();
                queue.Display();

            }
            else
            {
                queue.Display();
            }
        }


        public static void Menu(NodeWork<int> list)
        {
            int choice;

            Console.WriteLine("1 - Показ стандартных функций работы со связным списком");
            Console.WriteLine("2 - Добавление элемента очереди");
            Console.WriteLine("3 - Удаление элемента очереди");
            Console.WriteLine("4 - Поменять местами первый и последний элемент очереди");
            Console.WriteLine("5 - Разворот очереди");
            Console.WriteLine("6 - Принадлежит ли элемент очереди");
            Console.WriteLine("7 - Очищение очереди");
            Console.WriteLine("8 - Вывод очереди");


            while (true)
            {
                choice = ReadInt("\nВыберите необходимое действие: ", x => x > 0 && x < 14);
                switch (choice)
                {
                    case 1:
                        ShowStandart();
                        break;
                    case 2:
                        ShowOnChoice(2, list);
                        break;
                    case 3:
                        ShowOnChoice(3, list);
                        break;
                    case 4:
                        ShowOnChoice(4, list);
                        break;
                    case 5:
                        ShowOnChoice(5, list);
                        break;
                    case 6:
                        ShowOnChoice(6, list);
                        break;
                    case 7:
                        ShowOnChoice(7, list);
                        break;
                    case 8:
                        ShowOnChoice(8, list);
                        break;

                }


               /* Console.WriteLine("\nПродолжить работу?");
                Console.WriteLine("1 - Продолжить");
                Console.WriteLine("2 - Продолжить и очистить консоль");
                Console.WriteLine("3 - Завершение работы");
                choice = ReadInt("Выберите необходимое действие: ", x => x > 0 && x < 4);

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:

                        return;
                }*/

            }

        }

    }
}
