using System;

namespace Homework7_1Converter
{
    class Converter
    {
        public static double usd { get; set; }
        public static double euro { get; set; }

        public static double rubl { get; set; }

        public Converter(double ust, double euroc, double rub)
        {
            usd = ust;
            euro = euroc;
            rubl = rub;
        }
        public static double cSomoniToUsd(double somoni)
        {
            double ust = Math.Round(somoni * usd);
            return ust;
        }
        public static double cSomoniToEuro(double somoni)
        {
            double euroc = Math.Round(somoni * euro);
            return euroc;
        }
        public static double cSomoniToRubl(double somoni)
        {
            double rub = Math.Round(somoni * rubl);
            return rub;
        }
        public static double cUsdToSomoni(double ust)
        {
            if (usd != 0)
            {
                double somoni = Math.Round(ust / usd);
                return somoni;
            }
            else
            {
                Console.WriteLine("Ошибка1");
                return 0;
            }
        }
        public static double cEuroToSomoni(double euroc)
        {
            if (euro != 0)
            {
                double somoni = Math.Round(euroc / euro);
                return somoni;
            }
            else
            {
                Console.WriteLine("Ошибка2");
                return 0;
            }
        }
        public static double cRublToSomoni(double rub)
        {
            if (rubl != 0)
            {
                double somoni = Math.Round(rub / rubl, 4);
                return somoni;
            }
            else
            {
                Console.WriteLine("Ошибка3");
                return 0;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Converter h = new Converter(0.098, 0.091, 7.33);

            Console.Write("Обмен валют на доллары,евро и рубли");
            Console.WriteLine("Тип конвертации");
            Console.WriteLine("Сомони в доллары : 1");
            Console.WriteLine("Сомони в евро : 2");
            Console.WriteLine("Сомони в рубли : 3");
            Console.WriteLine("Доллары в сомони : 4");
            Console.WriteLine("Евро в сомони : 5");
            Console.WriteLine("Рубли в сомони : 6");

            int choice;
            while (true)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 6) System.Console.WriteLine("Ошибка");
                else break;
            }
            System.Console.WriteLine("Введите сумму : ");
            double sum = double.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{sum} сомони == {Converter.cSomoniToUsd(sum)} долларов");
                    break;
                case 2:
                    Console.WriteLine($"{sum} сомони == {Converter.cSomoniToEuro(sum)} евро");
                    break;
                case 3:
                    Console.WriteLine($"{sum} сомони == {Converter.cSomoniToRubl(sum)} рубли");
                    break;
                case 4:
                    Console.WriteLine($"{sum} доллары == {Converter.cUsdToSomoni(sum)} сомони");
                    break;
                case 5:
                    Console.WriteLine($"{sum} евро == {Converter.cEuroToSomoni(sum)} сомони");
                    break;
                case 6:
                    Console.WriteLine($"{sum} рубли == {Converter.cRublToSomoni(sum)} сомони");
                    break;
                default:
                    break;
            }


        }
    }
}
