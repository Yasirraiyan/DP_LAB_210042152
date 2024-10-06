  class Program
{
    public static void Main(string[] args)
    {
        EncryptionService encryptionService = new EncryptionService();

        int type;
        Console.WriteLine("Enter Type:");
        Console.ReadLine();
        Console.WriteLine("Select encryption algorithm:");
       Console.ReadLine();
        Console.WriteLine("AES");
        Console.WriteLine("DES");
        Console.WriteLine("Caesar Cipher:");
         void getfile(int type)
        {
            if (type == 1)
            {
                Console.WriteLine("AES");
            }
            if (type == 2)
            {
                Console.WriteLine("DES");
            }
            if (type == 3)
            {
                Console.WriteLine("Caesar Cipher");
            }
        }




    }
