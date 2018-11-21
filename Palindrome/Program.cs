using System;
using System.Globalization;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;

            Console.WriteLine("Insira sua palavra: ");
            a = Console.ReadLine();

            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            string b = new string(temp);

            if (a.Equals(b))
            {
                Console.WriteLine("É Palindrome");
            }
            else
            {
                Console.WriteLine("Não é palindrome");
            }

            Console.ReadLine();

        }
    }
}
