
using System;

namespace  current{
   
   public class currentAccount : IActions
{

    
      public static long balance=100;
  public void deposit(long newamount) 
  {

   balance+=newamount;
   Console.WriteLine(newamount +"deposited successfully");
   
  }

  public void withdrawal(long newamount) 
  {
    
   balance-=newamount;
   Console.WriteLine(newamount +"withdrawn successfully");
  }

  public long getbalance()
  {
      return balance;
  }
}

}