using System;

namespace exercise_109
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            this.balance = openingBalance;
        }


        public void AddMoney(double amount) 
        {
            // write code here
            if((this.balance + amount) >= 150)
            {
                this.balance = 150;
            }
            else if (amount < 0) 
            {
                this.balance = this.balance;
             
            }
            else
            {
                this.balance = this.balance + amount;
            }
        }

        public override string ToString()
        {
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}