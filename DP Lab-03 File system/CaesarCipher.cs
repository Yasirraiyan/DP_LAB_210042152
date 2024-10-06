public class CaesarCipher :IEncryption
{
    private int shift;

    public CaesarCipher(int shift)
    {
        this.shift = shift;
    }
    public string Encrypt(string plainText)
    {
        return plainText;
    }

    public string Decrypt(string cipherText)
    {
        return cipherText;
    }

}
