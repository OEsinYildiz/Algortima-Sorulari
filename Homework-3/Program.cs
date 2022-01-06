using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) ThrowException.Ex();
            string[] arr = new string[n];
            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine($"{i}. kelimeyi giriniz");
                arr[i - 1] = Console.ReadLine();
            }
            Console.WriteLine("______________");
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    
    static class ThrowException
    {
        internal static void Ex()
        {
            throw new Exception("Pozitif sayı girmelisiniz");
        }
    }
}