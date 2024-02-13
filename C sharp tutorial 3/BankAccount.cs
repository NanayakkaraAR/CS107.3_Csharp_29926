namespace tutorial_2;

class BankAccount
{
    private int AccountNumber;
    public double Balance=1000;
    /*public BankAccount(double initialBal)
    {
        Balance = initialBal;
    }*/
    public void deposit(double amount)
    {
        Balance += amount;
    }

    static void Main(string[] args)
    {
        BankAccount Acc1 = new BankAccount();
        Console.WriteLine("Enter account number: ");
        Acc1.AccountNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Initial Balance is: " + Acc1.Balance);
    
        Console.WriteLine("Enter amount to deposit: ");
        double inputAmount = Convert.ToDouble(Console.ReadLine());
    
        Acc1.deposit(inputAmount);
        Console.WriteLine("New Balance is: " + Acc1.Balance);
    
        Console.ReadLine();
    }

}

