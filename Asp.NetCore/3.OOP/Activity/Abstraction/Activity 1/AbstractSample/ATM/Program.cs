using ATM;

internal class Program
{
    private static void Main(string[] args)
    {
        Atm myATM = new BankAtm(500.00m);

        myATM.CheckBalance();
        myATM.WithdrawMoney(100.00m);
        myATM.DepositMoney(200.00m);
        myATM.CheckBalance();

    }
}