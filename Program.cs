// See https://aka.ms/new-console-template for more information

namespace MySuperBank
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("Dav", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

      account.MakeWithdrawal(120, DateTime.Now, "Hammock");
      Console.WriteLine(account.Balance);

      account.MakeWithdrawal(100, DateTime.Now, "PS%");
      Console.WriteLine(account.Balance);

      account.MakeWithdrawal(200, DateTime.Now, "Iphone");
      Console.WriteLine(account.Balance);
      
      
      // Test for a negative balance.
      try
      {
        account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Exception caught trying to overdraw");
        Console.WriteLine(e.ToString());
      }

      try
      {
        var invalidAccount = new BankAccount("invalid", -55);
      }
      catch (ArgumentOutOfRangeException e)
      {
        Console.WriteLine("Exception caught creating account with negative balance");
        Console.WriteLine(e.ToString());
      }

      account.MakeWithdrawal(50, DateTime.Now, "Last");
      Console.WriteLine(account.Balance + " Baaa");
    Console.WriteLine(account.GetAccountHistory());
    }
  }
}