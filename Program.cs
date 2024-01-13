using System;
namespace PasswordGeneration
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Entre com a quantidade de caracteres para sua senha ser gerada: ");
            int passwordLength = int.Parse(Console.ReadLine());
            string password = PassRandon(passwordLength);
            Console.WriteLine("SENHA GERADA: ");
            Console.Write(password);
          
            
        }
        static string PassRandon(int size)
        {
            var capitalLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ";
            var smallLetter = capitalLetter.ToLower();
            var number = "123456789";
            var symbols = "*-+,;:.!@#$%&()-_=+";
            string finalPass = (number + smallLetter + capitalLetter + symbols) ;
            
            Random randPass = new Random();
            char[] pass = new char [size];
            for (int i=0;i<size;i++)
            {
                int aleatory = randPass.Next(finalPass.Length);
                pass[i] = finalPass[aleatory];
            }
            return new string(pass);
            
            
        }
       
    }
}