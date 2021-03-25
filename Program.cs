using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBank ing = new ING();
            IBank bt = new BT();
            Console.WriteLine($"ING converts 100 EUR into {ING.");
            Console.ReadKey();
        }
    }

    /*
        fiecare banca are propriul schimb valutar
        ING: 1 EUR = 4.8554 RON
        BT: 1 EUR = 4.7554 RON
        GOAL: Create banks that exchange from EUR to RON currency
    */

    public interface IBank // BT, ING
    {
        decimal ExchangeInRON(decimal valueInRON);
    }

    public interface IINGExchange // BT, ING
    {
        decimal Value();
    }

    public class ING : IBank
    {
        public decimal ExchangeInRON(decimal valueInRON)
        {
            decimal EURtoRONExchangeRate = 4.8554M;

            return valueInEUr * exchangeRate.Value();
        }

        public decimal ExchangeInRON(decimal valueInRON)
        {
            decimal EURtoRONExchangeRate = 4.8554M;

            return valueInEUr * exchangeRate.Value();
        }

    }

}
