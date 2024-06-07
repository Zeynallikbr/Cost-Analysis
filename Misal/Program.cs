using System;

namespace WeeklyExpenses
{
    class Program
    {
        // Massivlər
        static double[,] foodExpenses = new double[7, 10];
        static double[,] transportExpenses = new double[7, 10];
        static double[,] educationExpenses = new double[7, 10];
        static double[,] communicationExpenses = new double[7, 10];
        static double[,] utilityExpenses = new double[7, 10];
        static double[,] otherExpenses = new double[7, 10];

        static void Main(string[] args)
        {
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"Gün {day + 1}:");
                int expenseCount = 0;
                while (true)
                {
                    Console.Write("Bu gün üçün xərc var mı? (bəli/xeyr): ");
                    string hasExpense = Console.ReadLine().ToLower();
                    if (hasExpense == "xeyr")
                    {
                        break;
                    }
                    Console.WriteLine("Xərclər növünü seçin:");
                    Console.WriteLine("1. Qida");
                    Console.WriteLine("2. Nəqliyyat");
                    Console.WriteLine("3. Təhsil");
                    Console.WriteLine("4. Kommunikasiya");
                    Console.WriteLine("5. Kommunal");
                    Console.WriteLine("6. Digər");
                    int expenseType = int.Parse(Console.ReadLine());

                    Console.Write("Xərclərin miqdarını daxil edin: ");
                    double amount = double.Parse(Console.ReadLine());

                    switch (expenseType)
                    {
                        case 1:
                            foodExpenses[day, expenseCount] = amount;
                            break;
                        case 2:
                            transportExpenses[day, expenseCount] = amount;
                            break;
                        case 3:
                            educationExpenses[day, expenseCount] = amount;
                            break;
                        case 4:
                            communicationExpenses[day, expenseCount] = amount;
                            break;
                        case 5:
                            utilityExpenses[day, expenseCount] = amount;
                            break;
                        case 6:
                            otherExpenses[day, expenseCount] = amount;
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim, yenidən cəhd edin.");
                            continue;
                    }

                    expenseCount++;
                }
            }

            AnalyzeExpenses();
        }

        static void AnalyzeExpenses()
        {
            double totalFood = SumArray(foodExpenses);
            double totalTransport = SumArray(transportExpenses);
            double totalEducation = SumArray(educationExpenses);
            double totalCommunication = SumArray(communicationExpenses);
            double totalUtility = SumArray(utilityExpenses);
            double totalOther = SumArray(otherExpenses);

            double totalExpenses = totalFood + totalTransport + totalEducation + totalCommunication + totalUtility + totalOther;
            double[] totals = { totalFood, totalTransport, totalEducation, totalCommunication, totalUtility, totalOther };
            string[] expenseNames = { "Qida", "Nəqliyyat", "Təhsil", "Kommunikasiya", "Kommunal", "Digər" };

            double maxExpense = totals[0];
            double minExpense = totals[0];
            string maxExpenseType = expenseNames[0];
            string minExpenseType = expenseNames[0];

            for (int i = 1; i < totals.Length; i++)
            {
                if (totals[i] > maxExpense)
                {
                    maxExpense = totals[i];
                    maxExpenseType = expenseNames[i];
                }
                if (totals[i] < minExpense)
                {
                    minExpense = totals[i];
                    minExpenseType = expenseNames[i];
                }
            }

            double dailyAverage = totalExpenses / 7;

            Console.WriteLine($"Həftə ərzində toplam xərc: {totalExpenses}");
            Console.WriteLine($"Ən çox xərc çəkilən növ: {maxExpenseType}, miqdarı: {maxExpense}");
            Console.WriteLine($"Ən az xərc çəkilən növ: {minExpenseType}, miqdarı: {minExpense}");
            Console.WriteLine($"Günlük ortalama xərc: {dailyAverage}");
        }

        static double SumArray(double[,] array)
        {
            double sum = 0;
            foreach (double value in array)
            {
                sum += value;
            }
            return sum;
        }
    }
}
