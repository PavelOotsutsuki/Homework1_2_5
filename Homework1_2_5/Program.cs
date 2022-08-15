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
            int oneSulfurToGold = 800;
            int oneDiamondToGold = 1600;
            int oneDiamondToSulfur = 1;
            float goldToSulfur = 1000;
            float sulfurToGold = 1f/oneSulfurToGold;
            float goldToDiamonds = 2000;
            float diamondsToGold = 1f/oneDiamondToGold;
            float sulfurToDiamonds = 2;
            float diamondsToSulfur = 1f/oneDiamondToSulfur;
            float valueConvert;
            string goldName = "золото";
            string sulfurName = "серу";
            string diamondName = "алмаз";
            string choice;
            bool finishConvert = false;
            float maxValueForConvert;

            Console.WriteLine("Добро пожаловать в мою лавку! Здесь вы можете:");
            Console.WriteLine("1. Обменять " + goldName + " на " + sulfurName + " по курсу: " + goldToSulfur);
            Console.WriteLine("2. Обменять " + sulfurName + " на " + goldName + " по курсу: " + sulfurToGold);
            Console.WriteLine("3. Обменять " + goldName + " на " + diamondName + " по курсу: " + goldToDiamonds);
            Console.WriteLine("4. Обменять " + diamondName + " на " + goldName + " по курсу: " + diamondsToGold);
            Console.WriteLine("5. Обменять " + sulfurName + " на " + diamondName + " по курсу: " + sulfurToDiamonds);
            Console.WriteLine("6. Обменять " + diamondName + " на " + sulfurName + " по курсу: " + diamondsToSulfur);
            Console.WriteLine("Введите, сколько у Вас валюты:");
            Console.Write("Золота: ");
            float gold = Convert.ToSingle(Console.ReadLine());
            Console.Write("Серы: ");
            float sulfur = Convert.ToSingle(Console.ReadLine());
            Console.Write("Алмазов: ");
            float diamonds = Convert.ToSingle(Console.ReadLine());

            while (finishConvert == false)
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
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert= valueConvert * goldToSulfur;

                        if (maxValueForConvert > gold)
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
                        Console.Write("Сколько Вы хотите приобрести золота?: ");
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert = valueConvert * sulfurToGold;

                        if (maxValueForConvert > sulfur)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять алмазы на серу в моем магазине!");
                        }
                        else
                        {
                            sulfur -= valueConvert * sulfurToGold;
                            gold += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert = valueConvert * goldToDiamonds;

                        if (maxValueForConvert > gold)
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
                        Console.Write("Сколько Вы хотите приобрести золота?: ");
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert = valueConvert * diamondsToGold;

                        if (maxValueForConvert > diamonds)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять серу на алмазы в моем магазине!");
                        }
                        else
                        {
                            sulfur -= valueConvert * diamondsToGold;
                            gold += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " золота!");
                        }

                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write("Сколько Вы хотите приобрести алмазов?: ");
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert = valueConvert * sulfurToDiamonds;

                        if (maxValueForConvert > sulfur)
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
                        Console.Write("Сколько Вы хотите приобрести серы?: ");
                        valueConvert = Convert.ToSingle(Console.ReadLine());
                        maxValueForConvert = valueConvert * diamondsToSulfur;

                        if (maxValueForConvert > diamonds)
                        {
                            Console.WriteLine("У Вас недостаточно средств! Вы можете обменять золото на алмазы в моем магазине!");
                        }
                        else
                        {
                            diamonds -= valueConvert * diamondsToSulfur;
                            sulfur += valueConvert;
                            Console.WriteLine("Обмен успешно совершен! Вы приобрели " + valueConvert + " серы!");
                        }

                        Console.ReadKey();
                        break;
                    case "Exit":
                        Console.WriteLine("Приходите к нам ещё!");
                        finishConvert = true;
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