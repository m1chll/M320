namespace UserManager;

public class Program
{
    public static void Main(string[] args)
    {
        //CaesarCipher cipher = new CaesarCipher(10);
        var cipher = new VigenereCipher("white");
        User max = new User("max", "geheim", cipher);
        System.Console.WriteLine($"Encrypted Password of max is '{max.PasswordEncrypted}' " +
                                       $"(decrypted: '{cipher.Decrypt(max.PasswordEncrypted)}')");
    }
}