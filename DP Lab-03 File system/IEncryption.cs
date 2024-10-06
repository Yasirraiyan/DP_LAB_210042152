public interface IEncryption
{
    string Encrypt(string plaintext);
    string Decrypt(string ciphertext);
}
