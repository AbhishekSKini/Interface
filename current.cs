
namespace  current{
   
   public class currentAccount : IActions
{

    
      public  static long balance=0;
  public void deposit(long newamount) 
  {

   balance+=newamount;
   
  }

  public void withdrawal(long newamount) 
  {
    
   balance-=newamount;
  }

  public long getbalance()
  {
      return balance;
  }
}

}