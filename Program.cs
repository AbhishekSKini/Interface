using System;
using current;
using recurring;
using savings;

namespace Interface
{
    


class Program 
{
  static void Main(string[] args) 
  {
    
    Console.WriteLine("Enter the type of account 1.current 2.recurring 3.savings");
            string v = Console.ReadLine();
            int acctype = Int16.Parse(v);
     
         
         //account type 
    switch(acctype) 
    {
    case 1:
    {
           currentAccount curr = new currentAccount();//object for current account
            Console.WriteLine("1.deposit 2.withdraw 3.checkbalance");
            string inpaction = Console.ReadLine();
            int accaction = Int16.Parse(inpaction);
            //operations
            switch(accaction)
            {
                case 1:
                { 
                     Console.WriteLine("Enter the amount to deposit");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    curr.deposit(amt);
                    break;
                }

                case 2:
                { 
                     Console.WriteLine("Enter the amount to withdraw");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    curr.withdrawal(amt);
                     Console.WriteLine("the balance is " + curr.getbalance());
                    break;
                }

                case 3:
                { 
                    Console.WriteLine("the balance is " + curr.getbalance());
                    break;
                }
            }

   

  
    break;
    }

      case 2:
    
   {
            recurringAccount rec = new recurringAccount();//object for recurring account
            Console.WriteLine("1.deposit 2.withdraw 3.checkbalance");
            string inpaction = Console.ReadLine();
            int accaction = Int16.Parse(inpaction);

            switch(accaction)
            {
                case 1:
                { 
                     Console.WriteLine("Enter the amount to deposit");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    rec.deposit(amt);
                    break;
                }

                case 2:
                { 
                     Console.WriteLine("Enter the amount to withdraw");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    rec.withdrawal(amt);
                    Console.WriteLine("the balance is " + rec.getbalance());
                    break;
                }

                case 3:
                { 
                    Console.WriteLine("the balance is " + rec.getbalance());
                    break;
                }
            }

   

 
    break;
   }
case 3:
{
          savingsAccount sav = new savingsAccount();//object for savings account
            Console.WriteLine("1.deposit 2.withdraw 3.checkbalance");
            string inpaction = Console.ReadLine();
            int accaction = Int16.Parse(inpaction);

            switch(accaction)
            {
                case 1:
                { 
                     Console.WriteLine("Enter the amount to deposit");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    sav.deposit(amt);
                    break;
                }

                case 2:
                { 
                     Console.WriteLine("Enter the amount to withdraw");
                     string amtstring = Console.ReadLine();
                      int amt = Int16.Parse(amtstring);
                    sav.withdrawal(amt);
                    Console.WriteLine("the balance is " + sav.getbalance());
                    break;
                }

                case 3:
                { 
                    Console.WriteLine("the balance is " + sav.getbalance());
                    break;
                }
            }
  break;
}
    

    default:
    {
          Console.WriteLine("Choose the correct account type");
          break;
    }
   
    }
    
  }
} 
}
