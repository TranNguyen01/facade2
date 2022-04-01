BankFacade bankFacade = new BankFacade("uitAccount", "code");

bankFacade.depositCash(1000);
Console.WriteLine();

bankFacade.withdrawCash(1000);
Console.WriteLine();

