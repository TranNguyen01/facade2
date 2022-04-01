public class CashService {
    private double cashInAccount;
    public CashService(double cashAmount) {
        this.cashInAccount = cashAmount;
    }

    public void deposit(double cashAmount) {
        cashInAccount += cashAmount;
        Console.WriteLine("Cash in account: " + cashInAccount);
    }

    public bool haveEnoughMoney(double cashAmount) {
        return cashInAccount > cashAmount;
    }

    public void withdraw(double cashAmount) {
        cashInAccount -= cashAmount;
        Console.WriteLine("Cash in account: " + cashInAccount);
    }
}