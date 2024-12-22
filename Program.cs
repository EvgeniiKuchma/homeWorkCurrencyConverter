using System;

namespace homeWorkCurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandConvertRublesToDollars = "1";
            const string CommandConvertRublesToCubles = "2";
            const string CommandConvertCublesToDollars = "3";
            const string CommandConvertCublesToRubles = "4";
            const string CommandConvertDollarsToRubles = "5";
            const string CommandConvertDollarsToCubles = "6";
            const string CommandExitProgramm = "7";

            float numberСonvertibleСurrency;
            float numberDollars = 100f;
            float numberRubels = 1000f;
            float numberCubles = 100f;
            int rublesToDollars = 100;
            int rublesToCubles = 110;
            int cublesToDollars = 2;
            int cublesToRubles = 11;
            int dollarsToRubles = 10;
            int dollarsToCubles = 1;
            bool isRunnig = true;
            string userInput;
             
            while (isRunnig)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Choose your operation: ");
                Console.WriteLine($"{CommandConvertRublesToDollars}.Convert rubeles to dollars;");
                Console.WriteLine($"{CommandConvertRublesToCubles}.Convert rubles to cubles;");
                Console.WriteLine($"{CommandConvertCublesToDollars}.Convert cubles to dollars;");
                Console.WriteLine($"{CommandConvertCublesToRubles}.Convert cubles to rubles;");
                Console.WriteLine($"{CommandConvertDollarsToRubles}.Convert dollars to rubles;");
                Console.WriteLine($"{CommandConvertDollarsToCubles}.Convert dollars to cubles;");
                Console.WriteLine($"{CommandExitProgramm}.Exit to programm;");
                Console.WriteLine($"Now do your have {numberDollars} dollars, {numberRubels} rubles, {numberCubles} cubles;");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandConvertRublesToDollars:
                        Console.WriteLine("Convert rubeles to dollars");
                        Console.Write("How many rubles you want to convert to dollars: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberRubels >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberRubels -= numberСonvertibleСurrency;
                            numberDollars += numberСonvertibleСurrency / rublesToDollars;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandConvertRublesToCubles:
                        Console.WriteLine("Convert rubeles to cubels");
                        Console.Write("How many rubles you want to convert to cubels: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberRubels >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberRubels -= numberСonvertibleСurrency;
                            numberCubles += numberСonvertibleСurrency / rublesToCubles;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandConvertCublesToDollars:
                        Console.WriteLine("Convert cubles to dollars");
                        Console.Write("How many cubles you want to convert to dollars: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberCubles >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberCubles -= numberСonvertibleСurrency;
                            numberDollars += numberСonvertibleСurrency / cublesToDollars;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandConvertCublesToRubles:
                        Console.WriteLine("Convert cubles to rubles");
                        Console.WriteLine("How many cubles you want to convert to rubles: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberCubles >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberCubles -= numberСonvertibleСurrency;
                            numberRubels += numberСonvertibleСurrency * cublesToRubles;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandConvertDollarsToRubles:
                        Console.WriteLine("Convert dollars to rubles");
                        Console.WriteLine("How many dollars you want to convert to rubles: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberDollars >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberDollars -= numberСonvertibleСurrency;
                            numberRubels += numberСonvertibleСurrency * dollarsToRubles;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandConvertDollarsToCubles:
                        Console.WriteLine("Convert dollars to cubles");
                        Console.WriteLine("How many dollars you want to convert to cubles: ");
                        numberСonvertibleСurrency = Convert.ToSingle(Console.ReadLine());

                        if (numberDollars >= numberСonvertibleСurrency && numberСonvertibleСurrency > 0)
                        {
                            numberDollars -= numberСonvertibleСurrency;
                            numberCubles += numberСonvertibleСurrency / dollarsToCubles;
                        }
                        else
                        {
                            Console.WriteLine("Wromng currency number, nry again.");
                        }
                        break;

                    case CommandExitProgramm:
                        Console.WriteLine("Good bye!");
                        isRunnig = false;
                        break;

                    default:
                        Console.WriteLine("Wrong menu command! Try again");
                        break;
                }
            }

        }
    }
}
