public class AccountService {
    private String accName;
    public AccountService(String accountName) {
        accName = accountName;
    }

    public bool isValid(String accountName) {
        return accName == accountName;
    }
    

}