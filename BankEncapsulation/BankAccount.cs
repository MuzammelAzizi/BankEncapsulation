using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        //Define a method named Deposit that will accept a double and store that value in the balance field

        public void Deposit(double amount)
        {
            balance = amount;
        }

        //Define a method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()
        {
            return balance;
        }
    }
  

    
}
