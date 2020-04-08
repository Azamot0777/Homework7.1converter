using System;

namespace Homework7_1Converter
{
    class Converter
    {
        public double usd { get; set; }
        public double euro { get; set; }

        public double rubl { get; set; }

        public Converter(double ust, double euroc, double rub)
        {
            this.usd = ust;
            this.euro = euroc;
            this.rubl = rub;
        }
        public static double cSomoniToUsd(double somoni)
        {
            double usd = Math.Round(somoni * usd);
            return usd;
        }
        public static double cSomoniToEuro(double somoni)
        {
            double euro = Math.Round(somoni * euro);
            return euro;
        }
        public static double cSomoniToRubl(double somoni)
        {
            double rubl = Math.Round(somoni * rubl);
            return rubl;
        }
        public static double cUsdToSomoni(double us)
        {
            if (usd != 0)
            {
                double som = Math.Round(ust / usd);
                return som;
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
                double som = Math.Round(euroc / euro);
                return som;
            }
            else
            {
                Console.WriteLine("Ошибка2");
                return 0;
            }
        }
        public static double cRublToSomoni(double rub)
        {
            if (rub != 0)
            {
                double som = Math.Round(rubl / rub, 4);
                return som;
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
            Console.WriteLine("Hello World!");
        }
    }
}
