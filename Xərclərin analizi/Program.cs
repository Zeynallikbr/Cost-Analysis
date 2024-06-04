namespace Xərclərin_analizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] food = new int[70];
            int[] transportation = new int[70];
            int[] education = new int[70];
            int[] communication = new int[70];
            int[] utility = new int[70];
            int[] other = new int[70];
            int week = 7;
            int dayCount = 0;
            float sum = 0;
            bool flag = true;
            for (int i = 0; i < week; i++)
            {
                Console.Write("Heftenin gununu daxil edin: ");
                dayCount = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i + 1}. gun ucun xerc varmi(y/n): ");
                char yesOrNo = Convert.ToChar(Console.ReadLine());
                while (flag)
                {

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
                            food[i] += 1;
                            sum += total;
                        }
                        else if (typeOfExpense == "Neqliyyat")
                        {
                            transportation[i] += 1;
                            sum += total;
                        }
                        else if (typeOfExpense == "Tehsil")
                        {
                            education[i] += 1;
                            sum += total;
                        }
                        else if (typeOfExpense == "Kommunikasiya")
                        {
                            communication[i] += 1;
                            sum += total;
                        }
                        else if (typeOfExpense == "Kommunal")
                        {
                            utility[i] += 1;
                            sum += total;
                        }
                        else if (typeOfExpense == "Diger")
                        {
                            other[i] += 1;
                            sum += total;
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
                }
            }

            Console.WriteLine($"Həftə ərzində toplam xərc: {sum} AZN");
            // Console.WriteLine($"Ən çox hansı növ üçün xərc çəkilib və miqdarı {} and {}");
        }
    }
}
