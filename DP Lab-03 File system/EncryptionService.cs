public class EncryptionService
{
    private IEncryption encryption;
   
    public void setEncryption(IEncryption encryption)
    {
        this.encryption = encryption;

    }
   public void EncryptFile(string inputfile,string outputfile)
    {
        string plaintext=File.ReadAllText(inputfile);
        string cyphertext=File.ReadAllText(outputfile);
    }
    public void DecryptFile(string inputfile, string outputfile)
    {
        string ciphertext=File.ReadAllText(inputfile);
        string plaintext=File.ReadAllText(outputfile);
    }
}
