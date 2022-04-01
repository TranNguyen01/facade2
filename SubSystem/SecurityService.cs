public class SercurityService {
    private string code;
    public SercurityService(string secCode){
        this.code = secCode;
    }

    public bool isValid(string secCode){
        return this.code == secCode;
    }
}