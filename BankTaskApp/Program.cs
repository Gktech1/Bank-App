using BankingTask3General;
using BankingTaskApp;
using System;

namespace BankTaskApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.GetCustomerFromFile().GetAwaiter();
            StartingPoint starting = new StartingPoint();
            starting.StartUI();

        }
    }
}
