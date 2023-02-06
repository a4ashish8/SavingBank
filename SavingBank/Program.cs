using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingBank
{
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Account type : \n 1. for Current Account " 
                   + "\n 2.for Saving Account");
            int a = int.Parse(Console.ReadLine());
            switch (a) 
            { 
                case 1:
                    Console.WriteLine("Welcome to your current bank account section");
                    CurrentAccountClass current = new CurrentAccountClass();
                    current.Deposit_ammount(1234);
                    current.WithDrawl_Ammount(34);
                    current.Check_Ammount();
                    break;

                case 2:
                    Console.WriteLine("Welcome to your Saving bank account section");
                    SavingAccount save = new SavingAccount();
                    save.Deposit_ammount(11222);
                    save.WithDrawl_Ammount(23);
                    save.Check_Ammount();
                    break;


                    default: 
                              Console.WriteLine("enter a valid no. ");
                              break;
            }
           // Console.ReadLine();
        }
    }
}
