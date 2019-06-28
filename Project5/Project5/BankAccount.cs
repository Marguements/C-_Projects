using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    abstract class BankAccount
    {
        const int ACCOUNT_NUMBER_START = 1000000;
        const decimal ANNUAL_INTEREST_RATE = 5.25m;

        int accountNum;
        string firstName, lastName;
        decimal balance;
        decimal annualInterestRate;

        protected BankAccount()
        {
            if (accountNum < ACCOUNT_NUMBER_START)
            {
                accountNum = ACCOUNT_NUMBER_START;
            }
            else
            {
                accountNum += 1;
            }
            firstName = string.Empty;
            lastName = string.Empty;
            balance = new decimal();
            annualInterestRate = new decimal();
        }

        protected BankAccount(string firstName, string lastName, decimal balance)
        {
            if (accountNum < ACCOUNT_NUMBER_START)
            {
                accountNum = ACCOUNT_NUMBER_START;
            }
            else
            {
                accountNum += 1;
            }
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
            annualInterestRate = ANNUAL_INTEREST_RATE;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
}
