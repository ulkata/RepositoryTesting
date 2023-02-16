using Bankinksystem;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinkSystem.Tests
{
    [TestFixture]
    class BankAccountTests
    {
        [Test]
        public void DepositShouldIncreaseBalance()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;


                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);




            }
        }
            [Test]
            public void ConstructorShouldSetZeroBalance()
            {
                int id = 123;
                BankAccount account = new BankAccount(id);
                Assert.AreEqual(0, account.Balance);
            }

        
        [Test]
        public void AccountInicializeWithPositiveValue()
        {
            BankAccount bankAccount = new BankAccount(123,2000m);
            Assert.AreEqual(2000m, bankAccount.Balance);
        }
    }
}
