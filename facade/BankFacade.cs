public class BankFacade {
    private String accountName;
    private string securityCode;

    AccountService accountService;
    SercurityService sercurityService;
    CashService cashService;
    public BankFacade(String accountName, string securityCode) {
        this.accountName = accountName;
        this.securityCode = securityCode;

        accountService = new AccountService(accountName);
        sercurityService = new SercurityService(securityCode);
        cashService = new CashService(500);
    }

    public void depositCash(double cashAmount) {
        if(accountService.isValid(accountName) && sercurityService.isValid(securityCode)) {
            cashService.deposit(cashAmount);
            Console.WriteLine("Hoan thanh");
        } else {
            Console.WriteLine("Khong hop le");
        }
    }

    public void withdrawCash(double cashAmount) {
        if(accountService.isValid(accountName)
                && sercurityService.isValid(securityCode)
                && cashService.haveEnoughMoney(cashAmount)) {
            cashService.withdraw(cashAmount);
            Console.WriteLine("Hoan thanh");
        } else {
            Console.WriteLine("Khong hop le");
        }
    }
}