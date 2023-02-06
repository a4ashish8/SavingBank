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
                    CurrentAccountClass obj = new CurrentAccountClass();
                    Console.WriteLine("enter the Banking type  \n 1. For deposit \n 2. for withdraw \n 3. for balance check");
                    int b = int.Parse(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            obj.Deposit_ammount(123);
                            break;

                        case 2:
                            obj.WithDrawl_Ammount(87);
                            break;

                        case 3:
                            obj.Check_Ammount();
                            Console.WriteLine("your total balance is: {0}", obj.Check_Ammount());
                            break;

                        default:
                            Console.WriteLine("enter a valid no.");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Welcome to your Saving bank account section");
                    CurrentAccountClass save = new CurrentAccountClass();
                    Console.WriteLine("enter the Banking type  \n 1. For deposit \n 2. for withdraw \n 3. for balance check");
                    int c = int.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            save.Deposit_ammount(123);
                            break;

                        case 2:
                            save.WithDrawl_Ammount(87);
                            break;

                        case 3:
                            save.Check_Ammount();
                            Console.WriteLine("your total balance is: {0}", save.Check_Ammount());
                            break;

                        default:
                            Console.WriteLine("enter a valid no.");
                            break;

                    }
                    break; 

                    default: 
                              Console.WriteLine("enter a valid no. ");
                              break;
            }
           // Console.ReadLine();
        }
    }
}
