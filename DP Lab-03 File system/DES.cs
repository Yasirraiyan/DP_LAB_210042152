public class DES : IEncryption
{
    private readonly byte[] key;
    private readonly byte[] iv;
    public DES(byte[] key, byte[] iv)
    {
        this.key = key;
        this.iv = iv;
    }

   public string Encrypt(string plaintext)
    {
        return plaintext;
    }
    public string Decrypt(string ciphertext)
    {
        return ciphertext;

    }

}
