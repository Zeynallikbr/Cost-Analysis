using System.Numerics;

namespace Xərclərin_analizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] food = new double[7, 10];
            double[,] transportation = new double[7, 10];
            double[,] education = new double[7, 10];
            double[,] communication = new double[7, 10];
            double[,] utility = new double[7, 10];
            double[,] other = new double[7, 10];
            bool flag = true;
            for (int day = 0; day < 7; day++)
            {
                Console.WriteLine($"Gun {day + 1}: ");
                while (flag)
                {
                    Console.Write($"{day + 1}. gun ucun xerc varmi(y/n): ");
                    char yesOrNo = Convert.ToChar(Console.ReadLine());
                    int expenseCount = 0;
                    if (yesOrNo == 'y')
                    {
                        Console.WriteLine("Zehmet olmasa xercin novunu daxil edin: ");
                        Console.WriteLine("Qida\n" +
                            "Neqliyyat\n" +
                            "Tehsil\n" +
                            "Kommunikasiya\n" +
                            "Kommunal\n" +
                            "Diger");
                        string typeOfExpense = Console.ReadLine();
                        Console.Write($"Zehmet olmasa Tutari daxil edin:");
                        float total = Convert.ToSingle(Console.ReadLine());
                        if (typeOfExpense == "Qida")
                        {
                            food[day, expenseCount] = total;

                        }
                        else if (typeOfExpense == "Neqliyyat")
                        {
                            transportation[day, expenseCount] = total;

                        }
                        else if (typeOfExpense == "Tehsil")
                        {
                            education[day, expenseCount] = total;

                        }
                        else if (typeOfExpense == "Kommunikasiya")
                        {
                            communication[day, expenseCount] = total;

                        }
                        else if (typeOfExpense == "Kommunal")
                        {
                            utility[day, expenseCount] = total;

                        }
                        else if (typeOfExpense == "Diger")
                        {
                            other[day, expenseCount] = total;

                        }
                        else
                        {
                            Console.WriteLine("XETA");
                        }
                        Console.WriteLine("başqa xərc varmı(y/n): ");
                        char yesOrNo2 = Convert.ToChar(Console.ReadLine());
                        if (yesOrNo2 != 'y')
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                    expenseCount++;
                }
            }
            double totalFood = SumArray(food);
            double totalTransportation = SumArray(transportation);
            double totaleducation = SumArray(education);
            double totalCommunication = SumArray(communication);
            double totalUtility = SumArray(utility);
            double totalOther = SumArray(other);

            double totalExpenses = totalFood + totalTransportation + totaleducation + totalCommunication + totalUtility + totalOther;
            double[] totals = { totalFood, totalTransportation, totaleducation, totalCommunication, totalUtility, totalOther };
            string[] totalsName = { "Qida", "Neqliyyat", "Tehsil", "Kommunikasiya", "Kommunal", "Diger" };

            double maxPayout = totals[0];
            double minPayout = totals[0];

            string maxPayoutType = totalsName[0];
            string minPayoutType = totalsName[0];


            for (int i = 1; i < totals.Length; i++)
            {
                if (totals[i] > maxPayout)
                {
                    maxPayout = totals[i];
                    maxPayoutType = totalsName[i];
                }
                else if (totals[i] < minPayout)
                {
                    minPayout = totals[i];
                    minPayoutType = totalsName[i];
                }
            }
            double average = totalExpenses / 7;
            Console.WriteLine($"Həftə ərzində toplam xərc: {totalExpenses}");
            Console.WriteLine($"Ən çox hansı növ üçün xərc çəkilib: '{maxPayoutType}'  və miqdarı: {maxPayout}");
            Console.WriteLine($"Ən az hansı növ üçün xərc çəkilib: '{minPayoutType}'  və miqdarı: {minPayout}");
            Console.WriteLine($"Günlük ortalama xərc: {average}");


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
