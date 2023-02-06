using SavingBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingBank
{
    internal class CurrentAccountClass : IBankAccount
    {
        private float Balance = 0;

        public bool Deposit_ammount(float DAmmount)
        {
            Balance = Balance + DAmmount;
            Console.WriteLine("your balance is deposited : {0}", Balance);
            return true;
        }


        public bool WithDrawl_Ammount(float WAmmount)
        {
           
            if (Balance > WAmmount)
            {
                Balance = Balance - WAmmount;
                Console.WriteLine("your withdraw sucessful : {0}", WAmmount);
                return true;
               
            }
            else
            {
                Console.WriteLine("opration UnSucessfull");
                return false;
            }
            
        }
        public float Check_Ammount()
        {
            return Balance ;
        }
    }
}