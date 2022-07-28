using BankingTaskApp;
using BankTaskApp.Business_Logic.Services;
using Moq;
using System;
using Xunit;

namespace BankAppTest
{
    public class BankAppTest
    {
        private readonly AccountServices services;
        public BankAppTest()
        {
            services = new AccountServices();
            
        }

        [Fact]
        public void GetAccountNumberByNameTest()
        {
            services.CreateBankAccount("Kunle Ado.Net", 1000, "Savings", 20345678901);
            string name = "Kunle Ado.Net";
            
            //Actual
            var arrage = services.GetAccountNumberByName(name);

            //Expected
            var expected = 20345678901;

            Assert.Equal(expected, arrage);
            var count1 = Database.accountList.Count;
            Assert.NotNull(Database.accountList);
            Assert.NotNull(Database.transactionsList);
           
        }


        [Fact]
        public void GetCreateBankAccountTest()
        {
            //Expected
            string name = "Kunle Ado.Net";
            
            var count = Database.transactionsList.Count;
            var count1 = Database.accountList.Count;
            Assert.NotNull(Database.accountList);
            Assert.NotNull(Database.transactionsList);
            Assert.Equal(1, count);
            Assert.Equal(1,count1);
        }

        

        [Fact]
        public void TraansactionDBTest()
        {
            AccountServices sut = new AccountServices();

            var res = sut.MakeWithdraw("deposit", 4000, "Money", 2345879089);
            
            Assert.NotEmpty(Database.transactionsList);

        }

        [Fact]
        public void CustomerDBTest()
        {
            CustomerServices sut = new CustomerServices();

            sut.CustomerRegistration("Olukunle Edun", "kunle_edun@yahoo.com", "pass12@", "Savings", "08169688127");

            Assert.NotNull(Database.transactionsList);

        }

    }
}
