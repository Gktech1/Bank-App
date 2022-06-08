using BankTaskApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BankTaskApp.Business_Logic;
using BankTaskApp.Common;


namespace BankingTaskApp
{
    public class Database
    {
        static string location = "customer-data.txt";

        /// <summary>
        /// These are the list of customers, bankAccount and Transaction
        /// </summary>
        public static List<Customer> customerList = new List<Customer>();
        public static List<Account> accountList = new List<Account>();
        public static List<Transactions> transactionsList = new List<Transactions>();


        public static void SaveCustomerToFile()
        {
            var customerDetails = new List<string>();
            foreach (var customer in customerList)
            {
                customerDetails.Add($"{customer.Id},{customer.FullName},{customer.PhoneNumber},{customer.Email},{customer.PassWord}, {customer.AccountType}");
            }
            File.WriteAllLinesAsync(location, customerDetails);
        }

        public static async Task GetCustomerFromFile()
        {
            if (File.Exists(location))
            {
                var lines = await File.ReadAllLinesAsync(location);
                foreach (var line in lines)
                {
                    var customerDetails = line.Split(',');

                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(customerDetails[0]);
                    customer.FullName = customerDetails[1];
                    customer.PhoneNumber = customerDetails[2];
                    customer.Email = customerDetails[3];
                    customer.PassWord = customerDetails[4];

                    customerList.Add(customer);
                }
            }
        }
    }
}
