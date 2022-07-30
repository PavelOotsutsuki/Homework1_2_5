using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int sulfur;
            int diamond;
            int goldToSulfur = 1000;
            int sulfurToGold = 800;
            int goldToDiamond = 2000;
            int diamondToGold = 1600;
            int sulfurToDiamond = 2;
            int diamondToSulfur = 1;
            int valueConvert;
            string goldName = "золото";
            string sulfurName = "серу";
            string diamondName = "алмаз";
            string choice;
            bool endConvert = false;

            Console.WriteLine("Добро пожаловать в мою лавку! Здесь вы можете:");
            Console.WriteLine("1. Обменять " + goldName + " на " + sulfurName + " по курсу: " + goldToSulfur);
            Console.WriteLine("2. Обменять " + sulfurName + " на " + goldName + " по курсу: " + sulfurToGold);
            Console.WriteLine("3. Обменять " + goldName + " на " + diamondName + " по курсу: " + goldToDiamond);
            Console.WriteLine("4. Обменять " + diamondName + " на " + goldName + " по курсу: " + diamondToGold);
            Console.WriteLine("5. Обменять " + sulfurName + " на " + diamondName + " по курсу: " + sulfurToDiamond);
            Console.WriteLine("6. Обменять " + diamondName + " на " + sulfurName + " по курсу: " + diamondToSulfur);
            Console.WriteLine("Введите, сколько у Вас валюты:");
            Console.Write("Золота: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Серы: ");
            sulfur = Convert.ToInt32(Console.ReadLine());
            Console.Write("Алмазов: ");
            diamond = Convert.ToInt32(Console.ReadLine());

            while (endConvert==false)
            {
                Console.Clear();
                Console.WriteLine("У Вас: ");
                Console.WriteLine();
                Console.WriteLine(gold + " золота");
                Console.WriteLine(sulfur + " серы");
                Console.WriteLine(diamond + " алмазов");
                Console.WriteLine();
                Console.WriteLine("1. Обменять " + goldName + " на " + sulfurName + " по курсу: " + goldToSulfur);
                Console.WriteLine("2. Обменять " + sulfurName + " на " + goldName + " по курсу: " + sulfurToGold);
                Console.WriteLine("3. Обменять " + goldName + " на " + diamondName + " по курсу: " + goldToDiamond);
                Console.WriteLine("4. Обменять " + diamondName + " на " + goldName + " по курсу: " + diamondToGold);
                Console.WriteLine("5. Обменять " + sulfurName + " на " + diamondName + " по курсу: " + sulfurToDiamond);
                Console.WriteLine("6. Обменять " + diamondName + " на " + sulfurName + " по курсу: " + diamondToSulfur);
                Console.WriteLine("Exit. Покинуть лавку ");
                Console.WriteLine();
                Console.Write("Введите вариант обмена: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Сколько Вы хотите приобрести серы?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert*goldToSulfur>gold)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять алмазы на золото в моем магазине!");
                        }
                        else
                        {
                            gold -= valueConvert * goldToSulfur;
                            sulfur += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " серы!");
                        }

                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Сколько Вы хотите продать серы?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert > sulfur)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять алмазы на серу в моем магазине!");
                        }
                        else
                        {
                            gold += valueConvert * sulfurToGold;
                            sulfur -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * sulfurToGold) + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert * goldToDiamond > gold)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять серу на золото в моем магазине!");
                        }
                        else
                        {
                            gold -= valueConvert * goldToDiamond;
                            diamond += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " алмазов!");
                        }

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("Сколько Вы хотите продать алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert > diamond)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять серу на алмазы в моем магазине!");
                        }
                        else
                        {
                            gold += valueConvert * diamondToGold;
                            diamond -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * diamondToGold) + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert * sulfurToDiamond > sulfur)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять золото на серу в моем магазине!");
                        }
                        else
                        {
                            sulfur -= valueConvert * sulfurToDiamond;
                            diamond += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " алмазов!");
                        }

                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Сколько Вы хотите продать алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert > diamond)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять золото на алмазы в моем магазине!");
                        }
                        else
                        {
                            sulfur += valueConvert * diamondToSulfur;
                            diamond -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * diamondToSulfur) + " серы!");
                        }

                        Console.ReadKey();
                        break;
                    case "Exit":
                        Console.WriteLine("Приходите к нам ещё!");
                        endConvert = true;
                        break;
                    default:
                        Console.WriteLine("Такого варианта нет, попробуйте снова!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}