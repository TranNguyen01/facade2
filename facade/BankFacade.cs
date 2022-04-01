public class BankFacade {
    private String accountName;
    private string securityCode;

    AccountService accountService;
    SecurityService securityService;
    CashService cashService;
    public BankFacade(String accountName, string securityCode) {
        this.accountName = accountName;
        this.securityCode = securityCode;

        accountService = new AccountService(accountName);
        securityService = new SecurityService(securityCode);
        cashService = new CashService(500);
    }

    public void depositCash(double cashAmount) {
        if(accountService.isValid(accountName) && securityService.isValid(securityCode)) {
            Console.ForegroundColor = ConsoleColor.Blue;
            cashService.deposit(cashAmount);
            Console.WriteLine("Hoan thanh");
            Console.ResetColor();
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Khong hop le");
            Console.ResetColor();

        }
    }

    public void withdrawCash(double cashAmount) {
        if(accountService.isValid(accountName)
                && securityService.isValid(securityCode)
                && cashService.haveEnoughMoney(cashAmount)) {
            Console.ForegroundColor = ConsoleColor.Blue;
            cashService.withdraw(cashAmount);
            Console.WriteLine("Hoan thanh");
            Console.ResetColor();
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Khong hop le");
            Console.ResetColor();
        }
    }
}