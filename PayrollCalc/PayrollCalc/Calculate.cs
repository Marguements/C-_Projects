using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollCalc
{
    class Calculate
    {
        const float MINIMUM_PAY = 10f;
        string firstName;
        string lastName;
        int idNumber;
        float payRate;

        Calculate()
        { }

        public Calculate(string firstName, string lastName, int idNumber, float payRate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = idNumber;
            this.payRate = payRate;
        }

        


    }
}
