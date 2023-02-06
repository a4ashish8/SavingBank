using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingBank
{
    public class SavingAccount : IBankAccount
    {
        private float Balance = 0;
        private readonly float PerDayWithdrawLimit = 10000;
        private float TodayWithdrawal = 0;
        
        public bool Deposit_ammount(float DAmmount)
        {

            Balance = Balance + DAmmount;
            Console.WriteLine($"You have Deposited: {DAmmount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;

        }

        public bool WithDrawl_Ammount(float WAmmount)
        {
            if (Balance < WAmmount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithdrawal + WAmmount > PerDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - WAmmount;
                //TodayWithdrawal = TodayWithdrawal + Amount;
                Console.WriteLine($"You have Successfully Withdraw: {WAmmount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }
        }
        public float Check_Ammount()
        {
            return Balance;
        }
    }
}