public class SecurityService {
    private string code;
    public SecurityService(string secCode){
        this.code = secCode;
    }

    public bool isValid(string secCode){
        return this.code == secCode;
    }
}