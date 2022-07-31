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
            float gold;
            float sulfur;
            float diamonds;
            float goldToSulfur = 1000;
            float sulfurToGold = 1f/800;
            float goldToDiamonds = 2000;
            float diamondsToGold = 1f/1600;
            float sulfurToDiamonds = 2;
            float diamondsToSulfur = 1f/1;
            int valueConvert;
            string goldName = "золото";
            string sulfurName = "серу";
            string diamondName = "алмаз";
            string choice;
            bool endConvert = false;

            Console.WriteLine("Добро пожаловать в мою лавку! Здесь вы можете:");
            Console.WriteLine("1. Обменять " + goldName + " на " + sulfurName + " по курсу: " + goldToSulfur);
            Console.WriteLine("2. Обменять " + sulfurName + " на " + goldName + " по курсу: " + sulfurToGold);
            Console.WriteLine("3. Обменять " + goldName + " на " + diamondName + " по курсу: " + goldToDiamonds);
            Console.WriteLine("4. Обменять " + diamondName + " на " + goldName + " по курсу: " + diamondsToGold);
            Console.WriteLine("5. Обменять " + sulfurName + " на " + diamondName + " по курсу: " + sulfurToDiamonds);
            Console.WriteLine("6. Обменять " + diamondName + " на " + sulfurName + " по курсу: " + diamondsToSulfur);
            Console.WriteLine("Введите, сколько у Вас валюты:");
            Console.Write("Золота: ");
            gold = Convert.ToSingle(Console.ReadLine());
            Console.Write("Серы: ");
            sulfur = Convert.ToSingle(Console.ReadLine());
            Console.Write("Алмазов: ");
            diamonds = Convert.ToSingle(Console.ReadLine());

            while (endConvert==false)
            {
                Console.Clear();
                Console.WriteLine("У Вас: ");
                Console.WriteLine();
                Console.WriteLine(gold + " золота");
                Console.WriteLine(sulfur + " серы");
                Console.WriteLine(diamonds + " алмазов");
                Console.WriteLine();
                Console.WriteLine("1. Обменять " + goldName + " на " + sulfurName + " по курсу: " + goldToSulfur);
                Console.WriteLine("2. Обменять " + sulfurName + " на " + goldName + " по курсу: " + sulfurToGold);
                Console.WriteLine("3. Обменять " + goldName + " на " + diamondName + " по курсу: " + goldToDiamonds);
                Console.WriteLine("4. Обменять " + diamondName + " на " + goldName + " по курсу: " + diamondsToGold);
                Console.WriteLine("5. Обменять " + sulfurName + " на " + diamondName + " по курсу: " + sulfurToDiamonds);
                Console.WriteLine("6. Обменять " + diamondName + " на " + sulfurName + " по курсу: " + diamondsToSulfur);
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
                            gold += valueConvert * (1/sulfurToGold);
                            sulfur -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * (1/sulfurToGold)) + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert * goldToDiamonds > gold)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять серу на золото в моем магазине!");
                        }
                        else
                        {
                            gold -= valueConvert * goldToDiamonds;
                            diamonds += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " алмазов!");
                        }

                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("Сколько Вы хотите продать алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert > diamonds)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять серу на алмазы в моем магазине!");
                        }
                        else
                        {
                            gold += valueConvert * (1/diamondsToGold);
                            diamonds -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * (1/diamondsToGold)) + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert * sulfurToDiamonds > sulfur)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять золото на серу в моем магазине!");
                        }
                        else
                        {
                            sulfur -= valueConvert * sulfurToDiamonds;
                            diamonds += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " алмазов!");
                        }

                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Сколько Вы хотите продать алмазов?: ");
                        valueConvert = Convert.ToInt32(Console.ReadLine());

                        if (valueConvert > diamonds)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять золото на алмазы в моем магазине!");
                        }
                        else
                        {
                            sulfur += valueConvert * (1/diamondsToSulfur);
                            diamonds -= valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + (valueConvert * (1/diamondsToSulfur)) + " серы!");
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