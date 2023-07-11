// See https://aka.ms/new-console-template for more information
using OldPhoneKeyPad;


internal class Program
{
    private static void Main(string[] args)
    {        
        Console.WriteLine(KeyPad.OldPhonePad("33#"));
        Console.WriteLine(KeyPad.OldPhonePad("227*#"));
        Console.WriteLine(KeyPad.OldPhonePad("4433555 555666#"));
        Console.WriteLine(KeyPad.OldPhonePad("8 88777444666*664#"));
    }
}