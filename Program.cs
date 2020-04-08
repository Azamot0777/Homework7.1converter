using System;

namespace Homework7_1Converter
{
    class Converter
    {
        public double usd { get; set; }
        public double euro { get; set; }

        public double rubl { get; set; }

        public Converter(double usd, double euro, double rubl)
        {
            this.usd = usd;
            this.euro = euro;
            this.rubl = rubl;
        }
        public SomoniToUsd(double somoni)
        {
            double usd = Math.Round(somoni * usd);
            return usd;
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
