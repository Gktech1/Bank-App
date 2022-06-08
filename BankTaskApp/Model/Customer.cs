﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingTaskApp;
using BankTaskApp.Business_Logic;
using BankTaskApp.Common;


namespace BankTaskApp.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string AccountType { get; set; }
        public string PhoneNumber { get; set; }

        /// <summary>
        /// This constructor is use to collect the following
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="acctType"></param>
        /// <param name="phone"></param>
        public Customer(int id, string fullname, string email, string password, string acctType, string phone)
        {
            FullName = fullname;
            Email = email;
            PassWord = password;
            AccountType = acctType;
            PhoneNumber = phone;
            Id = id;
        }

        public Customer()
        {
        }
    }
}
